namespace Cursos
{
    public class Pessoas
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }

        public Pessoas(string nome, string telefone, string cidade, string rg, string cpf)
        {
            Nome = nome;
            Telefone = telefone;
            Cidade = cidade;
            Rg = rg;
            Cpf = cpf;
        }
    }
        }


