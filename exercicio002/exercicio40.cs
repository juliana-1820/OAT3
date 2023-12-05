﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio40
    {
        public void Executarexercicioquarenta()
        {
            //A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03
            //grupos de indústrias que são altamente poluentes do meio ambiente. O índice
            //de poluição aceitável varia de 0,05 até 0,25. Se o índice sobe para 0,3 as
            //indústrias do 1o grupo são intimadas a suspenderem suas atividades, se o índice
            //crescer para 0,4 as industrias do 1o e 2o grupo são intimadas a suspenderem
            //suas atividades, se o índice atingir 0,5 todos os grupos devem ser notificados
            //a paralisarem suas atividades. Faça um programa que leia o índice de poluição
            //medido e emita a notificação adequada aos diferentes grupos de empresas. O
            //algoritmo só deve parar de rodar quando o usuário responder "S" na seguinte
            //pergunta, "Deseja encerrar o programa?". 


            Console.WriteLine("Exercicio 40 - algoritmo que leia o índice de poluição. ");
            Console.ReadKey();


            double indicePoluicao;
            string resposta = "";

            while (resposta != "S")
            {
                Console.Write("Digite o índice de poluição medido: ");
                indicePoluicao = double.Parse(Console.ReadLine());

                if (indicePoluicao >= 0.05 && indicePoluicao <= 0.25)
                {
                    Console.WriteLine("Índice de poluição aceitável.");
                }
                else if (indicePoluicao >= 0.3 && indicePoluicao < 0.4)
                {
                    Console.WriteLine("As indústrias do 1o grupo devem suspender suas atividades.");
                }
                else if (indicePoluicao >= 0.4 && indicePoluicao < 0.5)
                {
                    Console.WriteLine("As indústrias do 1o e 2o grupo devem suspender suas atividades.");
                }
                else if (indicePoluicao >= 0.5)
                {
                    Console.WriteLine("Todos os grupos devem paralisar suas atividades.");
                }

                Console.Write("Deseja encerrar o programa? (S para sim, qualquer outra tecla para não): ");
                resposta = Console.ReadLine();
            }
        }
    }
}

