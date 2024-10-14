using Newtonsoft.Json;

namespace desafio1.Models;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }
    
    // Construtor de reserva
    public Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
    {
        Hospedes = hospedes;
        Suite = suite;
        DiasReservados = diasReservados;
    }

    // Construtor alternativo de reserva, para o caso de apenas ter o número de dias reservados
    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    //Cadastra os hóspedes e lança uma excepção caso o número de hóspedes exceda a capacidade da suite
    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (Suite.Capacidade >= hospedes.Count)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new Exception("O número de hóspedes é maior em relação à capacidade da suite.");
        }
    }

    // Cadastro da suite
    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    // Retorna a quantidade de hóspedes
    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    // Calcula o valor pago diariamente e caso sejam mais de 10 dias reservados
    // Obtém desconto de 10%
    public decimal CalcularValorDiaria()
    {
        if (DiasReservados >= 10)
        {
            return (DiasReservados * Suite.ValorDiaria) - ((DiasReservados * Suite.ValorDiaria) * 0.1M);
        }
        else
        {
            return DiasReservados * Suite.ValorDiaria;
        }
    }
}
