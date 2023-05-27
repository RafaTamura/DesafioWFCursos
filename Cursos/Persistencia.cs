using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos
{
    public class Persistencia
    {
        public List<Pessoas> LerArquivo(string nomeArquivo)
        {
            List<Pessoas> pessoas = new List<Pessoas>();

            try
            {
                string[] linhas = File.ReadAllLines(nomeArquivo);

                for (int i = 0; i < linhas.Length; i++)
                {
                    string linha = linhas[i];

                    if (linha.StartsWith("Z"))
                    {
                        string[] dadosPessoa = linha.Split('-');
                        string nome = dadosPessoa[1];
                        string telefone = dadosPessoa[2];
                        string cidade = dadosPessoa[3];
                        string rg = dadosPessoa[4];
                        string cpf = dadosPessoa[5];

                        Pessoas pessoa = new Pessoas(nome, telefone, cidade, rg, cpf);
                        pessoas.Add(pessoa);

                        if (i + 1 < linhas.Length && linhas[i + 1].StartsWith("Y"))
                        {
                            string linhaCurso = linhas[i + 1];
                            string[] dadosCurso = linhaCurso.Split('-');
                            string matricula = dadosCurso[1];
                            string codigoCurso = dadosCurso[2];
                            string nomeCurso = dadosCurso[3];

                            Alunos aluno = new Alunos(nome, telefone, cidade, rg, cpf, matricula, codigoCurso, nomeCurso);
                            pessoas.Add(aluno);

                            i++;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Arquivo não encontrado ");
            }

            return pessoas;
        }
       
    }
}
