namespace lp3Cores
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
            cmbCores = new ComboBox();
            lblNome = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 39);
            label1.Name = "label1";
            label1.Size = new Size(67, 22);
            label1.TabIndex = 0;
            label1.Text = "Cores:";
            label1.Click += label1_Click;
            // 
            // cmbCores
            // 
            cmbCores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCores.FormattingEnabled = true;
            cmbCores.Items.AddRange(new object[] { "Azul", "Verde", "Amarelo", "Vermelho", "Laranja" });
            cmbCores.Location = new Point(112, 39);
            cmbCores.Name = "cmbCores";
            cmbCores.Size = new Size(121, 23);
            cmbCores.TabIndex = 1;
            cmbCores.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(65, 108);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(114, 22);
            lblNome.TabIndex = 2;
            lblNome.Text = "Jorge Silva";
            lblNome.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 177);
            Controls.Add(lblNome);
            Controls.Add(cmbCores);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCores;
        private Label lblNome;
    }
}
