using System;

class aula03
{
    static void Main()
    {
        int num1, num2, res;
        byte n1 = 10; // 0 a 255
        int num = 10;
        char letra = 'c';
        float valor = 5.3f;
        string nome = "Edson";
        var aux = nome;

        num1 = 10;
        num2 = 2;

        res = num * num2;

        Console.WriteLine("Valor da variável aux : " + aux + "...");
        Console.WriteLine("A multiplicação de num1 : " + num1 + " e num2: " + num2 + " é:  " + res);



    }


}