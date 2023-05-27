using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos
{
    public class Exibir
    {
        private ListBox pessoaList;
        private ListBox alunosList;
        private ListBox formatado;
        private Label numAlunos;
        private Label numPessoas;

        public Exibir(ListBox formatado, Label numAlunos, Label numPessoas, ListBox pessoaList, ListBox alunosList)
        {
            this.pessoaList = pessoaList;
            this.alunosList = alunosList;
            this.formatado = formatado;
            this.numAlunos = numAlunos;
            this.numPessoas = numPessoas;
        }
        //Método que exibe a contagem de alunos e pessoas
        public void ExibirResultados(List<Pessoas> pessoas)
        {
            int totalAlunos = 0;
            int totalPessoas = 0;

            foreach (Pessoas pessoa in pessoas)
            {
                if (pessoa is Alunos)
                {
                    totalAlunos++;
                }
                else
                {
                    totalPessoas++;
                }
            }
            // Mostra em lista organizada as pessoas e os alunos
            foreach (Pessoas pessoa in pessoas)
            {
                if (pessoa is Alunos aluno)
                {
                    formatado.Items.Add($"Y - Aluno: {aluno.Nome} - Matrícula: {aluno.Matricula} - Código do Curso: {aluno.Codigo_curso} - Curso: {aluno.Nome_curso} ");
                }
                else
                {
                    formatado.Items.Add($"Z - Pessoa: {pessoa.Nome} - Telefone: {pessoa.Telefone} - Cidade: {pessoa.Cidade} - RG: {pessoa.Rg} - CPF: {pessoa.Cpf}");
                }
            }

            numAlunos.Text = "Total de Alunos: " + totalAlunos;
            numPessoas.Text = "Total de Pessoas: " + totalPessoas;
        }

        //Realiza a separação entre alunos e pessoas
        public void ExibirAlunos(List<Pessoas> pessoas)
        {

            foreach (Pessoas pessoa in pessoas)
            {
                if (pessoa is Alunos aluno)
                {
                    alunosList.Items.Add($"Aluno: {aluno.Nome} - Matricula: {aluno.Matricula} - Cod. do Curso: {aluno.Codigo_curso} - Curso: {aluno.Nome_curso} ");
                } else
                {
                    pessoaList.Items.Add($"Pessoa: {pessoa.Nome} - Telefone: {pessoa.Telefone} - Cidade: {pessoa.Cidade} - RG: {pessoa.Rg} - CPF: {pessoa.Cpf}");

                }

            }

        }
    }

}