// See https://aka.ms/new-console-template for more information
using System;

namespace Aula02

{

    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment
            Console.WriteLine("CFB Cursos - Aprendendo C#");
            if (args.GetLength(0) > 0)
            {
                Console.Write(args.GetValue(0));
            }
            else
            {
                Console.WriteLine("Nenhum argumento foi passado.");
            }
       
        }
        
}


}