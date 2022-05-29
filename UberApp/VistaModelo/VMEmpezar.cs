using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UberApp.Vistas.Registro;
using Xamarin.Forms;

namespace UberApp.VistaModelo
{
    public class VMEmpezar : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONSTRUCTOR
        public VMEmpezar(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        
        #endregion
        #region PROCESOS
        private async void IrCrearCuenta()
        {
            await Navigation.PushAsync(new CrearCuenta());
        }
        #endregion
        #region COMANDOS
        public ICommand IrCrearCuentaCommand => new Command(IrCrearCuenta);
        
        #endregion
    }
}
