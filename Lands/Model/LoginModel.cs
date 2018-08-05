using System;
using System.Windows.Input;

namespace Lands.Model
{
    public class LoginModel
    {


        #region Properties
        public string Email
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public bool IsRunning
        {
            get;
            set;
        }
        public bool IsRemember
        {
            get;
            set;
        }

        #endregion

        #region commands
        public ICommand LoginCommand
        {
            get;
            set;
        }
        public ICommand RegisterCommand
        {
            get;
            set;
        }

        #endregion

        #region Constructor
        public LoginModel()
        {
            this.IsRemember = true; 
        }
        #endregion 
    }
}
