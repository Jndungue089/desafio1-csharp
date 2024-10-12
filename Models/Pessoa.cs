namespace desafio1.Models;

public class Pessoa
{
    public string Nome { get; set;}
    public string Sobrenome { get; set;}
    public Pessoa(int id, string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

}
