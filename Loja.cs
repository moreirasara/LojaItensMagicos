using System;
using System.Collections.Generic;

namespace loja
{
public class Loja
{
  public Dictionary<string, Item> Estoque; 
  public Loja()
  {
    Estoque = new Dictionary<string, Item>();

    Item espadaFogo = new Item("Espada de fogo" , "Espada", 250,"Essa espada é feita de fogo comum"); 
    this.Estoque.Add("Espada de fogo", espadaFogo);

    

    Item katanaMuramasa = new Item("Muramasa" , "Katana.", 2000, "Qualquer ferida causada pela mesma tem seu poder de regeneração completamente nulo sendo assim uma ferida dessa katana permanente."); 
    this.Estoque.Add("Muramasa", katanaMuramasa);

    

    Item sobretudoWyvern  = new Item("Lembrete do Wyvern" , "Armadura.", 500, "Um sobretudo negro aparentemente normal a primeira vista, mas consegue se transformar e dar asas ao seu possuidor."); 
    this.Estoque.Add("Lembrete do Wyvern", sobretudoWyvern);
    
    

    Item escudoNemeia  = new Item("Escudo de Nemeia" , "Escudo.", 340, "O escudo do leão é capaz de refletir parte do dano contra seu atacante."); 
    this.Estoque.Add("Escudo de Nemeia", escudoNemeia);

    


    Item adagaViajante  = new Item("Adaga do Viajante" , "Adaga.", 100, "Uma adaga capaz de abrir portais em lugares oportunos para que seu possuidor possa atacar seus oponentes."); 
    this.Estoque.Add("Adaga do Viajante", adagaViajante);

    

    Item anelInvocacao  = new Item("Anel de Invocação Esqueleto" , "Joias.", 100, "O anel faz o possuidor ser capaz de invocar Esqueletos sobre seu comando."); 
    this.Estoque.Add("Anel de Invocação Esqueleto.", anelInvocacao);

    


    Item capaInvisibilidade  = new Item("Capa da invisibilidade" , "Armadura.", 900, "O possuidor da capa consegue deixar tudo em baixo dela invisível inclusive a si mesmo."); 
    this.Estoque.Add("Capa da invisibilidade ", capaInvisibilidade);

    


    Item coracaoSuccubus  = new Item("Coração da Succubus" , "Joias.", 4000, "Um amuleto que lhe concede bônus em tentativas de sedução."); 
    this.Estoque.Add("Coração da Succubus", coracaoSuccubus);
    

    


    Item pedraFilosofal  = new Item("Pedra Filosofal", "Joias.", 10000, "O maior amplificador de magia conhecido, consegue transformar um mago aprendiz em um intermediário apenas utilizando ele como catalizador."); 
    this.Estoque.Add("Pedra Filosofal", pedraFilosofal);


    
    


  }
  public void VerEstoque()
  {
    foreach(KeyValuePair<string, Item> item in this.Estoque)
    {
      item.Value.Imprimir();
    }
  }
}
}