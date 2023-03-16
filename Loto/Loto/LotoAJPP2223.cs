using System;

namespace LotoClassNS
{
    // Clase que almacena una combinación de la lotería
    //
    public class loto
    {
        // definición de constantes
        public const int MAX_NUMEROS = 6;
        public const int NUMERO_MENOR = 1;
        public const int NUMERO_MAYOR = 49;
        
        private int[] _nums = new int[MAX_NUMEROS];   // numeros de la combinación
        private bool combinacionValida = false;      // combinación válida (si es aleatoria, siempre es válida, si no, no tiene porqué)

        /// <summary>
        /// Propiedad del campo _nums
        /// </summary>
        /// <value>Vector de números de la lotería</value>
        public int[] Nums { 
            get => _nums; 
            set => _nums = value; 
        }
        public bool CombinacionValida { get => combinacionValida; set => combinacionValida = value; }

        /// <summary>
        /// Constructor vacío de la clase Loto
        /// </summary>
        /// <remarks>Se genera una combinación aleatoria correcta</remarks>
        public loto()
        {
            Random r = new Random();    // clase generadora de números aleatorios

            int i=0, j, num;

            do             // generamos la combinación
            {                       
                num = r.Next(NUMERO_MENOR, NUMERO_MAYOR + 1);     // generamos un número aleatorio del 1 al 49
                for (j=0; j<i; j++)    // comprobamos que el número no está
                    if (Nums[j]==num)
                        break;
                if (i==j)               // Si i==j, el número no se ha encontrado en la lista, lo añadimos
                {
                    Nums[i]=num;
                    i++;
                }
            } while (i<MAX_NUMEROS);

            CombinacionValida=true;
        }

        /// <summary>
        /// <para>Constructor con parámetros de la clase Loto</para>
        /// <para>Almacena en <see cref="_nums"/> la combinación de la lotería con la que queremos inicializar la clase</para>
        /// </summary>
        /// <param name="misnums">Vector de enteros con la combinación que se quiere crear</param>
        /// <remarks>El parámetro <paramref name="misnums"/> pasado no tiene por qué ser válido</remarks>
        public loto(int[] misnums)  // misnumeros: combinación con la que queremos inicializar la clase
        {
            for (int i=0; i<MAX_NUMEROS; i++)
                if (misnums[i]>=NUMERO_MENOR && misnums[i]<=NUMERO_MAYOR) {
                    int j;
                    for (j=0; j<i; j++) 
                        if (misnums[i]==Nums[j])
                            break;
                    if (i==j)
                        Nums[i]=misnums[i]; // validamos la combinación
                    else {
                        CombinacionValida=false;
                        return;
                    }
                }
                else
                {
                    CombinacionValida=false;     // La combinación no es válida, terminamos
                    return;
                }
	    CombinacionValida=true;
        }

        /// <summary>
        /// Método que comprueba el número de aciertos
        /// </summary>
        /// <param name="premi">Vector de enteros con la combinación ganadora</param>
        /// <returns>Número de aciertos</returns>
        public int comprobar(int[] premi)
        {
            int a=0;                    // número de aciertos
            for (int i=0; i<MAX_NUMEROS; i++)
                for (int j=0; j<MAX_NUMEROS; j++)
                    if (premi[i]==Nums[j]) a++;
            return a;
        }
    }

}
