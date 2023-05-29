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
    public class UsuarioViewModel : BaseViewModel
    {
        private int _id;
        private string _usuario;
        private string _contrasena;
        private string _nombre;
        private string _apellido1;
        private string _apellido2;
        private bool _isVisibleGuardar = true;
        private bool _isVisibleEditar = false;
        private bool _isVisibleEliminar = false;

        private List<UserModel> _usuarioList;

        private IUserRepository usuarioRepository;

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
        public string Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
                OnPropertyChanged(nameof(Usuario));
            }
        }
        public string Contrasena
        {
            get
            {
                return _contrasena;
            }
            set
            {
                _contrasena = value;
                OnPropertyChanged(nameof(Contrasena));
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }
        public string Apellido1
        {
            get
            {
                return _apellido1;
            }
            set
            {
                _apellido1 = value;
                OnPropertyChanged(nameof(Apellido1));
            }
        }
        public string Apellido2
        {
            get
            {
                return _apellido2;
            }
            set
            {
                _apellido2 = value;
                OnPropertyChanged(nameof(Apellido2));
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

        public List<UserModel> UsuarioList
        {
            get { return _usuarioList; }
            set
            {
                _usuarioList = value;
                OnPropertyChanged("UsuarioList");
            }
        }

        public ICommand PruebaCommand { get; }
        public ICommand Prueba2Command { get; }
        public ICommand AgregarUsuarioCommand { get; }
        public ICommand ModificarUsuarioCommand { get; }
        public ICommand EliminarUsuarioCommand { get; }

        public UsuarioViewModel()
        {
            usuarioRepository = new UserRepository();

            PruebaCommand = new CommandViewModel(ExecutePruebaCommand);
            Prueba2Command = new CommandViewModel(ExecutePrueba2Command);
            AgregarUsuarioCommand = new CommandViewModel(ExecuteAgregarEquipoCommand, CanExecuteAgregarEquipoCommand);
            ModificarUsuarioCommand = new CommandViewModel(ExecuteModificarEquipoCommand, CanExecuteModifcarCommand);
            EliminarUsuarioCommand = new CommandViewModel(ExecuteEliminarEquipoCommand);
            LoadData();
        }

        private void ExecutePrueba2Command(object obj)
        {
            var cell = obj as DataGridCell;
            var dat = cell.DataContext as UserModel;
            if (cell != null)
            {
                Id = dat.PK_TBL_INVE_USUARIO;
                Usuario = dat.USUARIO;
                Contrasena = dat.CONTRASENA;
                Nombre = dat.NOMBRE;
                Apellido1 = dat.APELLIDO1;
                Apellido2 = dat.APELLIDO2;
                IsVisibleGuardar = false;
                IsVisibleEditar = false;
                IsVisibleEliminar = true;
            }
        }

        public void LoadData()
        {
            var parametros = new UserModel();
            parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
            parametros.PK_TBL_INVE_USUARIO = 0;
            parametros.USUARIO = "";
            parametros.NOMBRE = "";
            parametros.APELLIDO1 = "";
            parametros.APELLIDO2 = "";
            parametros.CONTRASENA = "";

            try
            {
                UsuarioList = null;
                UsuarioList = usuarioRepository.GetByAll(parametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los equipos: " + ex.Message);
            }
        }

        private void ExecuteEliminarEquipoCommand(object obj)
        {
            var parametros = new UserModel();
            parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
            parametros.PK_TBL_INVE_USUARIO = Id;
            parametros.USUARIO = Usuario;
            parametros.NOMBRE = Nombre;
            parametros.APELLIDO1 = Apellido1;
            parametros.APELLIDO2 = Apellido2;
            parametros.CONTRASENA = Contrasena;

            var eliminado = usuarioRepository.Remove(parametros);
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
            if (string.IsNullOrWhiteSpace(Usuario) || string.IsNullOrWhiteSpace(Contrasena) || string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Apellido1))
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
            var parametros = new UserModel();
            parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
            parametros.PK_TBL_INVE_USUARIO = Id;
            parametros.USUARIO = Usuario;
            parametros.NOMBRE = Nombre;
            parametros.APELLIDO1 = Apellido1;
            parametros.APELLIDO2 = Apellido2;
            parametros.CONTRASENA = Contrasena;

            var modificado = usuarioRepository.Edit(parametros);
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
            if (string.IsNullOrWhiteSpace(Usuario) || string.IsNullOrWhiteSpace(Contrasena) || string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Apellido1))
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
            var parametros = new UserModel();
            parametros.USUARIO = Thread.CurrentPrincipal.Identity.Name;
            parametros.PK_TBL_INVE_USUARIO = Id;
            parametros.USUARIO = Usuario;
            parametros.NOMBRE = Nombre;
            parametros.APELLIDO1 = Apellido1;
            parametros.APELLIDO2 = Apellido2;
            parametros.CONTRASENA = Contrasena;

            var agregado = usuarioRepository.Add(parametros);
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
            var dat = cell.DataContext as UserModel;
            if (cell != null)
            {
                Id = dat.PK_TBL_INVE_USUARIO;
                Usuario = dat.USUARIO;
                Contrasena = dat.CONTRASENA;
                Nombre = dat.NOMBRE;
                Apellido1 = dat.APELLIDO1;
                Apellido2 = dat.APELLIDO2;
                IsVisibleGuardar = false;
                IsVisibleEditar = true;
                IsVisibleEliminar = false;
            }

        }

        private void Limpiar()
        {
            Id = 0;
            Usuario = "";
            Contrasena = "";
            Nombre = "";
            Apellido1 = "";
            Apellido2 = "";
            IsVisibleGuardar = true;
            IsVisibleEditar = false;
            IsVisibleEliminar = false;
        }
    }
}
