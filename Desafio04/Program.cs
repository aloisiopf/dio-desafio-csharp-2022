using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    class Program
    {
        
        static void Main(string[] args)
        {
          int qtd_divisor = 0, divisor_par=0, esfera=1;
          //Teste 1
          Console.WriteLine("C: ");
            int c = int.Parse(Console.ReadLine());
            //Teste 2
            Console.WriteLine("N: ");
            int n = int.Parse(Console.ReadLine());
            if (2 <= n && n <=1000){
              for (int i = 0; i < c; i++){
                  while(esfera <= n){
                    Console.WriteLine($"Esfera numero - {esfera} ----");
                    qtd_divisor=0;
                    for (int d = 1; d <= esfera; d++) {
                        if (esfera%d==0){
                            qtd_divisor++;
                            Console.Write($"Divisores - {esfera%d}, ");
                        }
                    }//fim do for
                    Console.WriteLine($"Qtd Divisores - {qtd_divisor}");
                    if (qtd_divisor%2==0){
                        divisor_par++;}
                    esfera++;
                 }//fim do while
                 Console.WriteLine(divisor_par);
              }//fim do for quantidade de testes
            }//fim do if validação
        }//fim do Main
    }//fim da classe
}//fim do namespace