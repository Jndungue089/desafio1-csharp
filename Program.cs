using System.Text;
using desafio1.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = [];

Pessoa p1 = new(nome:"Hóspede 1");
Pessoa p2 = new(nome:"Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite= new(tipoSuite:"Premium", capacidade: 3, valorDiaria: 30);

Reserva reserva= new(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria().ToString("C2")}");