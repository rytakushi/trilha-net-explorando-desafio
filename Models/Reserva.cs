using System.Linq.Expressions;

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
         
            if (hospedes.Count > 0)
            {
                Hospedes = hospedes;
            }
          
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
           
            if (Hospedes.Count <= Suite.Capacidade)
            {
                return (Hospedes.Count);
            }
            else
            {
                throw new  Exception("A quantidade de hospedes não pode exeder a capacidade da suite");
            }
        }

        public decimal CalcularValorDiaria()
        {
          
            decimal valor;
            if (DiasReservados >= 10)
            {
                valor = Suite.ValorDiaria * DiasReservados * 90 / 100;
            }
            else
            {
                valor = Suite.ValorDiaria * DiasReservados;
            }

            return valor;
        }
    }
}