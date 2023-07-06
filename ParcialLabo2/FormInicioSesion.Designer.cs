namespace ParcialLabo2
{
    partial class FormInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioSesion));
            label4 = new Label();
            comboBoxInicioSesionRapido = new ComboBox();
            label1 = new Label();
            buttonLogIn = new Button();
            textBoxContrasenia = new TextBox();
            textBoxUsuario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            buttonRegistrarse = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(188, 438);
            label4.Name = "label4";
            label4.Size = new Size(150, 19);
            label4.TabIndex = 22;
            label4.Text = "Inicio Sesion Rapido";
            // 
            // comboBoxInicioSesionRapido
            // 
            comboBoxInicioSesionRapido.Anchor = AnchorStyles.None;
            comboBoxInicioSesionRapido.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxInicioSesionRapido.FormattingEnabled = true;
            comboBoxInicioSesionRapido.Location = new Point(188, 460);
            comboBoxInicioSesionRapido.Name = "comboBoxInicioSesionRapido";
            comboBoxInicioSesionRapido.Size = new Size(149, 27);
            comboBoxInicioSesionRapido.TabIndex = 21;
            comboBoxInicioSesionRapido.SelectedIndexChanged += comboBoxInicioSesionRapido_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(167, 230);
            label1.Name = "label1";
            label1.Size = new Size(208, 30);
            label1.TabIndex = 15;
            label1.Text = "Inicio Sesión";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Anchor = AnchorStyles.None;
            buttonLogIn.BackColor = Color.Tan;
            buttonLogIn.BackgroundImageLayout = ImageLayout.None;
            buttonLogIn.Cursor = Cursors.Hand;
            buttonLogIn.FlatAppearance.BorderSize = 0;
            buttonLogIn.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogIn.ForeColor = SystemColors.ActiveCaptionText;
            buttonLogIn.Location = new Point(203, 368);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(125, 56);
            buttonLogIn.TabIndex = 14;
            buttonLogIn.Text = "ACCEDER";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // textBoxContrasenia
            // 
            textBoxContrasenia.Anchor = AnchorStyles.None;
            textBoxContrasenia.BackColor = Color.WhiteSmoke;
            textBoxContrasenia.Font = new Font("Microsoft JhengHei Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContrasenia.ForeColor = SystemColors.GrayText;
            textBoxContrasenia.Location = new Point(175, 311);
            textBoxContrasenia.Name = "textBoxContrasenia";
            textBoxContrasenia.Size = new Size(190, 34);
            textBoxContrasenia.TabIndex = 13;
            textBoxContrasenia.Text = "Contraseña";
            textBoxContrasenia.Enter += textBoxContrasenia_Enter;
            textBoxContrasenia.Leave += textBoxContrasenia_Leave;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.None;
            textBoxUsuario.BackColor = Color.WhiteSmoke;
            textBoxUsuario.Font = new Font("Microsoft JhengHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsuario.ForeColor = SystemColors.GrayText;
            textBoxUsuario.Location = new Point(175, 263);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(190, 33);
            textBoxUsuario.TabIndex = 12;
            textBoxUsuario.Text = "Usuario";
            textBoxUsuario.Enter += textBoxUsuario_Enter;
            textBoxUsuario.Leave += textBoxUsuario_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Tan;
            label2.Location = new Point(130, 9);
            label2.Name = "label2";
            label2.Size = new Size(273, 60);
            label2.TabIndex = 23;
            label2.Text = "GENERALA";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(175, 529);
            label3.Name = "label3";
            label3.Size = new Size(200, 19);
            label3.TabIndex = 24;
            label3.Text = "No tiene cuenta? Registrate";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(412, 190);
            button1.Name = "button1";
            button1.Size = new Size(0, 31);
            button1.TabIndex = 25;
            button1.Text = "ACCEDER";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonRegistrarse
            // 
            buttonRegistrarse.Anchor = AnchorStyles.None;
            buttonRegistrarse.BackColor = Color.Tan;
            buttonRegistrarse.Cursor = Cursors.Hand;
            buttonRegistrarse.FlatAppearance.BorderSize = 0;
            buttonRegistrarse.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegistrarse.ForeColor = SystemColors.ActiveCaptionText;
            buttonRegistrarse.Location = new Point(217, 551);
            buttonRegistrarse.Name = "buttonRegistrarse";
            buttonRegistrarse.Size = new Size(102, 35);
            buttonRegistrarse.TabIndex = 26;
            buttonRegistrarse.Text = "Registrarse";
            buttonRegistrarse.UseVisualStyleBackColor = false;
            buttonRegistrarse.Click += button2_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.Firebrick;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Dice;
            iconPictureBox1.IconColor = Color.Firebrick;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 122;
            iconPictureBox1.Location = new Point(203, 84);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(131, 122);
            iconPictureBox1.TabIndex = 27;
            iconPictureBox1.TabStop = false;
            // 
            // FormInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(536, 598);
            Controls.Add(iconPictureBox1);
            Controls.Add(buttonRegistrarse);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(comboBoxInicioSesionRapido);
            Controls.Add(label1);
            Controls.Add(buttonLogIn);
            Controls.Add(textBoxContrasenia);
            Controls.Add(textBoxUsuario);
            Name = "FormInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += FormInicioSesion_FormClosed;
            Load += FormInicioSesion_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox comboBoxInicioSesionRapido;
        public Label label1;
        public Button buttonLogIn;
        public TextBox textBoxContrasenia;
        public TextBox textBoxUsuario;
        public Label label2;
        private Label label3;
        public Button button1;
        public Button buttonRegistrarse;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}