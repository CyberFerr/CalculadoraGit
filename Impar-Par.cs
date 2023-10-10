using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
               int numero;

   Console.WriteLine("Insira o Valor para verificação: ");
   numero = Convert.ToInt32(Console.ReadLine());

   if (numero % 2 == 0)
   {
       Console.WriteLine("Número Par");
   }
   else
   {
       Console.WriteLine("Número Impar");
   }
        
            }
    }
}