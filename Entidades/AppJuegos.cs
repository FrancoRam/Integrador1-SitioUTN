namespace Entidades
{
    public class AppJuegos:Aplicacion
    {
        public AppJuegos(string nombre, SistemaOperativo sistemaOperativo, int tamanio):base(nombre, sistemaOperativo, tamanio)
        {

        }
        protected override int Tamanio //PREGUNTAR A LAUTI POR ESTO. <-------------------------------
        {
            get { return tamanioMb; }
        }
    }
}