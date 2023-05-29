using InvenTrack.Model;
using InvenTrack.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Input;
using MessageBox = System.Windows.Forms.MessageBox;

namespace InvenTrack.ViewModel
{
    public class BoletaViewModel : BaseViewModel
    {
        private int _id;
        private string _ubicacion;
        private string _departamento;
        private string _asignado;
        private string _fecha;
        private string _entregadoPor;
        private string _recibidoPor;
        private string _detalles;
        private string _buscar;
        private DateTime _fechaSeleccionada;
        private bool _isVisibleCrear = true;
        private bool _isVisibleModificar = false;
        private bool _isVisibleEliminar = false;
        private bool _isVisibleCerrar = false;
        private bool _isVisibleBoleta = false;
        private bool _isVisibleEquipos = false;
        private bool _isVisibleAgregar = false;
        private bool _isVisibleDetalleEliminar = true;

        private int _idE;
        private string _idSistemaE;
        private string _tipoEquipoE;
        private string _marcaE;
        private string _serieE;
        private string _modeloE;
        private string _estadoE;
        private string _detallesE;

        private List<BoletaModel> _boletaList;
        private List<DetalleBoletaModel> _equipoList;

        private ObservableCollection<EquipoModel> _equipos;
        private EquipoModel _equipoSeleccionado;

        private IBoletaRepository boletaRepository;
        private IEquipoRepository equipoRepository;
        private IDetalleBoletaRepository detalleBoletaRepository;

        public ObservableCollection<EquipoModel> Equipos
        {
            get
            {
                return _equipos;
            }
            set
            {
                _equipos = value;
                OnPropertyChanged(nameof(Equipos));
            }
        }
        public EquipoModel EquipoSeleccionado
        {
            get
            {
                return _equipoSeleccionado;
            }
            set
            {
                _equipoSeleccionado = value;
                OnPropertyChanged(nameof(EquipoSeleccionado));
                if(value != null)
                {
                    IdE = value.PK_TBL_INVE_EQUIPO;
                    IdSistemaE = value.ID_SISTEMA;
                    TipoEquipoE = value.TIPO_EQUIPO;
                    MarcaE = value.MARCA;
                    SerieE = value.SERIE;
                    ModeloE = value.MODELO;
                    EstadoE = value.ESTADO;
                    DetallesE = value.DETALLES;
                }
            }
        }
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
        public string Ubicacion
        {
            get
            {
                return _ubicacion;
            }
            set
            {
                _ubicacion = value;
                OnPropertyChanged(nameof(Ubicacion));
            }
        }
        public string Departamento
        {
            get
            {
                return _departamento;
            }
            set
            {
                _departamento = value;
                OnPropertyChanged(nameof(Departamento));
            }
        }
        public string Asignado
        {
            get
            {
                return _asignado;
            }
            set
            {
                _asignado = value;
                OnPropertyChanged(nameof(Asignado));
            }
        }
        public string Fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
                OnPropertyChanged(nameof(Fecha));
            }
        }
        public string EntregadoPor
        {
            get
            {
                return _entregadoPor;
            }
            set
            {
                _entregadoPor = value;
                OnPropertyChanged(nameof(EntregadoPor));
            }
        }
        public string RecibidoPor
        {
            get
            {
                return _recibidoPor;
            }
            set
            {
                _recibidoPor = value;
                OnPropertyChanged(nameof(RecibidoPor));
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
        public DateTime FechaSeleccionada
        {
            get
            {
                return _fechaSeleccionada;
            }
            set
            {
                if (_fechaSeleccionada != value)
                {
                    _fechaSeleccionada = value;
                    OnPropertyChanged(nameof(FechaSeleccionada));
                }
            }
        }
        public bool IsVisibleCrear
        {
            get
            {
                return _isVisibleCrear;
            }
            set
            {
                _isVisibleCrear = value;
                OnPropertyChanged(nameof(IsVisibleCrear));
            }
        }
        public bool IsVisibleModificar
        {
            get
            {
                return _isVisibleModificar;
            }
            set
            {
                _isVisibleModificar = value;
                OnPropertyChanged(nameof(IsVisibleModificar));
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
        public bool IsVisibleBoleta
        {
            get
            {
                return _isVisibleBoleta;
            }
            set
            {
                _isVisibleBoleta = value;
                OnPropertyChanged(nameof(IsVisibleBoleta));
            }
        }
        public bool IsVisibleEquipos
        {
            get
            {
                return _isVisibleEquipos;
            }
            set
            {
                _isVisibleEquipos = value;
                OnPropertyChanged(nameof(IsVisibleEquipos));
            }
        }
        public bool IsVisibleAgregar
        {
            get
            {
                return _isVisibleAgregar;
            }
            set
            {
                _isVisibleAgregar = value;
                OnPropertyChanged(nameof(IsVisibleAgregar));
            }
        }
        public bool IsVisibleCerrar
        {
            get
            {
                return _isVisibleCerrar;
            }
            set
            {
                _isVisibleCerrar = value;
                OnPropertyChanged(nameof(IsVisibleCerrar));
            }
        }
        public bool IsVisibleDetalleEliminar
        {
            get
            {
                return _isVisibleDetalleEliminar;
            }
            set
            {
                _isVisibleDetalleEliminar = value;
                OnPropertyChanged(nameof(IsVisibleDetalleEliminar));
            }
        }

        public int IdE
        {
            get
            {
                return _idE;
            }
            set
            {
                _idE = value;
                OnPropertyChanged(nameof(IdE));
            }
        }
        public string IdSistemaE
        {
            get
            {
                return _idSistemaE;
            }
            set
            {
                _idSistemaE = value;
                OnPropertyChanged(nameof(IdSistemaE));
            }
        }
        public string TipoEquipoE
        {
            get
            {
                return _tipoEquipoE;
            }
            set
            {
                _tipoEquipoE = value;
                OnPropertyChanged(nameof(TipoEquipoE));
            }
        }
        public string MarcaE
        {
            get
            {
                return _marcaE;
            }
            set
            {
                _marcaE = value;
                OnPropertyChanged(nameof(MarcaE));
            }
        }
        public string SerieE
        {
            get
            {
                return _serieE;
            }
            set
            {
                _serieE = value;
                OnPropertyChanged(nameof(SerieE));
            }
        }
        public string ModeloE
        {
            get
            {
                return _modeloE;
            }
            set
            {
                _modeloE = value;
                OnPropertyChanged(nameof(ModeloE));
            }
        }
        public string EstadoE
        {
            get
            {
                return _estadoE;
            }
            set
            {
                _estadoE = value;
                OnPropertyChanged(nameof(EstadoE));
            }
        }
        public string DetallesE
        {
            get
            {
                return _detallesE;
            }
            set
            {
                _detallesE = value;
                OnPropertyChanged(nameof(DetallesE));
            }
        }

        public List<BoletaModel> BoletaList
        {
            get { return _boletaList; }
            set
            {
                _boletaList = value;
                OnPropertyChanged("BoletaList");
            }
        }
        public List<DetalleBoletaModel> EquipoList
        {
            get { return _equipoList; }
            set
            {
                _equipoList = value;
                OnPropertyChanged("EquipoList");
            }
        }

        public ICommand PruebaCommand { get; }
        public ICommand Prueba3Command { get; }
        public ICommand CrearBoletaCommand { get; }
        public ICommand CerrarBoletaCommand { get; }
        public ICommand AgregarBoletaCommand { get; }
        public ICommand EliminarBoletaCommand { get; }
        public ICommand ModificarBoletaCommand { get; }
        public ICommand RemoveDetalleCommand { get; }
        public ICommand BuscarBoletaCommand { get; }

        public BoletaViewModel()
        {
            boletaRepository = new BoletaRepository();
            equipoRepository = new EquipoRepository();
            detalleBoletaRepository = new DetalleBoletaRepository();

            PruebaCommand = new CommandViewModel(ExecutePruebaCommand);
            Prueba3Command = new CommandViewModel(ExecutePrueba3Command);
            CrearBoletaCommand = new CommandViewModel(ExecuteCrearBoletaCommand, CanExecuteCrearBoletaCommand);
            CerrarBoletaCommand = new CommandViewModel(ExecuteCerrarBoletaCommand);
            AgregarBoletaCommand = new CommandViewModel(ExecuteAgregarBoletaCommand);
            EliminarBoletaCommand = new CommandViewModel(ExecuteEliminarBoletaCommand);
            ModificarBoletaCommand = new CommandViewModel(ExecuteModificarBoletaCommand);
            RemoveDetalleCommand = new CommandViewModel(ExecuteRemoveDetalleCommand);
            BuscarBoletaCommand = new CommandViewModel(ExecuteBuscarBoletaCommand);
            LoadData();
            CargarEquipos();

            FechaSeleccionada = DateTime.Now;

            Fecha = FechaSeleccionada.ToString();
            
        }

        private void ExecuteBuscarBoletaCommand(object obj)
        {
            if (string.IsNullOrWhiteSpace(Buscar))
            {
                LoadData();
            }
            else
            {
                var parametros = new BoletaModel();
                parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
                parametros.PK_TBL_INVE_BOLETA = 0;
                parametros.UBICACION = "";
                parametros.DEPARTAMENTO = "";
                parametros.ASIGNADO = "";
                parametros.ENTREGADO_POR = "";
                parametros.RECIBIDO_POR = "";
                parametros.DETALLE_MOVIMIENTO = "";
                parametros.DATOS = Buscar;

                try
                {
                    BoletaList = null;
                    BoletaList = boletaRepository.GetByDatos(parametros);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las boletas: " + ex.Message);
                }
            }
        }

        private void ExecuteModificarBoletaCommand(object obj)
        {
            var parametros = new BoletaModel();
            parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
            parametros.PK_TBL_INVE_BOLETA = Id;
            parametros.UBICACION = Ubicacion;
            parametros.DEPARTAMENTO = Departamento;
            parametros.FECHA = FechaSeleccionada;
            parametros.ENTREGADO_POR = EntregadoPor;
            parametros.ASIGNADO = Asignado;
            parametros.RECIBIDO_POR = RecibidoPor;
            parametros.DETALLE_MOVIMIENTO = Detalles;

            var agregado = boletaRepository.Edit(parametros);
            if (agregado)
            {
                LoadData();
                MessageBox.Show("La boleta ha sido modificada con exito");
                Limpiar();
            }
            else
            {
                MessageBox.Show("La boleta no se pudo modificar");
            }

            BoletaModel m = new BoletaModel();
            m = boletaRepository.GetById(parametros);

            Id = m.PK_TBL_INVE_BOLETA;
            Ubicacion = m.UBICACION;
            Departamento = m.DEPARTAMENTO;
            FechaSeleccionada = m.FECHA;
            EntregadoPor = m.ENTREGADO_POR;
            Asignado = m.ASIGNADO;
            RecibidoPor = m.RECIBIDO_POR;
            Detalles = m.DETALLE_MOVIMIENTO;
            Fecha = FechaSeleccionada.ToString();

            var parms = new DetalleBoletaModel();
            parms.USUARIO = Thread.CurrentPrincipal.Identity.Name;
            parms.PK_TBL_INVE_DETALLE_BOLETA = 0;
            parms.FK_TBL_INVE_BOLETA = Id;
            parms.FK_TBL_INVE_EQUIPO = IdE;
            EquipoList = detalleBoletaRepository.GetByAll(parms);

            IsVisibleBoleta = true;
            IsVisibleCrear = false;
            IsVisibleEquipos = true;
            IsVisibleAgregar = true;
            IsVisibleModificar = false;
            IsVisibleEliminar = false;
            IsVisibleCerrar = false;
        }

        private void ExecuteRemoveDetalleCommand(object obj)
        {
            if (!IsVisibleCerrar)
            {
                var cell = obj as DataGridCell;
                var dat = cell.DataContext as DetalleBoletaModel;
                if (cell != null)
                {
                    var parametros = new DetalleBoletaModel();
                    parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
                    parametros.PK_TBL_INVE_DETALLE_BOLETA = dat.PK_TBL_INVE_DETALLE_BOLETA;
                    parametros.FK_TBL_INVE_BOLETA = Id;
                    parametros.FK_TBL_INVE_EQUIPO = IdE;

                    var modificado = detalleBoletaRepository.Remove(parametros);
                    if (modificado)
                    {
                        LoadData();
                        MessageBox.Show("El equipo ha sido eliminado con exito");
                        var parm = new EquipoModel();
                        parm.USUARIO = Thread.CurrentPrincipal.Identity.Name;
                        parm.PK_TBL_INVE_EQUIPO = dat.FK_TBL_INVE_EQUIPO;
                        parm.ID_SISTEMA = dat.ID_SISTEMA;
                        parm.TIPO_EQUIPO = dat.TIPO_EQUIPO;
                        parm.MARCA = dat.MARCA;
                        parm.SERIE = dat.SERIE;
                        parm.MODELO = dat.MODELO;
                        parm.ESTADO = "STOCK";
                        parm.DETALLES = dat.DETALLES;
                        equipoRepository.Edit(parm);
                        CargarEquipos();
                        EquipoList = detalleBoletaRepository.GetByAll(parametros);
                    }
                    else
                    {
                        MessageBox.Show("El equipo no se pudo eliminar");
                    }
                }
            }
        }

        private void ExecuteCerrarBoletaCommand(object obj)
        {
            IsVisibleCerrar = false;
            IsVisibleCrear = true;
            IsVisibleBoleta = false;
            IsVisibleDetalleEliminar = true;
            IsVisibleAgregar = false;
            IsVisibleEquipos = false;
            Limpiar();
        }

        public void CargarEquipos()
        {
            var parametros = new EquipoModel();
            parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
            parametros.PK_TBL_INVE_EQUIPO = 0;
            parametros.ID_SISTEMA = "";
            parametros.TIPO_EQUIPO = "";
            parametros.MARCA = "";
            parametros.SERIE = "";
            parametros.MODELO = "";
            parametros.ESTADO = "STOCK";
            parametros.DETALLES = "";

            try
            {
                List<EquipoModel> equiposObtenidos = equipoRepository.GetByAll(parametros);
                Equipos = new ObservableCollection<EquipoModel>(equiposObtenidos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los equipos: " + ex.Message);
            }
        }   
        
        private void ExecutePrueba3Command(object obj)
        {
            var cell = obj as DataGridCell;
            var dat = cell.DataContext as BoletaModel;
            if (cell != null)
            {
                Id = dat.PK_TBL_INVE_BOLETA;

                var parametros = new BoletaModel();
                parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
                parametros.PK_TBL_INVE_BOLETA = Id;
                parametros.UBICACION = Ubicacion;
                parametros.DEPARTAMENTO = Departamento;
                parametros.FECHA = FechaSeleccionada;
                parametros.ENTREGADO_POR = EntregadoPor;
                parametros.ASIGNADO = Asignado;
                parametros.RECIBIDO_POR = RecibidoPor;
                parametros.DETALLE_MOVIMIENTO = Detalles;

                BoletaModel m = new BoletaModel();
                m = boletaRepository.GetById2(parametros);

                Id = m.PK_TBL_INVE_BOLETA;
                Ubicacion = m.UBICACION;
                Departamento = m.DEPARTAMENTO;
                FechaSeleccionada = m.FECHA;
                EntregadoPor = m.ENTREGADO_POR;
                Asignado = m.ASIGNADO;
                RecibidoPor = m.RECIBIDO_POR;
                Detalles = m.DETALLE_MOVIMIENTO;
                Fecha = FechaSeleccionada.ToString();

                IsVisibleBoleta = true;
                IsVisibleCerrar = true;
                IsVisibleAgregar = false;
                IsVisibleCrear = false;
                IsVisibleEliminar = false;
                IsVisibleModificar = false;
                IsVisibleDetalleEliminar = false;

                var parms = new DetalleBoletaModel();
                parms.USUARIO = Thread.CurrentPrincipal.Identity.Name;
                parms.PK_TBL_INVE_DETALLE_BOLETA = 0;
                parms.FK_TBL_INVE_BOLETA = Id;
                parms.FK_TBL_INVE_EQUIPO = IdE;
                EquipoList = detalleBoletaRepository.GetByAll(parms);
            }
        }

        public void LoadData()
        {
            var parametros = new BoletaModel();
            parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
            parametros.PK_TBL_INVE_BOLETA = 0;
            parametros.UBICACION = "";
            parametros.DEPARTAMENTO = "";
            parametros.ASIGNADO = "";
            parametros.ENTREGADO_POR = "";
            parametros.RECIBIDO_POR = "";
            parametros.DETALLE_MOVIMIENTO = "";
            parametros.DATOS = "";

            try
            {
                BoletaList = null;
                BoletaList = boletaRepository.GetByAll(parametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las boletas: " + ex.Message);
            }
        }

        private void ExecuteEliminarBoletaCommand(object obj)
        {

            var cell = obj as DataGridCell;
            var dat = cell.DataContext as BoletaModel;
            if (cell != null)
            {
                Id = dat.PK_TBL_INVE_BOLETA;
                Ubicacion = dat.UBICACION;
                Departamento = dat.DEPARTAMENTO;
                Asignado = dat.ASIGNADO;
                FechaSeleccionada = dat.FECHA;
                EntregadoPor = dat.ENTREGADO_POR;
                RecibidoPor = dat.RECIBIDO_POR;
                Detalles = dat.DETALLE_MOVIMIENTO;
                Fecha = FechaSeleccionada.ToString();

                var parametros = new BoletaModel();
                parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
                parametros.PK_TBL_INVE_BOLETA = Id;
                parametros.UBICACION = Ubicacion;
                parametros.DEPARTAMENTO = Departamento;
                parametros.FECHA = FechaSeleccionada;
                parametros.ENTREGADO_POR = EntregadoPor;
                parametros.ASIGNADO = Asignado;
                parametros.RECIBIDO_POR = RecibidoPor;
                parametros.DETALLE_MOVIMIENTO = Detalles;

                var eliminado = boletaRepository.Remove(parametros);
                if (eliminado)
                {
                    LoadData();
                    MessageBox.Show("La boleta ha sido eliminado con exito");
                    var parm = new EquipoModel();
                    if (EquipoList != null)
                    {
                        foreach (DetalleBoletaModel deta in EquipoList)
                        {
                            parm.USUARIO = Thread.CurrentPrincipal.Identity.Name;
                            parm.PK_TBL_INVE_EQUIPO = deta.FK_TBL_INVE_EQUIPO;
                            parm.ID_SISTEMA = deta.ID_SISTEMA;
                            parm.TIPO_EQUIPO = deta.TIPO_EQUIPO;
                            parm.MARCA = deta.MARCA;
                            parm.SERIE = deta.SERIE;
                            parm.MODELO = deta.MODELO;
                            parm.ESTADO = "STOCK";
                            parm.DETALLES = deta.DETALLES;
                            equipoRepository.Edit(parm);
                        }
                        CargarEquipos();
                    }
                    Limpiar();
                    IsVisibleBoleta = false;
                    IsVisibleCrear = true;
                    IsVisibleEquipos = false;
                    IsVisibleAgregar = false;
                    IsVisibleModificar = false;
                    IsVisibleEliminar = false;
                    IsVisibleCerrar = false;
                }
                else
                {
                    MessageBox.Show("La boleta no se pudo eliminar");
                }
            }
        }

        private void ExecuteAgregarBoletaCommand(object obj)
        {
            var parametros = new DetalleBoletaModel();
            parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
            parametros.PK_TBL_INVE_DETALLE_BOLETA = 0;
            parametros.FK_TBL_INVE_BOLETA = Id;
            parametros.FK_TBL_INVE_EQUIPO = IdE;

            var modificado = detalleBoletaRepository.Add(parametros);
            if (modificado)
            {
                LoadData();
                MessageBox.Show("El equipo ha sido agregado con exito");
                EquipoList = detalleBoletaRepository.GetByAll(parametros);
                var parm = new EquipoModel();
                parm.USUARIO = Thread.CurrentPrincipal.Identity.Name;
                parm.PK_TBL_INVE_EQUIPO = IdE;
                parm.ID_SISTEMA = IdSistemaE;
                parm.TIPO_EQUIPO = TipoEquipoE;
                parm.MARCA = MarcaE;
                parm.SERIE = SerieE;
                parm.MODELO = ModeloE;
                parm.ESTADO = "OCUPADO";
                parm.DETALLES = DetallesE;
                equipoRepository.Edit(parm);
                CargarEquipos();
            }
            else
            {
                MessageBox.Show("El equipo no se pudo agregar");
            }
        }

        private bool CanExecuteCrearBoletaCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(Departamento) || string.IsNullOrWhiteSpace(EntregadoPor) || string.IsNullOrWhiteSpace(Asignado) || string.IsNullOrWhiteSpace(RecibidoPor))
            {
                validData = false;
            }
            else
            {
                validData = true;
            }
            return validData;
        }

        private void ExecuteCrearBoletaCommand(object obj)
        {
            var parametros = new BoletaModel();
            parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
            parametros.PK_TBL_INVE_BOLETA = Id;
            parametros.UBICACION = Ubicacion;
            parametros.DEPARTAMENTO = Departamento;
            parametros.FECHA = FechaSeleccionada;
            parametros.ENTREGADO_POR = EntregadoPor;
            parametros.ASIGNADO = Asignado;
            parametros.RECIBIDO_POR = RecibidoPor;
            parametros.DETALLE_MOVIMIENTO = Detalles;

            var agregado = boletaRepository.Add(parametros);
            if (agregado)
            {
                LoadData();
                MessageBox.Show("La boleta ha sido creada con exito");
                Limpiar();
            }
            else
            {
                MessageBox.Show("La boleta no se pudo crear");
            }

            BoletaModel m = new BoletaModel();
            m = boletaRepository.GetById(parametros);

            Id = m.PK_TBL_INVE_BOLETA;
            Ubicacion = m.UBICACION;
            Departamento = m.DEPARTAMENTO;
            FechaSeleccionada = m.FECHA;
            EntregadoPor = m.ENTREGADO_POR;
            Asignado = m.ASIGNADO;
            RecibidoPor = m.RECIBIDO_POR;
            Detalles = m.DETALLE_MOVIMIENTO;
            Fecha = FechaSeleccionada.ToString();

            IsVisibleBoleta = true;
            IsVisibleCrear = false;
            IsVisibleEquipos = true;
            IsVisibleAgregar = true;
        }

        private void ExecutePruebaCommand(object obj)
        {
            var cell = obj as DataGridCell;
            var dat = cell.DataContext as BoletaModel;
            if (cell != null)
            {
                Id = dat.PK_TBL_INVE_BOLETA;
                Ubicacion = dat.UBICACION;
                Departamento = dat.DEPARTAMENTO;
                Asignado = dat.ASIGNADO;
                FechaSeleccionada = dat.FECHA;
                EntregadoPor = dat.ENTREGADO_POR;
                RecibidoPor = dat.RECIBIDO_POR;
                Detalles = dat.DETALLE_MOVIMIENTO;
                Fecha = FechaSeleccionada.ToString();
                IsVisibleCrear = false;
                IsVisibleEliminar = false;
                IsVisibleModificar = true;
            }
        }

        private void Limpiar()
        {
            Id = 0;
            Ubicacion = "";
            Departamento = "";
            Asignado = "";
            Fecha = "";
            EntregadoPor = "";
            Detalles = "";
            RecibidoPor = "";
            Buscar = "";
        }
    }
}
