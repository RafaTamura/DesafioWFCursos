namespace Cursos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ButtonArquivo = new Button();
            botaoCarregarFormatado = new Button();
            formatado = new ListBox();
            pessoaList = new ListBox();
            numAlunos = new Label();
            numPessoas = new Label();
            alunosList = new ListBox();
            buttonAlunos = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(600, 39);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // ButtonArquivo
            // 
            ButtonArquivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonArquivo.Location = new Point(471, 12);
            ButtonArquivo.Name = "ButtonArquivo";
            ButtonArquivo.Size = new Size(292, 44);
            ButtonArquivo.TabIndex = 2;
            ButtonArquivo.Text = "Selecionar Arquivo";
            ButtonArquivo.UseVisualStyleBackColor = true;
            ButtonArquivo.Click += ButtonArquivo_Click;
            // 
            // botaoCarregarFormatado
            // 
            botaoCarregarFormatado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            botaoCarregarFormatado.Location = new Point(12, 64);
            botaoCarregarFormatado.Name = "botaoCarregarFormatado";
            botaoCarregarFormatado.Size = new Size(331, 47);
            botaoCarregarFormatado.TabIndex = 3;
            botaoCarregarFormatado.Text = "Carregar Alunos e Pessoas";
            botaoCarregarFormatado.UseVisualStyleBackColor = true;
            botaoCarregarFormatado.Click += botaoCarregarFormatado_Click;
            // 
            // formatado
            // 
            formatado.FormattingEnabled = true;
            formatado.HorizontalScrollbar = true;
            formatado.ItemHeight = 20;
            formatado.Location = new Point(12, 117);
            formatado.Name = "formatado";
            formatado.ScrollAlwaysVisible = true;
            formatado.Size = new Size(331, 324);
            formatado.TabIndex = 4;
            // 
            // pessoaList
            // 
            pessoaList.FormattingEnabled = true;
            pessoaList.HorizontalScrollbar = true;
            pessoaList.ItemHeight = 20;
            pessoaList.Location = new Point(387, 117);
            pessoaList.Name = "pessoaList";
            pessoaList.ScrollAlwaysVisible = true;
            pessoaList.Size = new Size(276, 324);
            pessoaList.TabIndex = 5;
            // 
            // numAlunos
            // 
            numAlunos.AutoSize = true;
            numAlunos.Location = new Point(712, 459);
            numAlunos.Name = "numAlunos";
            numAlunos.Size = new Size(157, 20);
            numAlunos.TabIndex = 6;
            numAlunos.Text = "Quantidade de Alunos";
            // 
            // numPessoas
            // 
            numPessoas.AutoSize = true;
            numPessoas.Location = new Point(384, 459);
            numPessoas.Name = "numPessoas";
            numPessoas.Size = new Size(162, 20);
            numPessoas.TabIndex = 7;
            numPessoas.Text = "Quantidade de Pessoas";
            // 
            // alunosList
            // 
            alunosList.FormattingEnabled = true;
            alunosList.HorizontalScrollbar = true;
            alunosList.ItemHeight = 20;
            alunosList.Location = new Point(712, 117);
            alunosList.Name = "alunosList";
            alunosList.ScrollAlwaysVisible = true;
            alunosList.Size = new Size(271, 324);
            alunosList.TabIndex = 8;
            // 
            // buttonAlunos
            // 
            buttonAlunos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAlunos.Location = new Point(488, 62);
            buttonAlunos.Name = "buttonAlunos";
            buttonAlunos.Size = new Size(408, 49);
            buttonAlunos.TabIndex = 10;
            buttonAlunos.Text = "Separar Alunos e Pessoas";
            buttonAlunos.UseVisualStyleBackColor = true;
            buttonAlunos.Click += buttonAlunos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(159, 20);
            label2.Name = "label2";
            label2.Size = new Size(283, 28);
            label2.TabIndex = 11;
            label2.Text = "Primeiro selecione o arquivo";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 488);
            Controls.Add(label2);
            Controls.Add(buttonAlunos);
            Controls.Add(alunosList);
            Controls.Add(numPessoas);
            Controls.Add(numAlunos);
            Controls.Add(pessoaList);
            Controls.Add(formatado);
            Controls.Add(botaoCarregarFormatado);
            Controls.Add(ButtonArquivo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cursos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ButtonArquivo;
        private Button botaoCarregarFormatado;
        private ListBox formatado;
        private ListBox pessoaList;
        private Label numAlunos;
        private Label numPessoas;
        private ListBox alunosList;
        private Button buttonAlunos;
        private Label label2;
    }
}