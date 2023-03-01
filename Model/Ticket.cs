using Estacionamento.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Model
{
    public class Ticket
    {
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public bool Ativo { get; set; }

        

        public Ticket(DateTime Entrada, bool Ativo)
        {
            this.Ativo = Ativo;
            this.Entrada = Entrada;
        }

        public double CalcularTempo()
        {
            var tempo = Saida - Entrada;
            Console.WriteLine($"Veículo ficou por {tempo.TotalMinutes} minutos");
            return tempo.TotalMinutes;
        }

        public double CalcularValor()
        {
            return CalcularTempo() * 0.09;

        }
        public void FecharTicket()
        {
            Saida = DateTime.Now;
            Ativo = false;
            Console.WriteLine($"o veiculo ficou {CalcularTempo()} Minutos e O valor cobrado será de R$ {CalcularValor()}");
        }




    }
}
