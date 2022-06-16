using System;
using System.Collections.Generic;
using System.Text;

namespace UberApp.Modelo
{
    public class GoogleUser
    {
        public string Name { get; set; }
        public string Apellido { get; set; }

        public string Email { get; set; }

        public Uri Picture { get; set; }
    }

    public interface IGoogleManager
    {
        void Logout();
        void Login(Action<GoogleUser,string> OnLogiComplete);

    }
}
