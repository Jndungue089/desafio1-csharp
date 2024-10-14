namespace desafio1.Models;

public class Pessoa
{
    public string Nome { get; set;}
    public string Sobrenome { get; set;}

    // Cosntrutor de pessoa
    public Pessoa(int id, string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    // Cosntrutor alternativo de pessoa para o caso de apenas receber o nome
    public Pessoa(string nome)
    {
        Nome = nome;
    }

}
