using Estacionamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Services
{
    internal class ticketService
    {
        private CarroServices _carroServices = new CarroServices();
        public void Historico()
        {
            Console.Clear();
            Console.WriteLine("Qual a placa?");
            string placa = Console.ReadLine();
            var carro = _carroServices.ObterCarro(placa);

            if (carro == null)
            {
                Console.WriteLine("Carro não cadastrado");
                return;
            }
            Console.WriteLine("Entrada              |Saída                 |Ativo   | Valor ");

            foreach (var ticket in carro.Tickets)
            {
                if (ticket.Ativo == true)
                {
                    Console.WriteLine($"{ticket.Entrada} | -------------------- | {ticket.Ativo.ToString()} | R$--,--");
                }
                else
                {
                    Console.WriteLine($"{ticket.Entrada} | {ticket.Saida} | {ticket.Ativo.ToString()} | R${ticket.CalcularValor()}");
                }
            }
            Thread.Sleep(1000);
        }

        public void GerarTicket()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa:");
            string placa = Console.ReadLine();
            var carro = _carroServices.ObterCarro(placa);

            if (carro == null)
            {
                Console.WriteLine("Carro não cadastrado");
                return;
            }
            foreach (var ticket in carro.Tickets)
            {
                if (ticket.Ativo == true)
                {
                    Console.WriteLine("Veículo já está no estacionamento!");
                    return;
                }
            }
            Ticket ticketNovo = new Ticket(DateTime.Now, true);
            carro.Tickets.Add(ticketNovo);
            Console.WriteLine("Ticket Gerado!");
        }

        public void FecharTicket()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa:");
            string placa = Console.ReadLine();
            var carro = _carroServices.ObterCarro(placa);
            if (carro == null)
            {
                Console.WriteLine("Carro não cadastrado");
                Thread.Sleep(2000);
                return;
            }
            Ticket ticketAberto = null;
            foreach (var ticket in carro.Tickets)
            {
                if (ticket.Ativo == true)
                {
                    ticketAberto = ticket;
                }
                if (ticketAberto == null)
                {
                    Console.WriteLine("Não Há tickets em aberto para o veiculo");
                    Thread.Sleep(2000);
                    return;
                }
                ticketAberto.FecharTicket();
                Console.WriteLine("Continuar (S / N)");
                string resposta = Console.ReadLine();
                while (resposta != "S")
                {
                    Console.WriteLine("Continuar (S / N)");
                    resposta = Console.ReadLine();
                }
            }
        }
    }
}
