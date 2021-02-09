using System;
using System.Collections.Generic;
using System.Text;
using Indice.ViewModels;

namespace Indice.Infrastructure
{
    public class InstanceLocator
    {
        #region Propiedades
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructores
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }

}
