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
        }
    }
}
