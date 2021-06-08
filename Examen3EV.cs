using System.Collections.Generic;
using System;
namespace Examen3EV_NS_shm2021
{/// <summary>
/// <para>Clase estadisticaNotas</para>
/// </summary>
    public class EstadisticaNotas  // esta clase nos calcula las estadísticas de un conjunto de notas shm2021 
    {
        private int suspensos;  // Suspensos
        private int aprobados;  // Aprobados
        private int notables;  // Notables
        private int sobresalientes;  // Sobresalientes

        private double media; // Nota media


        /// <summary>
        /// <para>Constructor de estadisticaNotas</para>
        /// </summary>
        /// <param name="suspensos"></param>
        /// <param name="aprobados"></param>
        /// <param name="notables"></param>
        /// <param name="sobresalientes"></param>
        /// <param name="media"></param>
        public void setNotas(int suspensos, int aprobados, int notables, int sobresalientes, double media)
        {
            try
            {
                this.suspensos = suspensos;
                this.aprobados = aprobados;
                this.notables = notables;
                this.sobresalientes = sobresalientes;
                this.media = media;
            }
            catch(Exception e)
            {

            }

        }

        /// <summary>
        /// <para>Cosntructor vacio para estadisticaNotas, se inicializan las variables a 0</para>
        /// </summary>
        public EstadisticaNotas()
        {
            suspensos = aprobados = notables = sobresalientes = 0;  // inicializamos las variables
            media = 0.0;
        }

        /// <summary>
        /// <para>Constructor a partir de un array, calcula las estadísticas al crear el objeto</para>
        /// </summary>
        /// <param name="listaNotas"></param>
        public EstadisticaNotas(List<int> listaNotas)
        {
            media = 0.0;

            for (int i = 0; i < listaNotas.Count; i++)
            {
                if (listaNotas[i] < 5) suspensos++;              // Por debajo de 5 suspenso
                else if (listaNotas[i] > 5 && listaNotas[i] < 7) aprobados++;// Nota para aprobar: 5
                else if (listaNotas[i] > 7 && listaNotas[i] < 9) notables++;// Nota para notable: 7
                else if (listaNotas[i] > 9) sobresalientes++;         // Nota para sobresaliente: 9

                media = media + listaNotas[i];
            }

            media = media / listaNotas.Count;

            setNotas(suspensos, aprobados, notables, sobresalientes, media);
        }



        /// <summary>
        /// <para>Para un conjunto de listnot, calculamos las estadísticas</para>
        /// <para>calcula la media y el número de suspensos/aprobados/notables/sobresalientes</para>
        /// </summary>
        /// <param name="listnot"></param>
        /// <returns>Devuelve error si la lista no contiene elementos o si no están comprendidos entre 0 y 10</returns>
        /// <returns>Devuelve la media</returns>
        public double CalcEstadisticas(List<int> listnot)
        {                                 
            media = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            //
            if (listnot.Count <= 0)  // Si la lista no contiene elementos, devolvemos un error
                throw new ArgumentOutOfRangeException();

            for (int i = 0; i < 10; i++)
                if (listnot[i] < 0 || listnot[i] > 10)      // comprobamos que las not están entre 0 y 10 (mínimo y máximo), si no, error
                    throw new Exception("Error, las notas deben comprenderse entre 0 y 10");

            for (int i = 0; i < listnot.Count; i++)
            {
                if (listnot[i] < 5) suspensos++;              // Por debajo de 5 suspenso
                else if (listnot[i] >= 5 && listnot[i] < 7) aprobados++;// Nota para aprobar: 5
                else if (listnot[i] >= 7 && listnot[i] < 9) notables++;// Nota para notable: 7
                else if (listnot[i] > 9) sobresalientes++;         // Nota para sobresaliente: 9

                media = media + listnot[i];
            }

            media = media / listnot.Count;

            return media;

        }


    }
}
