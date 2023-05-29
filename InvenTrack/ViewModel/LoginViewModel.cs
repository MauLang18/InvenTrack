using InvenTrack.Model;
using InvenTrack.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InvenTrack.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        //CAMPOS
        private string _username;
        private SecureString _password;
        private string _errorMessage;
        private bool _isViewVisible = true;

        private IUserRepository userRepository;

        //PROPIEDADES
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public SecureString Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string ErrorMessage 
        { 
            get 
            {
                return _errorMessage; 
            } 
            set 
            { 
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            } 
        }
        public bool IsViewVisible 
        { 
            get 
            { 
                return _isViewVisible; 
            } 
            set 
            { 
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            } 
        }

        //COMANDOS
        public ICommand LoginCommand { get; }
        public ICommand ShowPasswordCommand { get; }

        //CONSTRUCTOR
        public LoginViewModel()
        {
            userRepository = new UserRepository();
            LoginCommand = new CommandViewModel(ExecuteLoginCommand, CanExecuteLoginCommand);
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;
            if(string.IsNullOrWhiteSpace(Username) || Username.Length<3 || Password==null || Password.Length < 3)
            {
                validData = false;
            }
            else
            {
                validData = true;
            }
            return validData;
        }

        private void ExecuteLoginCommand(object obj)
        {
            var parametros = new UserModel();
            parametros.PK_TBL_INVE_USUARIO = 0;
            parametros.USUARIO = Username;
            parametros.CONTRASENA = ConvertSecureStringToString(Password);

            var isValidUser = userRepository.AuthenticateUser(parametros,Password);
            if (isValidUser)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(Username),null);
                Thread.CurrentThread.Name = parametros.CONTRASENA;
                IsViewVisible = false;
            }
            else
            {
                ErrorMessage = "* EL USUARIO O LA CONTRASEÑA SON INVALIDAS";
            }
        }

        private string ConvertSecureStringToString(SecureString secureString)
        {
            IntPtr ptr = IntPtr.Zero;
            try
            {
                ptr = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(ptr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(ptr);
            }
        }
    }
}
