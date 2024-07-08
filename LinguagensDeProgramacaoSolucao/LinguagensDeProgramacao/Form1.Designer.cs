namespace LinguagensDeProgramacao
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
            GbLinguagens = new GroupBox();
            ChkLingPython = new CheckBox();
            ChkLingJava = new CheckBox();
            ChkLingC = new CheckBox();
            BtnMostrar = new Button();
            GbLinguagens.SuspendLayout();
            SuspendLayout();
            // 
            // GbLinguagens
            // 
            GbLinguagens.Controls.Add(ChkLingPython);
            GbLinguagens.Controls.Add(ChkLingJava);
            GbLinguagens.Controls.Add(ChkLingC);
            GbLinguagens.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GbLinguagens.Location = new Point(112, 51);
            GbLinguagens.Name = "GbLinguagens";
            GbLinguagens.Size = new Size(284, 176);
            GbLinguagens.TabIndex = 0;
            GbLinguagens.TabStop = false;
            GbLinguagens.Text = "Linguagem que domino";
            // 
            // ChkLingPython
            // 
            ChkLingPython.AutoSize = true;
            ChkLingPython.Checked = true;
            ChkLingPython.CheckState = CheckState.Checked;
            ChkLingPython.Location = new Point(19, 110);
            ChkLingPython.Name = "ChkLingPython";
            ChkLingPython.Size = new Size(87, 26);
            ChkLingPython.TabIndex = 2;
            ChkLingPython.Text = "Python";
            ChkLingPython.UseVisualStyleBackColor = true;
            // 
            // ChkLingJava
            // 
            ChkLingJava.AutoSize = true;
            ChkLingJava.Checked = true;
            ChkLingJava.CheckState = CheckState.Checked;
            ChkLingJava.Location = new Point(19, 70);
            ChkLingJava.Name = "ChkLingJava";
            ChkLingJava.Size = new Size(68, 26);
            ChkLingJava.TabIndex = 1;
            ChkLingJava.Text = "Java";
            ChkLingJava.UseVisualStyleBackColor = true;
            // 
            // ChkLingC
            // 
            ChkLingC.AutoSize = true;
            ChkLingC.Checked = true;
            ChkLingC.CheckState = CheckState.Checked;
            ChkLingC.Location = new Point(20, 34);
            ChkLingC.Name = "ChkLingC";
            ChkLingC.Size = new Size(43, 26);
            ChkLingC.TabIndex = 0;
            ChkLingC.Text = "C";
            ChkLingC.UseVisualStyleBackColor = true;
            // 
            // BtnMostrar
            // 
            BtnMostrar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnMostrar.Location = new Point(174, 249);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(116, 37);
            BtnMostrar.TabIndex = 1;
            BtnMostrar.Text = "Mostrar";
            BtnMostrar.UseVisualStyleBackColor = true;
            BtnMostrar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 329);
            Controls.Add(BtnMostrar);
            Controls.Add(GbLinguagens);
            Name = "Form1";
            Text = "Linguagens de Programação";
            GbLinguagens.ResumeLayout(false);
            GbLinguagens.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbLinguagens;
        private CheckBox ChkLingPython;
        private CheckBox ChkLingJava;
        private CheckBox ChkLingC;
        private Button BtnMostrar;
    }
}
