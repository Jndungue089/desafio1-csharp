using System.Text;
using desafio1.Models;

// Encode UTF-8 para permitir acentos e caracteres especiais no terminal
Console.OutputEncoding = Encoding.UTF8;

// Uma instância de uma lista de hóspedes
List<Pessoa> hospedes = [];

// Instanciando pessoa por pessoa
Pessoa p1 = new(nome:"Hóspede 1");
Pessoa p2 = new(nome:"Hóspede 2");

// Adicionando cada pessoa como hóspede
hospedes.Add(p1);
hospedes.Add(p2);

// Instanciando uma suite
Suite suite= new(tipoSuite:"Premium", capacidade: 3, valorDiaria: 30);

// Instanciando uma reserva
Reserva reserva= new(diasReservados: 10);
// Cadastro da suíte e dos hóspedes
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

//Após toda a lógica, mostra a quantidade de hóspedes e o valor diário que devem pagar
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria().ToString("C2")}");