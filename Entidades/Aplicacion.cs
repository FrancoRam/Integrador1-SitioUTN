using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

 
        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        public virtual string ObtenerInformacionApp()
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.nombre);
            sb.AppendLine(this.sistemaOperativo.ToString());
            sb.AppendLine(this.tamanioMb.ToString());
           

            return sb.ToString(); 
        }

        public override string ToString()
        {
            return this.nombre;             //referencia el nombre de la app.
        }

        //sobrecarga de operadores
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app); //reveer esto, no seas boludo.
        }
        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(app is not null && listaApp is not null) 
            {
                foreach (var item in listaApp)
                {
                    if (item.nombre == app.nombre)
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }
        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp is not null && listaApp != app)
            {
                return true;
            }
            return false;
        }

        public static implicit operator Aplicacion(List<Aplicacion> listaApp) //Implicit
        {

            int indexMax = 0;
            for (int i = 1; i < listaApp.Count; i++)
            {

                if (listaApp[i].Tamanio > listaApp[indexMax].Tamanio) //hacer este metodo con 'Contains'.
                {
                    indexMax = i;
                }
            }
            return listaApp[indexMax];
        }


        //Propiedades
        protected abstract int Tamanio { get; }  //PREGUNTAR A LAUTI POR ESTO. <-------------------------------
        public SistemaOperativo SistemaOperativo
        {
            get { return sistemaOperativo; }

        }

    }
}
