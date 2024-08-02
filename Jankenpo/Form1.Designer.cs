namespace Jankenpo
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
            splitContainer1 = new SplitContainer();
            grupoPlacar = new GroupBox();
            placarCPU = new Label();
            placarJogador = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            imgEscolhaCPU = new PictureBox();
            groupBox1 = new GroupBox();
            imgEscolhaJogador = new PictureBox();
            botaoTesoura = new Button();
            botaoPapel = new Button();
            botaoPedra = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            grupoPlacar.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgEscolhaCPU).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgEscolhaJogador).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(grupoPlacar);
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(botaoTesoura);
            splitContainer1.Panel2.Controls.Add(botaoPapel);
            splitContainer1.Panel2.Controls.Add(botaoPedra);
            splitContainer1.Size = new Size(624, 441);
            splitContainer1.SplitterDistance = 239;
            splitContainer1.TabIndex = 0;
            // 
            // grupoPlacar
            // 
            grupoPlacar.Controls.Add(placarCPU);
            grupoPlacar.Controls.Add(placarJogador);
            grupoPlacar.Controls.Add(label2);
            grupoPlacar.Controls.Add(label1);
            grupoPlacar.Location = new Point(213, 60);
            grupoPlacar.Name = "grupoPlacar";
            grupoPlacar.Size = new Size(200, 145);
            grupoPlacar.TabIndex = 2;
            grupoPlacar.TabStop = false;
            grupoPlacar.Text = "Placar";
            // 
            // placarCPU
            // 
            placarCPU.AutoSize = true;
            placarCPU.Font = new Font("Segoe UI", 30F);
            placarCPU.Location = new Point(128, 54);
            placarCPU.Name = "placarCPU";
            placarCPU.Size = new Size(45, 54);
            placarCPU.TabIndex = 3;
            placarCPU.Text = "0";
            // 
            // placarJogador
            // 
            placarJogador.AutoSize = true;
            placarJogador.Font = new Font("Segoe UI", 30F);
            placarJogador.Location = new Point(30, 54);
            placarJogador.Name = "placarJogador";
            placarJogador.Size = new Size(45, 54);
            placarJogador.TabIndex = 2;
            placarJogador.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(128, 19);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 1;
            label2.Text = "CPU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 0;
            label1.Text = "Jogador";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(imgEscolhaCPU);
            groupBox2.Location = new Point(412, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 145);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Jogada CPU";
            // 
            // imgEscolhaCPU
            // 
            imgEscolhaCPU.BackgroundImageLayout = ImageLayout.Stretch;
            imgEscolhaCPU.Location = new Point(6, 22);
            imgEscolhaCPU.Name = "imgEscolhaCPU";
            imgEscolhaCPU.Size = new Size(188, 117);
            imgEscolhaCPU.TabIndex = 1;
            imgEscolhaCPU.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(imgEscolhaJogador);
            groupBox1.Location = new Point(13, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Minha Jogada";
            // 
            // imgEscolhaJogador
            // 
            imgEscolhaJogador.BackgroundImageLayout = ImageLayout.Stretch;
            imgEscolhaJogador.Location = new Point(6, 22);
            imgEscolhaJogador.Name = "imgEscolhaJogador";
            imgEscolhaJogador.Size = new Size(188, 117);
            imgEscolhaJogador.TabIndex = 0;
            imgEscolhaJogador.TabStop = false;
            // 
            // botaoTesoura
            // 
            botaoTesoura.BackgroundImage = Properties.Resources.tesoura;
            botaoTesoura.BackgroundImageLayout = ImageLayout.Stretch;
            botaoTesoura.Dock = DockStyle.Left;
            botaoTesoura.Location = new Point(426, 0);
            botaoTesoura.Name = "botaoTesoura";
            botaoTesoura.Size = new Size(198, 198);
            botaoTesoura.TabIndex = 2;
            botaoTesoura.UseVisualStyleBackColor = true;
            botaoTesoura.Click += botaoTesoura_Click;
            // 
            // botaoPapel
            // 
            botaoPapel.BackgroundImage = Properties.Resources.papel;
            botaoPapel.BackgroundImageLayout = ImageLayout.Stretch;
            botaoPapel.Dock = DockStyle.Left;
            botaoPapel.Location = new Point(213, 0);
            botaoPapel.Name = "botaoPapel";
            botaoPapel.Size = new Size(213, 198);
            botaoPapel.TabIndex = 1;
            botaoPapel.UseVisualStyleBackColor = true;
            botaoPapel.Click += botaoPapel_Click;
            // 
            // botaoPedra
            // 
            botaoPedra.BackgroundImage = Properties.Resources.pedra;
            botaoPedra.BackgroundImageLayout = ImageLayout.Stretch;
            botaoPedra.Dock = DockStyle.Left;
            botaoPedra.Location = new Point(0, 0);
            botaoPedra.Name = "botaoPedra";
            botaoPedra.Size = new Size(213, 198);
            botaoPedra.TabIndex = 0;
            botaoPedra.UseVisualStyleBackColor = true;
            botaoPedra.Click += botaoPedra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jankenpo";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            grupoPlacar.ResumeLayout(false);
            grupoPlacar.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgEscolhaCPU).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgEscolhaJogador).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button botaoPedra;
        private Button botaoTesoura;
        private Button botaoPapel;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private PictureBox imgEscolhaCPU;
        private PictureBox imgEscolhaJogador;
        private GroupBox grupoPlacar;
        private Label placarCPU;
        private Label placarJogador;
        private Label label2;
        private Label label1;
    }
}
