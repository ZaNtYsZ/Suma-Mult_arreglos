using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.models
{
    public class LanzadorDados
    {
        private int[] sumaAcumulada = new int[11]; // Array para contar las sumas (de 2 a 12)

        // Método para simular un lanzamiento de dos dados
        public (int primerDado, int segundoDado, int resultadoSuma) Lanzar()
        {
            Random aleatorio = new Random();
            int primerDado = aleatorio.Next(1, 7); // Lanza el primer dado (1 a 6)
            int segundoDado = aleatorio.Next(1, 7); // Lanza el segundo dado (1 a 6)
            int resultadoSuma = primerDado + segundoDado;    // Calcula la suma

            sumaAcumulada[resultadoSuma - 2]++; // Incrementa el conteo para la suma correspondiente
            return (primerDado, segundoDado, resultadoSuma); // Devuelve los valores de los dados y la suma
        }

        public int[] ObtenerSumaAcumulada()
        {
            return sumaAcumulada;
        }
    }
}
