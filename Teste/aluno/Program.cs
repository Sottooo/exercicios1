using System;

namespace Aluno
{
   public class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 =  new Aluno("Sotto", "474.753.778-30");
            Aluno aluno2 =  new Aluno("Fabolas", "478.919.798-4", "Gay mer");
            System.Console.WriteLine("Nome: " + aluno1.Nome);
            System.Console.WriteLine("Curso: " + aluno1.Curso);
            System.Console.WriteLine("CPF", + aluno1.Cpf);

            System.Console.WriteLine();

            System.Console.WriteLine("Nome: " + aluno2.Nome);
            System.Console.WriteLine("Curso: " + aluno2.Curso);
            System.Console.WriteLine("CPF: " + aluno2.Cpf);
            
            System.Console.WriteLine("Entre com o nome:");
            string nome = Console.ReadLine();
            System.Console.WriteLine("Entre com o CPF:");
            string cpf = Console.ReadLine();
            System.Console.WriteLine("Entre com a nota:");
            int nota = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Entre com o bimestre:");
            int bimeste = int.Parse(Console.ReadLine());
            Aluno aluno3 = new Aluno(nome,cpf,curso);
            
            System.Console.WriteLine("Nome:" + aluno3.nome);
            System.Console.WriteLine("CPF:" + aluno3.cpf);
            System.Console.WriteLine("Cursos" + aluno3.Curso);
            System.Console.WriteLine("Notas");
            foreach(int n in aluno3.getNotas ()){
                System.Console.Write(n + " ");
..
            }
            
            System.Console.WriteLine();
            

        }
    }
}
