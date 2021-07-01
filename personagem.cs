using System;
using System.Collections.Generic;

namespace loja
{
  public class Personagem
  {
    public String Nome;
    public Double Dinheiro;
    public List<Item> Inventario;
    public Personagem(string nome, double dinheiro)
    {  
      this.Nome = nome;
      this.Dinheiro = dinheiro;
      this.Inventario = new List<Item>();
    }
    public void VerInventario()
    {
      foreach(Item item in this.Inventario)
      {
        item.Imprimir();
      }
    }
    public void ComprarItem(string nomeItem, Loja loja)
    {
      if(loja.Estoque.ContainsKey(nomeItem))
      {
        if(this.Dinheiro >= loja.Estoque[nomeItem].Preco)
        {
          Console.WriteLine("Se você quiser realmente comprar esta bosta, digite SIM.");
          string a = Console.ReadLine();
          if(a == "SIM")
          {
            this.Inventario.Add(loja.Estoque[nomeItem]);
            this.Dinheiro -= loja.Estoque[nomeItem].Preco;
          }
        } 
      } 
      else
      {
        Console.WriteLine("O item {0} não está em estoque.", nomeItem);
      }
    }
  }
}
