namespace Form1
{
    partial class FormRegistro
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
            grpUsuario = new GroupBox();
            lblDireccion = new Label();
            lblEdad = new Label();
            nudEdad = new NumericUpDown();
            txtDireccion = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            grpGenero = new GroupBox();
            rdoNoBinario = new RadioButton();
            rdoMasculino = new RadioButton();
            rdoFemenino = new RadioButton();
            grpCursos = new GroupBox();
            chkJavascript = new CheckBox();
            chkCpp = new CheckBox();
            chkCsharp = new CheckBox();
            lstPaises = new ListBox();
            lblPais = new Label();
            btnIngresar = new Button();
            grpUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            grpGenero.SuspendLayout();
            grpCursos.SuspendLayout();
            SuspendLayout();
            // 
            // grpUsuario
            // 
            grpUsuario.Controls.Add(lblDireccion);
            grpUsuario.Controls.Add(lblEdad);
            grpUsuario.Controls.Add(nudEdad);
            grpUsuario.Controls.Add(txtDireccion);
            grpUsuario.Controls.Add(lblNombre);
            grpUsuario.Controls.Add(txtNombre);
            grpUsuario.Location = new Point(36, 31);
            grpUsuario.Name = "grpUsuario";
            grpUsuario.Size = new Size(249, 167);
            grpUsuario.TabIndex = 0;
            grpUsuario.TabStop = false;
            grpUsuario.Text = "Detalles del usuario";
         
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(6, 73);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "Dirección";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(6, 112);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(93, 112);
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(120, 23);
            nudEdad.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(93, 70);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(120, 23);
            txtDireccion.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(93, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 23);
            txtNombre.TabIndex = 0;
            // 
            // grpGenero
            // 
            grpGenero.Controls.Add(rdoNoBinario);
            grpGenero.Controls.Add(rdoMasculino);
            grpGenero.Controls.Add(rdoFemenino);
            grpGenero.Location = new Point(344, 31);
            grpGenero.Name = "grpGenero";
            grpGenero.Size = new Size(125, 135);
            grpGenero.TabIndex = 1;
            grpGenero.TabStop = false;
            grpGenero.Text = "Género";
            // 
            // rdoNoBinario
            // 
            rdoNoBinario.AutoSize = true;
            rdoNoBinario.Location = new Point(4, 74);
            rdoNoBinario.Name = "rdoNoBinario";
            rdoNoBinario.Size = new Size(81, 19);
            rdoNoBinario.TabIndex = 4;
            rdoNoBinario.TabStop = true;
            rdoNoBinario.Text = "No binario";
            rdoNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            rdoMasculino.AutoSize = true;
            rdoMasculino.Location = new Point(4, 22);
            rdoMasculino.Name = "rdoMasculino";
            rdoMasculino.Size = new Size(80, 19);
            rdoMasculino.TabIndex = 2;
            rdoMasculino.TabStop = true;
            rdoMasculino.Text = "Masculino";
            rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // rdoFemenino
            // 
            rdoFemenino.AutoSize = true;
            rdoFemenino.Location = new Point(4, 47);
            rdoFemenino.Name = "rdoFemenino";
            rdoFemenino.Size = new Size(78, 19);
            rdoFemenino.TabIndex = 3;
            rdoFemenino.TabStop = true;
            rdoFemenino.Text = "Femenino";
            rdoFemenino.UseVisualStyleBackColor = true;
            // 
            // grpCursos
            // 
            grpCursos.Controls.Add(chkJavascript);
            grpCursos.Controls.Add(chkCpp);
            grpCursos.Controls.Add(chkCsharp);
            grpCursos.Location = new Point(344, 188);
            grpCursos.Name = "grpCursos";
            grpCursos.Size = new Size(125, 106);
            grpCursos.TabIndex = 2;
            grpCursos.TabStop = false;
            grpCursos.Text = "Cursos";
            // 
            // chkJavascript
            // 
            chkJavascript.AutoSize = true;
            chkJavascript.Location = new Point(9, 74);
            chkJavascript.Name = "chkJavascript";
            chkJavascript.Size = new Size(78, 19);
            chkJavascript.TabIndex = 2;
            chkJavascript.Text = "JavaScript";
            chkJavascript.UseVisualStyleBackColor = true;
            // 
            // chkCpp
            // 
            chkCpp.AutoSize = true;
            chkCpp.Location = new Point(9, 49);
            chkCpp.Name = "chkCpp";
            chkCpp.Size = new Size(50, 19);
            chkCpp.TabIndex = 1;
            chkCpp.Text = "C++";
            chkCpp.UseVisualStyleBackColor = true;
            // 
            // chkCsharp
            // 
            chkCsharp.AutoSize = true;
            chkCsharp.Location = new Point(9, 24);
            chkCsharp.Name = "chkCsharp";
            chkCsharp.Size = new Size(41, 19);
            chkCsharp.TabIndex = 0;
            chkCsharp.Text = "C#";
            chkCsharp.UseVisualStyleBackColor = true;
            // 
            // lstPaises
            // 
            lstPaises.FormattingEnabled = true;
            lstPaises.ItemHeight = 15;
            lstPaises.Items.AddRange(new object[] { "Argentina\t", "Chile ", "Uruguay" });
            lstPaises.Location = new Point(36, 252);
            lstPaises.Name = "lstPaises";
            lstPaises.Size = new Size(249, 94);
            lstPaises.TabIndex = 3;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(36, 234);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 4;
            lblPais.Text = "País";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(353, 337);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(100, 28);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 400);
            Controls.Add(btnIngresar);
            Controls.Add(lblPais);
            Controls.Add(lstPaises);
            Controls.Add(grpCursos);
            Controls.Add(grpGenero);
            Controls.Add(grpUsuario);
            Name = "FormRegistro";
            Text = "Registro";
            Load += Form1_Load;
            grpUsuario.ResumeLayout(false);
            grpUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            grpGenero.ResumeLayout(false);
            grpGenero.PerformLayout();
            grpCursos.ResumeLayout(false);
            grpCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpUsuario;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private NumericUpDown nudEdad;
        private Label lblNombre;
        private Label lblDireccion;
        private Label lblEdad;
        private GroupBox grpGenero;
        private RadioButton rdoNoBinario;
        private RadioButton rdoMasculino;
        private RadioButton rdoFemenino;
        private GroupBox grpCursos;
        private CheckBox chkJavascript;
        private CheckBox chkCpp;
        private CheckBox chkCsharp;
        private ListBox lstPaises;
        private Label lblPais;
        private Button btnIngresar;
    }
}