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
            // Implementado !!!
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Implementado !!!
                throw new Exception("Ocorreu uma exceção : O número de hóspedes é maior que a capacidade!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado !!!
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado !!!
            decimal valor = Suite.ValorDiaria * DiasReservados;

            // Implementado !!!
            if (DiasReservados >= 10)
            {
                valor -= (valor/10);
            }

            return valor;
        }
    }
}