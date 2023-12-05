using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio59
    {
        public void Executarexerciciocinquentaenove()
        {

            //Escreva um programa que solicite dois caracteres de A a Z ao usuário e imprima o
            //número de caracteres existente entre eles. Assuma que o usuário digite os 2
            //caracteres em ordem alfabética. Caso não o estejam, emitir mensagem de erro. 
            //Exemplo: Digite 2 caracteres: jt O numero de caracteres entre eles é: 9



            Console.WriteLine("Exercicio 59 - programa que solicite dois caracteres de A a Z do usuário e imprima o número de caracteres existente entre eles. ");
            Console.ReadKey();


            Console.Write("Digite o primeiro caractere (de A a Z): ");
            char primeiroCaractere = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Digite o segundo caractere (de A a Z): ");
            char segundoCaractere = char.Parse(Console.ReadLine().ToUpper());

            if (primeiroCaractere < 'A' || primeiroCaractere > 'Z' || segundoCaractere < 'A' || segundoCaractere > 'Z')
            {
                Console.WriteLine("Erro: ambos os caracteres devem estar entre A e Z.");
                return;
            }

            if (primeiroCaractere >= segundoCaractere)
            {
                Console.WriteLine("Erro: o primeiro caractere deve ser alfabeticamente anterior ao segundo caractere.");
                return;
            }

            int numeroCaracteres = segundoCaractere - primeiroCaractere - 1;

            Console.WriteLine($"O número de caracteres entre {primeiroCaractere} e {segundoCaractere} é: {numeroCaracteres}");
            Console.ReadKey();
        }
    }
}