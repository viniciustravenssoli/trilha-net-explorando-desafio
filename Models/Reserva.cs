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
            bool verificar = Suite.Capacidade >= hospedes.Count();

            if (verificar)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Quantidade de hospedes é maior que a capacidade da suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            var valor = DiasReservados * Suite.ValorDiaria;

            bool verificarDiasReservador = DiasReservados >= 10;

            if (verificarDiasReservador)
            {
                valor -= valor * 0.1m;
            }

            return valor;
        }
    }
}