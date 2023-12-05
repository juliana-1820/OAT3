using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio57
    {
        public void Executarexerciciocinquentaesete()
        {
            //Fazer um programa que leia uma frase e imprima somente as vogais. 


            Console.WriteLine("Exercicio 57 - programa que leia uma frase e imprima somente as vogais. ");
            Console.ReadKey();


            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            Console.WriteLine("As vogais na frase são:");
            foreach (char c in frase)
            {
                if ("aeiouAEIOU".IndexOf(c) >= 0)
                {
                    Console.Write(c);
                }
            }

            Console.ReadKey();
        }
    }
}