using System;

namespace _03ExercícioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instânciar objeto da classe Aluno
            Aluno a = new Aluno();
            a.nome = "Moises";
            a.nota1 = 4 ;
            a.nota2 = 3 ;
            a.mensagem();
        }
    }
}
