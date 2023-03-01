using Estacionamento.Model;
using Estacionamento.Services;

CarroServices _carroServices= new CarroServices();

Menu menu = new Menu();
menu.MostrarMenu();




/*
O método CadastrarCarro deve obter os dados do carro via Console.ReadLine(), e inserir o carro cadastrado em uma lista estatica para que fique acessível a partir de qualquer instancia da classe durante o ciclo de vida da aplicação
*/