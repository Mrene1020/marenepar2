using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;


namespace marenepar2.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Atributes
        string notas;
        string ingrese_datos;
        bool isenabled;
        #endregion

        #region Properties
        public string Notas
        {
            get
            {
                return this.notas;
            }
            set
            {
                SetValue(ref this.notas, value);
            }
        }
        public string Ingrese_datos
        {
            get
            {
                return this.ingrese_datos;
            }
            set
            {
                SetValue(ref this.ingrese_datos, value);

                #endregion
            }
        }

             public bool IsEnabled
        {
            get
            {
                return this.isenabled;
            }
            set
            {
                SetValue(ref this.isenabled, value);
            }
        }
        #region Commands
        public int ICommand; Login Command
        {
            get
            {
                return new RelayCommand(cmdLogin);
            }
        }
        private async void cmdLogin()
        {
            if(string.IsNullOrEmpty(Notas))
            {
                await App.Current.MainPage.DisplayAlert("Notas empty", "Please input notas", "Accept");
                return;
            }
            if(string.IsNullOrEmpty(Ingrese_datos))
            {
                await App.Current.MainPage.DisplayAlert("Ingrese_datos empty", "Please input ingrese_datos", "Accept");
                return;
            }
        }
        #endregion
    }
}
        

        