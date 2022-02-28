using System;

class DIO {

  static void Main(string[] args) {

    double pi, raio, volume;
    pi = 3.14159;

   //escreva o seu código
   
   //Exibição de uma mensagem na tela - Solicitar Raio
  // Console.WriteLine("Digite o valor do Raio");
   
   //A variável raio recebe a conversão string -> double
   raio = double.Parse(Console.ReadLine());
   
   //A variável volume recebe o resultado da fórmula
   volume = (4.0/3) * pi * Math.Pow(raio , 3);
   
   //A expressão {0:0.000} é usada para formatar a saída. O valor terá 3 casas após a virgula
   Console.WriteLine("VOLUME = {0:0.000}", volume);

  }

}