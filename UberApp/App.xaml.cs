using System;
using UberApp.Vistas.Menuprincipal;
using UberApp.Vistas.Registro;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UberApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage =  new NavigationPage(new Empezar());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
