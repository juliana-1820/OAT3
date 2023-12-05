using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio03
    {
        public void Executarexerciciotres()
        {
            //Faça um algoritmo em c# para pagamento de comissão de vendedores de peças, levando-se em
            //consideração que sua comissão será de 5% do total da venda e que você tem os seguintes
            //dados: identificação do vendedor, código da peça, preço unitário da peça e a quantidade
            //vendida.

            int idvendedor, codigopeca, qtde;
            double precouni, total, comissao;

            Console.WriteLine("Exercicio 03 - algoritmo para o pagamento de comissão de 5% de vendedores.");
            Console.ReadKey();

            Console.Write("Digite a identificação do vendedor: ");
            idvendedor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o código da peça: ");
            codigopeca = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço unitário da peça: ");
            precouni = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade vendida: ");
            qtde = int.Parse(Console.ReadLine());

            total = precouni * qtde;

            comissao = 0.05 * total;

            Console.WriteLine("O vendedor: " + idvendedor);
            Console.WriteLine($"Com o total de venda: {total:C}");
            Console.WriteLine($"Receberá a comissão no valor: {comissao:C}");

            Console.ReadKey();


        }
    }
}
