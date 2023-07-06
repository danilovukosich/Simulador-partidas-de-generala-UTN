namespace ParcialLabo2
{
    partial class FormularioGanador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioGanador));
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 296);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 17;
            label2.Text = "Ganador:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("MS Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 352);
            label3.Name = "label3";
            label3.Size = new Size(118, 30);
            label3.TabIndex = 18;
            label3.Text = "Puntos:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Tan;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(270, 47);
            label1.TabIndex = 24;
            label1.Text = "RESULTADOS";
            // 
            // FormularioGanador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(296, 408);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlText;
            Name = "FormularioGanador";
            Text = "FormularioGanador";
            Load += FormularioGanador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label2;
        public Label label3;
        public Label label1;
    }
}