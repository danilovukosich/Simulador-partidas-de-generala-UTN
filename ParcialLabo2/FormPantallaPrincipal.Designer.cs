namespace ParcialLabo2
{
    partial class FormPantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPantallaPrincipal));
            buttonCrearPartida = new Button();
            buttonEstadisticas = new Button();
            buttonHistorialPartidas = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            labelBienvenido = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCrearPartida
            // 
            buttonCrearPartida.Anchor = AnchorStyles.None;
            buttonCrearPartida.BackColor = Color.Tan;
            buttonCrearPartida.BackgroundImageLayout = ImageLayout.None;
            buttonCrearPartida.Cursor = Cursors.Hand;
            buttonCrearPartida.FlatAppearance.BorderSize = 0;
            buttonCrearPartida.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCrearPartida.ForeColor = SystemColors.ActiveCaptionText;
            buttonCrearPartida.Location = new Point(595, 54);
            buttonCrearPartida.Name = "buttonCrearPartida";
            buttonCrearPartida.Size = new Size(148, 73);
            buttonCrearPartida.TabIndex = 38;
            buttonCrearPartida.Text = "CREAR PARTIDA";
            buttonCrearPartida.UseVisualStyleBackColor = false;
            buttonCrearPartida.Click += buttonCrearPartida_Click;
            // 
            // buttonEstadisticas
            // 
            buttonEstadisticas.Anchor = AnchorStyles.None;
            buttonEstadisticas.BackColor = Color.Tan;
            buttonEstadisticas.BackgroundImageLayout = ImageLayout.None;
            buttonEstadisticas.Cursor = Cursors.Hand;
            buttonEstadisticas.FlatAppearance.BorderSize = 0;
            buttonEstadisticas.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEstadisticas.ForeColor = SystemColors.ActiveCaptionText;
            buttonEstadisticas.Location = new Point(595, 156);
            buttonEstadisticas.Name = "buttonEstadisticas";
            buttonEstadisticas.Size = new Size(146, 78);
            buttonEstadisticas.TabIndex = 39;
            buttonEstadisticas.Text = "ESTADISTICAS";
            buttonEstadisticas.UseVisualStyleBackColor = false;
            buttonEstadisticas.Click += buttonEstadisticas_Click;
            // 
            // buttonHistorialPartidas
            // 
            buttonHistorialPartidas.Anchor = AnchorStyles.None;
            buttonHistorialPartidas.BackColor = Color.Tan;
            buttonHistorialPartidas.BackgroundImageLayout = ImageLayout.None;
            buttonHistorialPartidas.Cursor = Cursors.Hand;
            buttonHistorialPartidas.FlatAppearance.BorderSize = 0;
            buttonHistorialPartidas.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHistorialPartidas.ForeColor = SystemColors.ActiveCaptionText;
            buttonHistorialPartidas.Location = new Point(595, 272);
            buttonHistorialPartidas.Name = "buttonHistorialPartidas";
            buttonHistorialPartidas.Size = new Size(148, 77);
            buttonHistorialPartidas.TabIndex = 40;
            buttonHistorialPartidas.Text = "HISTORIAL PARTIDAS";
            buttonHistorialPartidas.UseVisualStyleBackColor = false;
            buttonHistorialPartidas.Click += buttonHistorialPartidas_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.Firebrick;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Dice;
            iconPictureBox1.IconColor = Color.Firebrick;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 122;
            iconPictureBox1.Location = new Point(238, 156);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(131, 122);
            iconPictureBox1.TabIndex = 42;
            iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Tan;
            label2.Location = new Point(166, 281);
            label2.Name = "label2";
            label2.Size = new Size(273, 60);
            label2.TabIndex = 41;
            label2.Text = "GENERALA";
            // 
            // labelBienvenido
            // 
            labelBienvenido.Anchor = AnchorStyles.None;
            labelBienvenido.AutoSize = true;
            labelBienvenido.BackColor = Color.Transparent;
            labelBienvenido.Font = new Font("MS Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelBienvenido.ForeColor = SystemColors.ActiveCaptionText;
            labelBienvenido.Location = new Point(12, 9);
            labelBienvenido.Name = "labelBienvenido";
            labelBienvenido.Size = new Size(163, 30);
            labelBienvenido.TabIndex = 43;
            labelBienvenido.Text = "Bienvenido";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("MS Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Tan;
            label3.Location = new Point(121, 94);
            label3.Name = "label3";
            label3.Size = new Size(366, 60);
            label3.TabIndex = 44;
            label3.Text = "JUEGA AHORA";
            // 
            // FormPantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(labelBienvenido);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(buttonHistorialPartidas);
            Controls.Add(buttonEstadisticas);
            Controls.Add(buttonCrearPartida);
            Name = "FormPantallaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPantallaPrincipal";
            FormClosed += FormPantallaPrincipal_FormClosed;
            Load += FormPantallaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button buttonCrearPartida;
        public Button buttonEstadisticas;
        public Button buttonHistorialPartidas;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public Label label2;
        public Label labelBienvenido;
        public Label label3;
    }
}