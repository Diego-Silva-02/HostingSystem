namespace HostingSystem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite Suite { get; set; } = new Suite();
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= this.Suite.Capacidade)
            {
                this.Hospedes = hospedes;
            } else 
            {
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            this.Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return this.Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorPorDia = this.DiasReservados >= 10 ? (Suite.ValorDiaria / 10) * 9 : Suite.ValorDiaria;

            return valorPorDia * this.DiasReservados;
        }
    }
}