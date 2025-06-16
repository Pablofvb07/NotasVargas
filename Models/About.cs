using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasVargas.Models
{
    internal class About
    {

        public string Name { get; set; } = "Pablo Vargas";

        public string Description { get; set; } = "Estudiante de Ing.En Software de la UDLA";

  
        public string Icon { get; set; } = "icono_usuario.jpg";

        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms/maui";
        public string Message => "This app is written in XAML and C# with .NET MAUI.";
    }
}
