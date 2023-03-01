using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamento.Model;

namespace Estacionamento.Services
{
    internal class CarroServices
    {
        static List<Carro> Carros = new List<Carro>();
        public void CadastrarCarro()
        {
            Carro carro = new Carro();
            Console.Clear();
            Console.WriteLine("Digite as Informações conforme Pedido!");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("Placa: ");
            carro.Placa = Console.ReadLine();
            Console.Clear();
            Console.Write("Modelo: ");
            carro.Modelo = Console.ReadLine();
            Console.Clear();
            Console.Write("Cor: ");
            carro.Cor = Console.ReadLine();
            Console.Clear();
            Console.Write("Marca: ");
            carro.Marca = Console.ReadLine();
            Carros.Add(carro);
        }
        public Carro ObterCarro(string placa)
        {
            foreach (var carro in Carros)
            {
                if (placa == carro.Placa)
                {
                    return carro;
                }
            }
            return null;
        }
    }
}
