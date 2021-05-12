using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploDelegados
{
    class AsistenteDescarga
    {
        //paso 1 crear delegado
        public delegate void GestorEventoArchivoDescargado(object fuente, EventArgs args);

        //Paso 2 crear el evento basado en el delegado
        public event GestorEventoArchivoDescargado ArchivoDescargado;

        //Paso 3 inciar el evento
        protected virtual void EnArchivoDescargado()
        {
            if (ArchivoDescargado != null)
            {
                ArchivoDescargado(this, EventArgs.Empty);
            }
        }

        public void Descarga(Archivo archivo)
        {
            Console.WriteLine("Descargando...");
            Thread.Sleep(4000);

            //Paso 3.1
            EnArchivoDescargado();
        }
    }
}
