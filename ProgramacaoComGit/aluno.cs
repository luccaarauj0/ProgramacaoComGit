using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoComGit
{
    internal class aluno
    {
        //atributos
        public string nome;
        public int anoNascimento;

        //metodos
        public int calcularIdade()
        {
            return 2026 - this.anoNascimento;
        }

    }
}
