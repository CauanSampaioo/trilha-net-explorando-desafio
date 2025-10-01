using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

//Primeira lista
List<Pessoa> hospedes1 = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Caena", sobrenome: "Magalhães");
Pessoa p2 = new Pessoa(nome: "Atalia", sobrenome: "Dourado");
Pessoa p3 = new Pessoa(nome: "Cauan", sobrenome: "Sampaio");

Pessoa[] listaDeHospedes1 = new Pessoa[] { p1, p2, p3 };

foreach (Pessoa p in listaDeHospedes1)
{
    hospedes1.Add(p);
}



//Segunda lista

List<Pessoa> hospedes2 = new List<Pessoa>();

Pessoa pp1 = new Pessoa(nome: "Caena", sobrenome: "Magalhães");
Pessoa pp2 = new Pessoa(nome: "Atalia", sobrenome: "Dourado");

Pessoa[] listaDeHospedes2 = new Pessoa[] { pp1, pp2 };

foreach (Pessoa p in listaDeHospedes2)
{
    hospedes2.Add(p);
}



// Cria a suíte
Suite suite1 = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 50);




// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva1 = new Reserva(diasReservados: 15);
reserva1.CadastrarSuite(suite1);
reserva1.CadastrarHospedes(hospedes1);




// Exibe a quantidade de hóspedes e o valor da diária
reserva1.imprimir(reserva1);




Suite suite2 = new Suite(tipoSuite: "Padrão", capacidade: 2, valorDiaria: 30);

Reserva reserva2 = new Reserva(diasReservados: 4);
reserva2.CadastrarSuite(suite2);
reserva2.CadastrarHospedes(hospedes2);

reserva1.imprimir(reserva2);