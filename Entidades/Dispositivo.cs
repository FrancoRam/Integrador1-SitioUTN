using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entidades
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            appsInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }
        public static bool InstalarApp(Aplicacion aplicacion)
        {
            if (aplicacion.SistemaOperativo == sistemaOperativo && appsInstaladas + aplicacion)
            {
                appsInstaladas.Add(aplicacion);
                return true;
            }
            return false;
        }

        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sistema operativo: {sistemaOperativo}");
            foreach (Aplicacion app in appsInstaladas)
            {
                sb.AppendLine($"{app.ObtenerInformacionApp()}");
            }
            return sb.ToString();
        }
    }
}
