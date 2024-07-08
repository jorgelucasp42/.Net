namespace Pets
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
            lblEspecie = new Label();
            lblName = new Label();
            lblIdade = new Label();
            cmbEspecie = new ComboBox();
            txbNome = new TextBox();
            txbIdade = new TextBox();
            groupBox1 = new GroupBox();
            rdbFemea = new RadioButton();
            rdbMacho = new RadioButton();
            btnMostrar = new Button();
            btnLimpar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Location = new Point(63, 52);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(49, 15);
            lblEspecie.TabIndex = 0;
            lblEspecie.Text = "Espécie:";
            lblEspecie.Click += label1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(63, 98);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nome:";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(63, 149);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(39, 15);
            lblIdade.TabIndex = 2;
            lblIdade.Text = "Idade:";
            // 
            // cmbEspecie
            // 
            cmbEspecie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecie.FormattingEnabled = true;
            cmbEspecie.Items.AddRange(new object[] { "Cão", "Gato", "Réptil", "Macaco", "Aves" });
            cmbEspecie.Location = new Point(146, 49);
            cmbEspecie.Name = "cmbEspecie";
            cmbEspecie.Size = new Size(121, 23);
            cmbEspecie.TabIndex = 3;
            cmbEspecie.SelectedIndexChanged += cmbEspecie_SelectedIndexChanged;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(146, 98);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(121, 23);
            txbNome.TabIndex = 4;
            // 
            // txbIdade
            // 
            txbIdade.Location = new Point(146, 146);
            txbIdade.Name = "txbIdade";
            txbIdade.Size = new Size(127, 23);
            txbIdade.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbFemea);
            groupBox1.Controls.Add(rdbMacho);
            groupBox1.Location = new Point(73, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rdbFemea
            // 
            rdbFemea.AutoSize = true;
            rdbFemea.Location = new Point(103, 47);
            rdbFemea.Name = "rdbFemea";
            rdbFemea.Size = new Size(60, 19);
            rdbFemea.TabIndex = 1;
            rdbFemea.TabStop = true;
            rdbFemea.Text = "Fêmea";
            rdbFemea.UseVisualStyleBackColor = true;
            // 
            // rdbMacho
            // 
            rdbMacho.AutoSize = true;
            rdbMacho.Location = new Point(12, 46);
            rdbMacho.Name = "rdbMacho";
            rdbMacho.Size = new Size(62, 19);
            rdbMacho.TabIndex = 0;
            rdbMacho.TabStop = true;
            rdbMacho.Text = "Macho";
            rdbMacho.UseVisualStyleBackColor = true;
            rdbMacho.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(63, 331);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 7;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += button1_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(218, 331);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 391);
            Controls.Add(btnLimpar);
            Controls.Add(btnMostrar);
            Controls.Add(groupBox1);
            Controls.Add(txbIdade);
            Controls.Add(txbNome);
            Controls.Add(cmbEspecie);
            Controls.Add(lblIdade);
            Controls.Add(lblName);
            Controls.Add(lblEspecie);
            Name = "Form1";
            Text = "Pets";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEspecie;
        private Label lblName;
        private Label lblIdade;
        private ComboBox cmbEspecie;
        private TextBox txbNome;
        private TextBox txbIdade;
        private GroupBox groupBox1;
        private RadioButton rdbMacho;
        private RadioButton rdbFemea;
        private Button btnMostrar;
        private Button btnLimpar;
    }
}
