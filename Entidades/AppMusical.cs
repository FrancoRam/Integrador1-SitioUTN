using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb) : base(nombre, sistemaOperativo, tamanioMb)
        {
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb, List<string> listaCanciones) : this(nombre, sistemaOperativo, tamanioMb)
        {
            this.listaCanciones = listaCanciones;
        }

        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ObtenerInformacionApp());
            sb.AppendLine("canciones: ");
            if (listaCanciones != null)
            {
                foreach (var cancion in listaCanciones)
                {
                    sb.AppendLine(cancion);
                }
            }

            return sb.ToString();
        }

        protected override int Tamanio
        {
            get
            {
                return (listaCanciones.Count() * 2) + tamanioMb;

            }
        }
    }
}
