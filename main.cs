using System;
using System.Collections.Generic;
namespace loja{

  class MainClass {
    public static void Main (string[] args) {
      Console.WriteLine ("Hello World");
      
      Loja itensM = new Loja();
      Personagem pessoa = new Personagem("Robbin", 50000);

      Console.WriteLine("Bem vindo a loja online de Itens Magicos do senhor abobrinha!");  
      Console.WriteLine("Você deseja ver nossos itens? Por favor responda com SIM ou NÃO.");

      string resposta; 
      resposta = Console.ReadLine();

      if(resposta == "SIM")
      {
        Console.WriteLine("Veja nossos itens :");
        itensM.VerEstoque();

        Console.WriteLine("Você deseja levar algum item? Por favor responda com SIM ou NÃO.");
        string resposta2;
        resposta2 = Console.ReadLine();
        if(resposta2 == "SIM")
        {
          string venda2;

          do{
          Console.WriteLine("Diga o nome do item.");
          string venda;
          venda = Console.ReadLine();
          pessoa.ComprarItem(venda, itensM);

          Console.WriteLine("-------- Inventario-----------");
          pessoa.VerInventario();
          Console.WriteLine("-------------------------------");
          Console.WriteLine("Algo mais?Por favor responda com SIM ou NÃO");
          venda2 = Console.ReadLine();
    
          } while (venda2 == "SIM");
        }

      }
    }
  }  
}