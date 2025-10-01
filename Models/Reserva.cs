namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*

            if (hospedes.Count() <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*  
                throw new InvalidOperationException(
                    $"Capacidade maior que o numero de vagas"
                );
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*

            decimal valorOriginal = DiasReservados * Suite.ValorDiaria;
            decimal valor = valorOriginal;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                decimal valorComDesconto = valorOriginal - (valorOriginal * 0.10m);
                valor = valorComDesconto;
            }

            return valor / DiasReservados;
        }

        public decimal CalcularValorTotal()
        {
            return CalcularValorDiaria() * DiasReservados;
        }

        public string tipo()
        {
            return Suite.TipoSuite;
        }

        public void imprimir(Reserva reserva)
        {
            Console.WriteLine($"Hóspedes: {ObterQuantidadeHospedes()}");
            Console.WriteLine($"Tipo de quarto: {reserva.tipo()}");
            Console.WriteLine($"Dias reservados: {reserva.DiasReservados}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
            Console.WriteLine($"Valor total: {reserva.CalcularValorTotal()}\n");
        }
    }
}