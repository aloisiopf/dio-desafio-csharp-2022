using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  
  static void Main(string[] args) {
    int qtd = 0, tamanho = 0;
    List<string> joias = new List<string>();
    IEnumerable<string> joias_distintas; //https://docs.microsoft.com/pt-br/dotnet/api/system.linq.enumerable.distinct?view=net-6.0
    string joia = "";

    do {
      joia = Console.ReadLine();
      //Faz a verifcação se a string não é nula ou vazia 
      if (!string.IsNullOrEmpty(joia)){
        tamanho += joia.Length; //Soma o tamanho de cada joia
        joias.Add(joia);
      } else {
        break;
      }      
    } while(true);
    joias_distintas = joias.Distinct();

    foreach (string x in joias_distintas){
      qtd++;
    }

    Console.WriteLine(qtd);
  }
}