namespace FormContador
{
    partial class ContadorPalabras
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
            txtPalabras = new RichTextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(-3, 0);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(806, 401);
            txtPalabras.TabIndex = 0;
            txtPalabras.Text = "";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(665, 410);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(103, 28);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // ContadorPalabras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtPalabras);
            Name = "ContadorPalabras";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtPalabras;
        private Button btnCalcular;
    }
}