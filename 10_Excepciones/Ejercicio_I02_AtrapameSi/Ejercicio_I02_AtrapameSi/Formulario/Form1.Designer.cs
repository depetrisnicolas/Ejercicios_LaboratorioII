namespace Formulario
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
            label2 = new Label();
            txtLitros = new TextBox();
            txtKm = new TextBox();
            btnCalcular = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 38);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Kilometros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 109);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Litros";
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(29, 139);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(100, 23);
            txtLitros.TabIndex = 2;
            // 
            // txtKm
            // 
            txtKm.Location = new Point(29, 65);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(100, 23);
            txtKm.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(29, 218);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(227, 38);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(234, 203);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 258);
            Controls.Add(richTextBox1);
            Controls.Add(btnCalcular);
            Controls.Add(txtKm);
            Controls.Add(txtLitros);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLitros;
        private TextBox txtKm;
        private Button btnCalcular;
        private RichTextBox richTextBox1;
    }
}