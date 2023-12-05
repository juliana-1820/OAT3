using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio62
    {
        public void Executarexerciciosessentaedois()
        {
            //Escreva um programa que calcule e retorne o valor da hipotenusa através do método
            //HIPOTENUSA. O método recebe o valor da base e da altura de um triângulo. 
            //Fórmulas: hipotenusa2 = base2 + altura2. área = base x altura / 2



            Console.WriteLine("Exercicio 62 - programa que calcule a hipotenusa. ");
            Console.ReadKey();


            Console.Write("Digite o valor da base: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            double hipotenusa = Hipotenusa(baseTriangulo, alturaTriangulo);
            Console.WriteLine("O valor da hipotenusa é: " + hipotenusa);
            double area = Area(baseTriangulo, alturaTriangulo);
            Console.WriteLine("E a área do triângulo é: " + area);
            Console.ReadKey();
        }

        public static double Hipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            return Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
        }

        public static double Area(double baseTriangulo, double alturaTriangulo)
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
    }
}