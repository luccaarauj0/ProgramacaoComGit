using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoComGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            aluno a1 = new aluno();
            a1.nome = "maria";
            a1.anoNascimento = 1993;

            Console.WriteLine("a idade da "+a1.nome+" é: "+a1.calcularIdade());
            Console.ReadKey();
        }
    }
}
