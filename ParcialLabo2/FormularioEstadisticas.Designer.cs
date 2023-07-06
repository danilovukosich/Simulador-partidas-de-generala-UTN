namespace ParcialLabo2
{
    partial class FormularioEstadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioEstadisticas));
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            jugadorUno = new DataGridViewTextBoxColumn();
            puntosJugadorUno = new DataGridViewTextBoxColumn();
            jugadorDos = new DataGridViewTextBoxColumn();
            puntosJugador2 = new DataGridViewTextBoxColumn();
            ganador = new DataGridViewTextBoxColumn();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            labelPartidasPerdidas = new Label();
            labelPartidasGanadas = new Label();
            labelPartidasJugadas = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(46, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 483);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(iconPictureBox2);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(labelPartidasPerdidas);
            panel2.Controls.Add(labelPartidasGanadas);
            panel2.Controls.Add(labelPartidasJugadas);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(26, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(1011, 441);
            panel2.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("MS Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(506, 103);
            label5.Name = "label5";
            label5.Size = new Size(478, 30);
            label5.TabIndex = 34;
            label5.Text = "Historial partidas del jugador:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { jugadorUno, puntosJugadorUno, jugadorDos, puntosJugador2, ganador });
            dataGridView1.Location = new Point(506, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(476, 259);
            dataGridView1.TabIndex = 33;
            // 
            // jugadorUno
            // 
            jugadorUno.HeaderText = "JUGADOR 1";
            jugadorUno.MinimumWidth = 6;
            jugadorUno.Name = "jugadorUno";
            jugadorUno.ReadOnly = true;
            jugadorUno.Width = 125;
            // 
            // puntosJugadorUno
            // 
            puntosJugadorUno.HeaderText = "PUNTOS";
            puntosJugadorUno.MinimumWidth = 6;
            puntosJugadorUno.Name = "puntosJugadorUno";
            puntosJugadorUno.ReadOnly = true;
            puntosJugadorUno.Width = 125;
            // 
            // jugadorDos
            // 
            jugadorDos.HeaderText = "JUGADOR 2";
            jugadorDos.MinimumWidth = 6;
            jugadorDos.Name = "jugadorDos";
            jugadorDos.ReadOnly = true;
            jugadorDos.Width = 125;
            // 
            // puntosJugador2
            // 
            puntosJugador2.HeaderText = "PUNTOS";
            puntosJugador2.MinimumWidth = 6;
            puntosJugador2.Name = "puntosJugador2";
            puntosJugador2.ReadOnly = true;
            puntosJugador2.Width = 125;
            // 
            // ganador
            // 
            ganador.HeaderText = "GANADOR";
            ganador.MinimumWidth = 6;
            ganador.Name = "ganador";
            ganador.ReadOnly = true;
            ganador.Width = 125;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.SquareRootAlt;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 60;
            iconPictureBox2.Location = new Point(714, 0);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(80, 60);
            iconPictureBox2.TabIndex = 32;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SquareRootAlt;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 60;
            iconPictureBox1.Location = new Point(240, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(80, 60);
            iconPictureBox1.TabIndex = 31;
            iconPictureBox1.TabStop = false;
            // 
            // labelPartidasPerdidas
            // 
            labelPartidasPerdidas.Anchor = AnchorStyles.None;
            labelPartidasPerdidas.AutoSize = true;
            labelPartidasPerdidas.BackColor = Color.Transparent;
            labelPartidasPerdidas.Font = new Font("MS Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelPartidasPerdidas.ForeColor = SystemColors.ActiveCaptionText;
            labelPartidasPerdidas.Location = new Point(320, 288);
            labelPartidasPerdidas.Name = "labelPartidasPerdidas";
            labelPartidasPerdidas.Size = new Size(103, 30);
            labelPartidasPerdidas.TabIndex = 30;
            labelPartidasPerdidas.Text = "numero";
            // 
            // labelPartidasGanadas
            // 
            labelPartidasGanadas.Anchor = AnchorStyles.None;
            labelPartidasGanadas.AutoSize = true;
            labelPartidasGanadas.BackColor = Color.Transparent;
            labelPartidasGanadas.Font = new Font("MS Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelPartidasGanadas.ForeColor = SystemColors.ActiveCaptionText;
            labelPartidasGanadas.Location = new Point(320, 228);
            labelPartidasGanadas.Name = "labelPartidasGanadas";
            labelPartidasGanadas.Size = new Size(103, 30);
            labelPartidasGanadas.TabIndex = 29;
            labelPartidasGanadas.Text = "numero";
            // 
            // labelPartidasJugadas
            // 
            labelPartidasJugadas.Anchor = AnchorStyles.None;
            labelPartidasJugadas.AutoSize = true;
            labelPartidasJugadas.BackColor = Color.Transparent;
            labelPartidasJugadas.Font = new Font("MS Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelPartidasJugadas.ForeColor = SystemColors.ActiveCaptionText;
            labelPartidasJugadas.Location = new Point(320, 168);
            labelPartidasJugadas.Name = "labelPartidasJugadas";
            labelPartidasJugadas.Size = new Size(103, 30);
            labelPartidasJugadas.TabIndex = 28;
            labelPartidasJugadas.Text = "numero";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("MS Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(31, 288);
            label4.Name = "label4";
            label4.Size = new Size(298, 30);
            label4.TabIndex = 27;
            label4.Text = "Partidas perdidas: ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("MS Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(31, 228);
            label3.Name = "label3";
            label3.Size = new Size(283, 30);
            label3.TabIndex = 26;
            label3.Text = "Partidas ganadas: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(31, 168);
            label1.Name = "label1";
            label1.Size = new Size(283, 30);
            label1.TabIndex = 25;
            label1.Text = "Partidas jugadas: ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Tan;
            label2.Location = new Point(311, 0);
            label2.Name = "label2";
            label2.Size = new Size(397, 60);
            label2.TabIndex = 24;
            label2.Text = "ESTADISTICAS";
            // 
            // FormularioEstadisticas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1162, 571);
            Controls.Add(panel1);
            Name = "FormularioEstadisticas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioEstadisticas";
            FormClosed += FormularioEstadisticas_FormClosed;
            Load += FormularioEstadisticas_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        public Label label2;
        public Label label5;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public Label labelPartidasPerdidas;
        public Label labelPartidasGanadas;
        public Label labelPartidasJugadas;
        public Label label4;
        public Label label3;
        public Label label1;
        private DataGridViewTextBoxColumn jugadorUno;
        private DataGridViewTextBoxColumn puntosJugadorUno;
        private DataGridViewTextBoxColumn jugadorDos;
        private DataGridViewTextBoxColumn puntosJugador2;
        private DataGridViewTextBoxColumn ganador;
    }
}