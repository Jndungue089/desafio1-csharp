using Newtonsoft.Json;

namespace desafio1.Models;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
    {
        Hospedes = hospedes;
        Suite = suite;
        DiasReservados = diasReservados;
    }

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }


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

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

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
