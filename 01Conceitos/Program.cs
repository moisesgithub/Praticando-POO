using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intanciar Objeto
            Pessoa obj = new Pessoa();
            obj.nome = "Moises";
            obj.idade = 41;
            obj.mensagem();
        }
    }
}
