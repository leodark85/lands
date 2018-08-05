using System;
using Lands.Model;
 
namespace Lands.Infraestructure
{
    public class InstanceLocator
    {

        #region Properties
        public MainModel Main
        {
            get;
            set;
        }
        #endregion

        #region constructors
        public InstanceLocator()
        {
            this.Main = new MainModel();
        }
        #endregion



    }
}
