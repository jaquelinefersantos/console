using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 2;
            long longa = 5;
            decimal dinheiro = 10.5m;
            double dinheiros = 10;
            string mensagem1 = "Microsoft Windows [Version 10.0.17134.228]";
            string mensagem2 = "(c) 2018 Microsoft Corporation. All rights reserved.";
            Console.WriteLine(mensagem1);
            Console.WriteLine(mensagem2);
            string mensagemCompleta = mensagem1 +"\n"+ mensagem2;
            Console.WriteLine();
            Console.WriteLine(mensagemCompleta);
            Console.WriteLine();
            mensagemCompleta= "Microsoft Windows[Version 10.0.17134.228]\n(c) 2018 Microsoft Corporation. All rights reserved.\nfim";
            Console.WriteLine(mensagemCompleta);


            Console.ReadKey();

            
           
        }
    }
}
