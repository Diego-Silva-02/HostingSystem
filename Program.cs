using HostingSystem.Models;

// Inicializando o hóspede 1
Pessoa pessoa1 = new Pessoa("Diego", "Silva");
// Inicializando o hóspede 2
Pessoa pessoa2 = new Pessoa("José", "Ramos");

// Inicializando a lista de hospedes
List<Pessoa> hospedes = new List<Pessoa> { pessoa1, pessoa2 }; 

// Inicializando a suíte
Suite suite = new Suite("Premium", 1, 30);

// Inicializando a reserva
Reserva reserva = new Reserva(10);

// Cadastrar os hóspedes
reserva.CadastrarHospedes(hospedes);

// Cadastrar a suíte
reserva.CadastrarSuite(suite);

// Retornando as informações em tela
System.Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
System.Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");