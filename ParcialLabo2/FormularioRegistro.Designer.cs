namespace ParcialLabo2
{
    partial class FormularioRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioRegistro));
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            textBoxUsuario = new TextBox();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxContrasenia = new TextBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            buttonRegistrar = new Button();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(79, 24);
            label1.Name = "label1";
            label1.Size = new Size(239, 44);
            label1.TabIndex = 16;
            label1.Text = "Registrate";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.Firebrick;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Dice;
            iconPictureBox1.IconColor = Color.Firebrick;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 99;
            iconPictureBox1.Location = new Point(0, -8);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(117, 99);
            iconPictureBox1.TabIndex = 28;
            iconPictureBox1.TabStop = false;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.None;
            textBoxUsuario.BackColor = Color.WhiteSmoke;
            textBoxUsuario.Font = new Font("Microsoft JhengHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsuario.ForeColor = SystemColors.GrayText;
            textBoxUsuario.Location = new Point(69, 226);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(190, 33);
            textBoxUsuario.TabIndex = 29;
            textBoxUsuario.Enter += textBoxUsuario_Enter;
            textBoxUsuario.Leave += textBoxUsuario_Leave;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.None;
            textBoxNombre.BackColor = Color.WhiteSmoke;
            textBoxNombre.Font = new Font("Microsoft JhengHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.ForeColor = SystemColors.GrayText;
            textBoxNombre.Location = new Point(69, 97);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(190, 33);
            textBoxNombre.TabIndex = 30;
            textBoxNombre.Enter += textBoxNombre_Enter;
            textBoxNombre.KeyPress += textBoxNombre_KeyPress;
            textBoxNombre.Leave += textBoxNombre_Leave;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Anchor = AnchorStyles.None;
            textBoxApellido.BackColor = Color.WhiteSmoke;
            textBoxApellido.Font = new Font("Microsoft JhengHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxApellido.ForeColor = SystemColors.GrayText;
            textBoxApellido.Location = new Point(69, 159);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(190, 33);
            textBoxApellido.TabIndex = 31;
            textBoxApellido.Enter += textBoxApellido_Enter;
            textBoxApellido.KeyPress += textBoxApellido_KeyPress;
            textBoxApellido.Leave += textBoxApellido_Leave;
            // 
            // textBoxContrasenia
            // 
            textBoxContrasenia.Anchor = AnchorStyles.None;
            textBoxContrasenia.BackColor = Color.WhiteSmoke;
            textBoxContrasenia.Font = new Font("Microsoft JhengHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContrasenia.ForeColor = SystemColors.GrayText;
            textBoxContrasenia.Location = new Point(69, 293);
            textBoxContrasenia.Name = "textBoxContrasenia";
            textBoxContrasenia.Size = new Size(190, 33);
            textBoxContrasenia.TabIndex = 32;
            textBoxContrasenia.Enter += textBoxContrasenia_Enter;
            textBoxContrasenia.Leave += textBoxContrasenia_Leave;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Tan;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 40;
            iconPictureBox2.Location = new Point(23, 90);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(40, 40);
            iconPictureBox2.TabIndex = 33;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Tan;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 40;
            iconPictureBox3.Location = new Point(23, 152);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(40, 40);
            iconPictureBox3.TabIndex = 34;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Tan;
            iconPictureBox4.ForeColor = SystemColors.ControlText;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox4.IconColor = SystemColors.ControlText;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 40;
            iconPictureBox4.Location = new Point(23, 219);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(40, 40);
            iconPictureBox4.TabIndex = 35;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.Tan;
            iconPictureBox5.ForeColor = SystemColors.ControlText;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox5.IconColor = SystemColors.ControlText;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 40;
            iconPictureBox5.Location = new Point(23, 286);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(40, 40);
            iconPictureBox5.TabIndex = 36;
            iconPictureBox5.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconPictureBox5);
            panel1.Controls.Add(textBoxUsuario);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(iconPictureBox4);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(iconPictureBox3);
            panel1.Controls.Add(textBoxApellido);
            panel1.Controls.Add(iconPictureBox2);
            panel1.Controls.Add(textBoxContrasenia);
            panel1.Location = new Point(238, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 360);
            panel1.TabIndex = 37;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(69, 275);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 40;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(69, 208);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 39;
            label4.Text = "Usuario";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(69, 141);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 38;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(69, 79);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 37;
            label2.Text = "Nombre";
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Anchor = AnchorStyles.None;
            buttonRegistrar.BackColor = Color.Tan;
            buttonRegistrar.BackgroundImageLayout = ImageLayout.None;
            buttonRegistrar.Cursor = Cursors.Hand;
            buttonRegistrar.FlatAppearance.BorderSize = 0;
            buttonRegistrar.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegistrar.ForeColor = SystemColors.ActiveCaptionText;
            buttonRegistrar.Location = new Point(271, 378);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(125, 56);
            buttonRegistrar.TabIndex = 37;
            buttonRegistrar.Text = "REGISTRAR";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.None;
            buttonCancelar.BackColor = Color.Tan;
            buttonCancelar.BackgroundImageLayout = ImageLayout.None;
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.FlatAppearance.BorderSize = 0;
            buttonCancelar.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancelar.Location = new Point(407, 378);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(125, 56);
            buttonCancelar.TabIndex = 38;
            buttonCancelar.Text = "CANCELAR";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormularioRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonRegistrar);
            Controls.Add(panel1);
            Name = "FormularioRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioRegistro";
            FormClosed += FormularioRegistro_FormClosed;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public TextBox textBoxUsuario;
        public TextBox textBoxNombre;
        public TextBox textBoxApellido;
        public TextBox textBoxContrasenia;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Panel panel1;
        public Button buttonRegistrar;
        public Button buttonCancelar;
        public Label label5;
        public Label label4;
        public Label label3;
        public Label label2;
    }
}