using Exemplo_de_herança.Entities;
using System;

namespace Exemplo_de_herança
{
    class Program
    {
        static void Main(string[] args)
        {
            BussinesAccount c1 = new BussinesAccount(0001,"Caique Pereira Alve",10.000,20.000);
            // UPCASTING 

            Account c2 = c1;

            //other ex

            Account c4 = new BussinesAccount(0002, "Carlos Eduardo Pereira Alves", 50.000, 100.00);

            Account C5 = new SavingsAccount(0003, "Paulo Henrique Pereira Alves", 100.000, 0.01);
            BussinesAccount c7 = new BussinesAccount(10,"Ivani Pereira Alves",1000.00,0.02);


            //Downcasting

            // BussinesAccount c6 = c4; 
            // o copilador não pode converte explicitamente um Account para BussinesAcount
            // o compilador não sabe que iremos ter um OBJETO BussinesAcount
            // precisamos fazer um "casting" porem um casting de classe que se chama DownCasting
            // Que  ficaria ingual ao exemplo abaixo \/

            BussinesAccount c6 = (BussinesAccount)c4;
            
            c6.Loan(45.00);// demonstração que o Objeto está acessando os meótods da class BussinesAccount
            
            c4.Loan(1.00); // o Objeto não acessa o método por que ela é um tipo Account, mesmo instânciado como BussinesAccount
           
            c7.Loan(1.00); // o Objeto ja é um tipo BussinesAcount 
           
        }
    }
}
