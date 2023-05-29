using InvenTrack.Model;
using InvenTrack.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MessageBox = System.Windows.Forms.MessageBox;

namespace InvenTrack.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        private int _id;
        private string _idSistema;
        private string _tipoEquipo;
        private string _marca;
        private string _serie;
        private string _modelo;
        private string _estado;
        private string _detalles;
        private string _activo;
        private string _buscar;
        private bool _isVisibleGuardar = true;
        private bool _isVisibleEditar = false;
        private bool _isVisibleEliminar = false;
        private EstadoModel _selectedEstado;

        private List<EquipoModel> _equipoList;

        private IEquipoRepository equipoRepository;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        public string IdSistema
        {
            get
            {
                return _idSistema;
            }
            set
            {
                _idSistema = value;
                OnPropertyChanged(nameof(IdSistema));
            }
        }
        public string TipoEquipo
        {
            get
            {
                return _tipoEquipo;
            }
            set
            {
                _tipoEquipo = value;
                OnPropertyChanged(nameof(TipoEquipo));
            }
        }
        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = value;
                OnPropertyChanged(nameof(Marca));
            }
        }
        public string Serie
        {
            get
            {
                return _serie;
            }
            set
            {
                _serie = value;
                OnPropertyChanged(nameof(Serie));
            }
        }
        public string Modelo
        {
            get
            {
                return _modelo;
            }
            set
            {
                _modelo = value;
                OnPropertyChanged(nameof(Modelo));
            }
        }
        public string Estado
        {
            get
            {
                return _estado;
            }
            set
            {
                _estado = value;
                OnPropertyChanged(nameof(Estado));
            }
        }
        public string Detalles
        {
            get
            {
                return _detalles;
            }
            set
            {
                _detalles = value;
                OnPropertyChanged(nameof(Detalles));
            }
        }
        public string Activo
        {
            get
            {
                return _activo;
            }
            set
            {
                _activo = value;
                OnPropertyChanged(nameof(Activo));
            
            }
        }
        public string Buscar
        {
            get
            {
                return _buscar;
            }
            set
            {
                _buscar = value;
                OnPropertyChanged(nameof(Buscar));
            }
        }
        public bool IsVisibleGuardar
        {
            get
            {
                return _isVisibleGuardar;
            }
            set
            {
                _isVisibleGuardar = value;
                OnPropertyChanged(nameof(IsVisibleGuardar));
            }
        }
        public bool IsVisibleEditar
        {
            get
            {
                return _isVisibleEditar;
            }
            set
            {
                _isVisibleEditar = value;
                OnPropertyChanged(nameof(IsVisibleEditar));
            }
        }
        public bool IsVisibleEliminar
        {
            get
            {
                return _isVisibleEliminar;
            }
            set
            {
                _isVisibleEliminar = value;
                OnPropertyChanged(nameof(IsVisibleEliminar));
            }
        }

        public List<EquipoModel> EquipoList
        {
            get { return _equipoList; }
            set
            {
                _equipoList = value;
                OnPropertyChanged("EquipoList");
            }
        }
        public EstadoModel[] Estados { get; } = new[]
        {
            new EstadoModel { Nombre = "STOCK" },
            new EstadoModel { Nombre = "OCUPADO" }
        };
        public EstadoModel SelectedEstado
        {
            get { return _selectedEstado; }
            set
            {
                _selectedEstado = value;
                OnPropertyChanged(nameof(SelectedEstado));
                Estado = value.Nombre;
            }
        }

        public ICommand PruebaCommand { get; }
        public ICommand Prueba2Command { get; }
        public ICommand AgregarEquipoCommand { get; }
        public ICommand ModificarEquipoCommand { get; }
        public ICommand EliminarEquipoCommand { get; }
        public ICommand BuscarEquipoCommand { get; }

        public HomeViewModel()
        {
            equipoRepository = new EquipoRepository();

            PruebaCommand = new CommandViewModel(ExecutePruebaCommand);
            Prueba2Command = new CommandViewModel(ExecutePrueba2Command);
            AgregarEquipoCommand = new CommandViewModel(ExecuteAgregarEquipoCommand, CanExecuteAgregarEquipoCommand);
            ModificarEquipoCommand = new CommandViewModel(ExecuteModificarEquipoCommand, CanExecuteModifcarCommand);
            EliminarEquipoCommand = new CommandViewModel(ExecuteEliminarEquipoCommand);
            BuscarEquipoCommand = new CommandViewModel(ExecuteBuscarEquipoCommand);
            LoadData();
        }

        private void ExecuteBuscarEquipoCommand(object obj)
        {
            if (string.IsNullOrWhiteSpace(Buscar))
            {
                LoadData();
            }
            else
            {
                var parametros = new EquipoModel();
                parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
                parametros.PK_TBL_INVE_EQUIPO = 0;
                parametros.ID_SISTEMA = "";
                parametros.TIPO_EQUIPO = "";
                parametros.MARCA = "";
                parametros.SERIE = "";
                parametros.MODELO = "";
                parametros.ESTADO = "";
                parametros.DETALLES = "";
                parametros.ACTIVO = "";
                parametros.DATOS = Buscar;

                try
                {
                    EquipoList = null;
                    EquipoList = equipoRepository.GetByDatos(parametros);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los equipos: " + ex.Message);
                }
            }
        }

        private void ExecutePrueba2Command(object obj)
        {
            var cell = obj as DataGridCell;
            var dat = cell.DataContext as EquipoModel;
            if (cell != null)
            {
                Id = dat.PK_TBL_INVE_EQUIPO;
                IdSistema = dat.ID_SISTEMA;
                TipoEquipo = dat.TIPO_EQUIPO;
                Marca = dat.MARCA;
                Serie = dat.SERIE;
                Modelo = dat.MODELO;
                Detalles = dat.DETALLES;
                Activo = dat.ACTIVO;
                IsVisibleGuardar = false;
                IsVisibleEditar = false;
                IsVisibleEliminar = true;
            }
        }

        public void LoadData()
        {
            var parametros = new EquipoModel();
            parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
            parametros.PK_TBL_INVE_EQUIPO = 0;
            parametros.ID_SISTEMA = "";
            parametros.TIPO_EQUIPO = "";
            parametros.MARCA = "";
            parametros.SERIE = "";
            parametros.MODELO = "";
            parametros.ESTADO = "";
            parametros.DETALLES = "";
            parametros.ACTIVO = "";
            parametros.DATOS = "";

            try
            {
                EquipoList = null;
                EquipoList = equipoRepository.GetByAll(parametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los equipos: " + ex.Message);
            }
        }

        private void ExecuteEliminarEquipoCommand(object obj)
        {
            var parametros = new EquipoModel();
            parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
            parametros.PK_TBL_INVE_EQUIPO = Id;
            parametros.ID_SISTEMA = IdSistema;
            parametros.TIPO_EQUIPO = TipoEquipo;
            parametros.MARCA = Marca;
            parametros.SERIE = Serie;
            parametros.MODELO = Modelo;
            parametros.ESTADO = Estado;
            parametros.DETALLES = Detalles;
            parametros.ACTIVO = Activo;

            var eliminado = equipoRepository.Remove(parametros);
            if (eliminado)
            {
                LoadData();
                MessageBox.Show("El equipo ha sido eliminado con exito");
                Limpiar();
            }
            else
            {
                MessageBox.Show("El equipo no se pudo eliminar");
            }
        }

        private bool CanExecuteModifcarCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(IdSistema) || string.IsNullOrWhiteSpace(TipoEquipo) || string.IsNullOrWhiteSpace(Marca) || string.IsNullOrWhiteSpace(Serie) || string.IsNullOrWhiteSpace(Modelo))
            {
                validData = false;
            }
            else
            {
                validData = true;
            }
            return validData;
        }

        private void ExecuteModificarEquipoCommand(object obj)
        {
            var parametros = new EquipoModel();
            parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
            parametros.PK_TBL_INVE_EQUIPO = Id;
            parametros.ID_SISTEMA = IdSistema;
            parametros.TIPO_EQUIPO = TipoEquipo;
            parametros.MARCA = Marca;
            parametros.SERIE = Serie;
            parametros.MODELO = Modelo;
            parametros.ESTADO = Estado;
            parametros.DETALLES = Detalles;
            parametros.ACTIVO = Activo;

            var modificado = equipoRepository.Edit(parametros);
            if (modificado)
            {
                LoadData();
                MessageBox.Show("El equipo ha sido modificado con exito");
                Limpiar();
            }
            else
            {
                MessageBox.Show("El equipo no se pudo modificar");
            }
        }

        private bool CanExecuteAgregarEquipoCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(IdSistema) || string.IsNullOrWhiteSpace(TipoEquipo) || string.IsNullOrWhiteSpace(Marca) || string.IsNullOrWhiteSpace(Serie) || string.IsNullOrWhiteSpace(Modelo))
            {
                validData = false;
            }
            else
            {
                validData = true;
            }
            return validData;
        }

        private void ExecuteAgregarEquipoCommand(object obj)
        {
            var parametros = new EquipoModel();
            parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
            parametros.PK_TBL_INVE_EQUIPO = Id;
            parametros.ID_SISTEMA = IdSistema;
            parametros.TIPO_EQUIPO = TipoEquipo;
            parametros.MARCA = Marca;
            parametros.SERIE = Serie;
            parametros.MODELO = Modelo;
            parametros.ESTADO = Estado;
            parametros.DETALLES = Detalles;
            parametros.ACTIVO = Activo;

            var agregado = equipoRepository.Add(parametros);
            if (agregado)
            {
                LoadData();
                MessageBox.Show("El equipo ha sido agregado con exito");
                Limpiar();
            }
            else
            {
                MessageBox.Show("El equipo no se pudo agregar");
            }
        }

        private void ExecutePruebaCommand(object obj)
        {
            var cell = obj as DataGridCell;
            var dat = cell.DataContext as EquipoModel;
            if (cell != null)
            {
                Id = dat.PK_TBL_INVE_EQUIPO;
                IdSistema = dat.ID_SISTEMA;
                TipoEquipo = dat.TIPO_EQUIPO;
                Marca = dat.MARCA;
                Serie = dat.SERIE;
                Modelo = dat.MODELO;
                Detalles = dat.DETALLES;
                Activo = dat.ACTIVO;
                IsVisibleGuardar = false;
                IsVisibleEliminar = false;
                IsVisibleEditar = true;
            }

        }

        private void Limpiar()
        {
            Id = 0;
            IdSistema = "";
            TipoEquipo = "";
            Marca = "";
            Serie = "";
            Modelo = "";
            Detalles = "";
            Activo = "";
            IsVisibleGuardar = true;
            IsVisibleEditar = false;
            IsVisibleEliminar = false;
        }
        public class EstadoModel
        {
            public string Nombre { get; set; }
        }
    }
}
