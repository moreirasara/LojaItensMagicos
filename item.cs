using System;
using System.Collections.Generic;

namespace loja
{
public class Item
{
  public String Nome;
  public String Categoria;
  public Double Preco;
  public String Descricao;
  public Item(string nome, string categoria, double preco, string descricao)
  {  
    this.Nome = nome;
    this.Categoria = categoria;
    this.Preco = preco;
    this.Descricao = descricao;
  }
  public void Imprimir ()
  {
    Console.WriteLine("Nome: {0}", this.Nome);
    Console.WriteLine("Categoria: {0}", this.Categoria);
    Console.WriteLine("Preço: {0}", this.Preco);
    Console.WriteLine("Descrição: {0}", this.Descricao);
  }



}
}

