using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamento.Services;
using static System.Net.Mime.MediaTypeNames;

namespace Estacionamento.Model
{
    public class Menu
    {
        CarroServices _carroService = new();
        ticketService _ticketService = new();
        public void Opcao(int opcao)
        {

            switch (opcao)
            {
                case 1:
                    _carroService.CadastrarCarro();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 2:
                    _ticketService.GerarTicket();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 3:
                    _ticketService.FecharTicket();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 4:
                    _ticketService.Historico();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("Foi bom atender você!");
                    Console.Clear();
                    Thread.Sleep(500);
                    break;
            }
            MostrarMenu();

        }
        public void MostrarMenu()
        {
            int escolha = 0;
            string mensagem;
            if (DateTime.Now.Hour > 6 && DateTime.Now.Hour < 12)
            {
                mensagem = "Bom dia!";
            }

            else if (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 18)
            {
                mensagem = "Boa tarde!";
            }

            else
            {
                mensagem = "Boa tarde!";
            }
            Console.WriteLine($"{mensagem} Seja bem vindo ao sistema do Estacionamento Pare aqui!");
            Console.WriteLine("Qual opção desejada?");
            Console.WriteLine("1 - Cadastrar Carro\r\n2 - Marcar Entrada\r\n3 - Marcar Saída\r\n4 - Consultar histórico\r\n5 - Sair");
            escolha = int.Parse(Console.ReadLine());
            if (escolha > 5 || escolha < 1)
            {
                Console.WriteLine("Opção inválida!");
                Thread.Sleep(1000);
                Console.Clear();
                MostrarMenu();
            }
            else if (escolha == 5)
            {
                Console.WriteLine("Foi bom atender você!");
                Console.Clear();
                Thread.Sleep(500);
                return;
            }
            else
            {
                Opcao(escolha);
            }
        }
    }
}
