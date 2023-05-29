using FontAwesome.Sharp;
using InvenTrack.Model;
using InvenTrack.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace InvenTrack.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        //CAMPOS
        private UserAccontModel _currentUserAccount;
        private BaseViewModel _currentChildView;
        private string _caption;
        private IconChar _icon;

        private IUserRepository userRepository;

        //PROPIEDADES
        public UserAccontModel CurrentUserAccount
        {
            get
            {
                return _currentUserAccount;
            }
            set
            {
                _currentUserAccount = value;
                OnPropertyChanged(nameof(CurrentUserAccount));
            }
        }
        public BaseViewModel CurrentChildView
        {
            get
            {
                return _currentChildView;
            }
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }
        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }
        public IconChar Icons
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value;
                OnPropertyChanged(nameof(Icons));
            }
        }

        //COMANDOS
        public ICommand ShowHomeViewCommand { get; }
        public ICommand ShowBoletaViewCommand { get; }
        public ICommand ShowUsuarioViewCommand { get; }

        //CONSTRUCTOR
        public MainViewModel()
        {
            userRepository = new UserRepository();

            //INICIALIZAR COMANDOS
            ShowHomeViewCommand = new CommandViewModel(ExecuteShowHomeViewCommand);
            ShowBoletaViewCommand = new CommandViewModel(ExecuteShowBoletaViewCommand);
            ShowUsuarioViewCommand = new CommandViewModel(ExecuteShowUsuarioViewCommand);

            //VISTA DEFAULT
            ExecuteShowHomeViewCommand(null);

            LoadCurrentUsereData();
        }

        private void ExecuteShowUsuarioViewCommand(object obj)
        {
            CurrentChildView = new UsuarioViewModel();
            Caption = "Usuarios";
            Icons = IconChar.User;
        }

        private void ExecuteShowBoletaViewCommand(object obj)
        {
            CurrentChildView = new BoletaViewModel();
            Caption = "Boleta";
            Icons = IconChar.FileAlt;
        }

        private void ExecuteShowHomeViewCommand(object obj)
        {
            CurrentChildView = new HomeViewModel();
            Caption = "Inventario";
            Icons = IconChar.List;
        }

        private void LoadCurrentUsereData()
        {
            var user = userRepository.GetByUserUserName(Thread.CurrentPrincipal.Identity.Name, Thread.CurrentThread.Name);
            if(user != null)
            {
                CurrentUserAccount = new UserAccontModel()
                {
                    USUARIO = user.USUARIO,
                    DISPLAYNAME = $"{user.NOMBRE} {user.APELLIDO1}"
                };
            }
            else
            {
                MessageBox.Show("USUARIO INVALIDO, NO SE HA LOGUEADO");
                Application.Current.Shutdown();
            }
        }
    }
}
