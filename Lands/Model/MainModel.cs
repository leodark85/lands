using System;
namespace Lands.Model
{
    public class MainModel
    {
        #region ViewModel
        public LoginModel Login
        {
            get;
            set;
        }
        #endregion

        #region constructores
        public MainModel()
        {
            this.Login = new LoginModel();
        }
        #endregion
    }
}
