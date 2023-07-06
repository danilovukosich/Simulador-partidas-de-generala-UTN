namespace ParcialLabo2
{
    partial class FomularioHistorialGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FomularioHistorialGeneral));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            jugadorUno = new DataGridViewTextBoxColumn();
            puntosJugadorUno = new DataGridViewTextBoxColumn();
            jugadorDos = new DataGridViewTextBoxColumn();
            puntosJugador2 = new DataGridViewTextBoxColumn();
            ganador = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(922, 522);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Tan;
            label2.Location = new Point(235, 87);
            label2.Name = "label2";
            label2.Size = new Size(552, 60);
            label2.TabIndex = 25;
            label2.Text = "HISTORIAL GENERAL";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { jugadorUno, puntosJugadorUno, jugadorDos, puntosJugador2, ganador });
            dataGridView1.Location = new Point(175, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(678, 368);
            dataGridView1.TabIndex = 34;
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
            // FomularioHistorialGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 626);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "FomularioHistorialGeneral";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FomularioHistorialGeneral";
            FormClosed += FomularioHistorialGeneral_FormClosed;
            Load += FomularioHistorialGeneral_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        public Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn jugadorUno;
        private DataGridViewTextBoxColumn puntosJugadorUno;
        private DataGridViewTextBoxColumn jugadorDos;
        private DataGridViewTextBoxColumn puntosJugador2;
        private DataGridViewTextBoxColumn ganador;
    }
}