using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio43
    {
        public void Executarexercicioquarentaetres()
        {
            //Uma rainha requisitou os serviços de um monge e disse-lhe que pagaria qualquer
            //preço. O monge, necessitando de alimentos, indagou à rainha sobre o pagamento,
            //se poderia ser feito com grãos de trigo dispostos em um tabuleiro de xadrez, de
            //tal forma que o primeiro quadro deveria conter apenas um grão e os quadros
            //subseqüentes, o dobro do quadro anterior. A rainha achou o trabalho barato e
            //pediu que o serviço fosse executado, sem se dar conta de que seria impossível
            //efetuar o pagamento. Faça um programa para calcular o número de grãos que o
            //monge esperava receber. 


            Console.WriteLine("Exercicio 43 - algoritmo para calcular o número de grãos que o monge esperava receber. ");
            Console.ReadKey();

            double total = 0;
            for (int i = 0; i < 64; i++)
            {
                total += Math.Pow(2, i);
            }
            Console.WriteLine($"O monge esperava receber {total} grãos de trigo.");
            Console.ReadKey();
        }
    }
}