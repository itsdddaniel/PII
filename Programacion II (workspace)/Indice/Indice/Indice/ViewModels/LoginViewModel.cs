using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Indice.ViewModels
{
    public class LoginViewModel : MainPage
    {
        #region Propiedades
        public string Nota
        {
            get;
            set;
        }

        public string UV
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get;
            set;
        }
        #endregion

        #region Comandos
        public ICommand CalculandoCommand
        {
            get
            {
                return new RelayCommand(Calculando);
            }

        }
        private async void Calculando()
        {
            if (string.IsNullOrEmpty(this.Nota))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debes ingresar un valor valido", "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.UV))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debes ingresar un valor valido", "Aceptar");
                return;
            }
        }
        #endregion

        #region Constructor
        public LoginViewModel()
        {

        }
        #endregion
    } 
}
