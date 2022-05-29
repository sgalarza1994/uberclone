using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberApp.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UberApp.Vistas.Registro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Empezar : ContentPage
    {
        public Empezar()
        {
            InitializeComponent();
            BindingContext = new VMEmpezar(Navigation);
        }
    }
}