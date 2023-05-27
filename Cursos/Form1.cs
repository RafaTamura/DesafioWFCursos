namespace Cursos
{
    public partial class Form1 : Form
    {
        private List<Pessoas> pessoas = new List<Pessoas>();
        Persistencia persistencia = new Persistencia();

        public Form1()
        {
            InitializeComponent();

        }

        // Botão para procurar o arquivo
        private void ButtonArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Filter = "Arquivo .txt|*.txt";

            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivo = Abrir.FileName;
                pessoas = persistencia.LerArquivo(nomeArquivo);
                pessoaList.Text = File.ReadAllText(nomeArquivo);

                MessageBox.Show("Arquivo Encontrado");
            }
        }
        //Carregar o Arquivo no primeiro ListBox já formatado
        private void botaoCarregarFormatado_Click(object sender, EventArgs e)
        {
            Exibir exibir = new Exibir(formatado, numAlunos, numPessoas, pessoaList, alunosList);
            exibir.ExibirResultados(pessoas);
        }

        //Separar em duas ListBox 
        private void buttonAlunos_Click(object sender, EventArgs e)
        {
            Exibir exibir = new Exibir(formatado, numAlunos, numPessoas, pessoaList, alunosList);
            exibir.ExibirAlunos(pessoas);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}