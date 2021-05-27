using System.Collections.Generic;

namespace Examen3EV_NS
{
    public class estNot  // esta clase nos calcula las estadísticas de un conjunto de notas 
    {
        public int sus;  // Suspensos
        public int apr;  // Aprobados
        public int not;  // Notables
        public int sbr;  // Sobresalientes

        public double media; // Nota media

        // Constructor vacío
        public estNot()
        {
            sus = apr = not = sbr = 0;  // inicializamos las variables
            media = 0.0;
        }

        // Constructor a partir de un array, calcula las estadísticas al crear el objeto
        public estNot(List<int> listnot)
        {
            media = 0.0;

            for (int i = 0; i < listnot.Count; i++)
            {
                if (listnot[i] < 5) sus++;              // Por debajo de 5 suspenso
                else if (listnot[i] > 5 && listnot[i] < 7) apr++;// Nota para aprobar: 5
                else if (listnot[i] > 7 && listnot[i] < 9) not++;// Nota para notable: 7
                else if (listnot[i] > 9) sbr++;         // Nota para sobresaliente: 9

                media = media + listnot[i];
            }

            media = media / listnot.Count;
        }


        // Para un conjunto de listnot, calculamos las estadísticas
        // calcula la media y el número de suspensos/aprobados/notables/sobresalientes
        //
        // El método devuelve -1 si ha habido algún problema, la media en caso contrario	
        public double calcEst(List<int> listnot)
        {                                 
            media = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            //
            if (listnot.Count <= 0)  // Si la lista no contiene elementos, devolvemos un error
                return -1;

            for (int i=0;i<10;i++)
                if (listnot[i] < 0 || listnot[i] > 10)      // comprobamos que las not están entre 0 y 10 (mínimo y máximo), si no, error
                return -1;

            for (int i = 0; i < listnot.Count; i++)
            {
                if (listnot[i] < 5) sus++;              // Por debajo de 5 suspenso
                else if (listnot[i] >= 5 && listnot[i] < 7) apr++;// Nota para aprobar: 5
                else if (listnot[i] >= 7 && listnot[i] < 9) not++;// Nota para notable: 7
                else if (listnot[i] > 9) sbr++;         // Nota para sobresaliente: 9

                media = media + listnot[i];
            }

            media = media / listnot.Count;

            return media;
        }
    }
}
