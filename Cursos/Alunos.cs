using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos
{
    internal class Alunos : Pessoas
    {
        public string Matricula { get; set; }
        public string Codigo_curso { get; set; }   
        public string Nome_curso { get; set; }
        public Alunos(string nome, string telefone, string cidade, string rg, string matricula, string cpf, string codigo_curso, string nome_curso) 
            : base(nome, telefone, cidade, rg, cpf)
        { 
            Matricula = matricula;
            Codigo_curso = codigo_curso;
            Nome_curso = nome_curso;
        }
        
    }
}
