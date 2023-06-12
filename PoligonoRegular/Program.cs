using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoligonoRegular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que calcule el perímetro de cualquier polígono regular

            // Variables
            int numeroLados;
            double tamañoLado, perimetro;

            // Pedir al usuario el número de lados
            Console.Write("Por favor ingresa el número de lados: ");
            numeroLados = Convert.ToInt32(Console.ReadLine());

            // Pedir al usuario el tamaño de un lado
            Console.Write("Por favor ingresa el tamaño del lado: ");
            tamañoLado = Convert.ToDouble(Console.ReadLine());

            perimetro = numeroLados * tamañoLado;

            Console.WriteLine("El perímetro es: {0}", perimetro);
        }
    }
}
