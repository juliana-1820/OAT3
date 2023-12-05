using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio41
    {
        public void Executarexercicioquarentaeum()
        {
            //Faça um programa que dada a idade de um nadador, classifique-o em uma das
            //seguintes categorias: 
            //Infantil A = 5 a 7 anos
            //Infantil B = 8 a 11 anos
            //Juvenil A = 12 a 13 anos
            //Juvenil B = 14 a 17 anos
            //Adultos = Maiores de 18 anos


            Console.WriteLine("Exercicio 41 - algoritmo que dada a idade de um nadador, classifique-o. ");
            Console.ReadKey();


            Console.Write("Digite a idade do nadador: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("O nadador está na categoria Infantil A.");
            }
            else if (idade >= 8 && idade <= 11)
            {
                Console.WriteLine("O nadador está na categoria Infantil B.");
            }
            else if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine("O nadador está na categoria Juvenil A.");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("O nadador está na categoria Juvenil B.");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("O nadador está na categoria Adultos.");
            }
            else
            {
                Console.WriteLine("O nadador é muito jovem para competir.");
            }
            Console.ReadKey();
        }
    }
}
