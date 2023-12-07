namespace Formulario
{
    partial class FrmCartelera
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
            pnlCartel = new Panel();
            lblMensaje = new Label();
            lblTitulo = new Label();
            dialogFuente = new FontDialog();
            colorDialog = new ColorDialog();
            lblMenu = new Label();
            grpContenido = new GroupBox();
            lblTxtMensaje = new Label();
            rtxtMensaje = new RichTextBox();
            txtTitulo = new TextBox();
            lblTxtTitulo = new Label();
            btnColorPanel = new Button();
            btnGuardarConfiguracion = new Button();
            btnImportarConfiguracion = new Button();
            btnColorTitulo = new Button();
            btnColorMensaje = new Button();
            btnEliminarConfiguracion = new Button();
            pnlCartel.SuspendLayout();
            grpContenido.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCartel
            // 
            pnlCartel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCartel.Controls.Add(lblMensaje);
            pnlCartel.Controls.Add(lblTitulo);
            pnlCartel.Location = new Point(354, 12);
            pnlCartel.Name = "pnlCartel";
            pnlCartel.Size = new Size(621, 439);
            pnlCartel.TabIndex = 3;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.Location = new Point(26, 103);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(104, 32);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "Mensaje";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(15, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(161, 65);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.Location = new Point(13, 13);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(265, 25);
            lblMenu.TabIndex = 4;
            lblMenu.Text = "Opciones de personalización";
            // 
            // grpContenido
            // 
            grpContenido.Controls.Add(lblTxtMensaje);
            grpContenido.Controls.Add(rtxtMensaje);
            grpContenido.Controls.Add(txtTitulo);
            grpContenido.Controls.Add(lblTxtTitulo);
            grpContenido.Location = new Point(13, 50);
            grpContenido.Name = "grpContenido";
            grpContenido.Size = new Size(335, 210);
            grpContenido.TabIndex = 5;
            grpContenido.TabStop = false;
            grpContenido.Text = "Contenido";
            // 
            // lblTxtMensaje
            // 
            lblTxtMensaje.AutoSize = true;
            lblTxtMensaje.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTxtMensaje.Location = new Point(7, 82);
            lblTxtMensaje.Name = "lblTxtMensaje";
            lblTxtMensaje.Size = new Size(53, 15);
            lblTxtMensaje.TabIndex = 3;
            lblTxtMensaje.Text = "Mensaje";
            // 
            // rtxtMensaje
            // 
            rtxtMensaje.Location = new Point(7, 100);
            rtxtMensaje.Name = "rtxtMensaje";
            rtxtMensaje.Size = new Size(322, 96);
            rtxtMensaje.TabIndex = 2;
            rtxtMensaje.Text = "Mensaje";
            rtxtMensaje.TextChanged += txtMensaje_TextChanged;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(7, 42);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Ingrese el título";
            txtTitulo.Size = new Size(322, 23);
            txtTitulo.TabIndex = 1;
            txtTitulo.Text = "Título";
            txtTitulo.TextChanged += txtTitulo_TextChanged;
            // 
            // lblTxtTitulo
            // 
            lblTxtTitulo.AutoSize = true;
            lblTxtTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTxtTitulo.Location = new Point(7, 23);
            lblTxtTitulo.Name = "lblTxtTitulo";
            lblTxtTitulo.Size = new Size(39, 15);
            lblTxtTitulo.TabIndex = 0;
            lblTxtTitulo.Text = "Título";
            // 
            // btnColorPanel
            // 
            btnColorPanel.Location = new Point(13, 302);
            btnColorPanel.Name = "btnColorPanel";
            btnColorPanel.Size = new Size(335, 30);
            btnColorPanel.TabIndex = 5;
            btnColorPanel.Text = "Elegir color de fondo del panel";
            btnColorPanel.UseVisualStyleBackColor = true;
            btnColorPanel.Click += btnColorPanel_Click;
            // 
            // btnGuardarConfiguracion
            // 
            btnGuardarConfiguracion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuardarConfiguracion.BackColor = Color.SteelBlue;
            btnGuardarConfiguracion.FlatAppearance.BorderColor = Color.SteelBlue;
            btnGuardarConfiguracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarConfiguracion.ForeColor = SystemColors.ControlLightLight;
            btnGuardarConfiguracion.Location = new Point(13, 373);
            btnGuardarConfiguracion.Name = "btnGuardarConfiguracion";
            btnGuardarConfiguracion.Size = new Size(329, 36);
            btnGuardarConfiguracion.TabIndex = 6;
            btnGuardarConfiguracion.Text = "Guardar configuración";
            btnGuardarConfiguracion.UseVisualStyleBackColor = false;
            btnGuardarConfiguracion.Click += btnGuardarConfiguracion_Click;
            // 
            // btnImportarConfiguracion
            // 
            btnImportarConfiguracion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnImportarConfiguracion.BackColor = Color.DarkGray;
            btnImportarConfiguracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImportarConfiguracion.ForeColor = SystemColors.ControlLightLight;
            btnImportarConfiguracion.Location = new Point(13, 415);
            btnImportarConfiguracion.Name = "btnImportarConfiguracion";
            btnImportarConfiguracion.Size = new Size(162, 36);
            btnImportarConfiguracion.TabIndex = 7;
            btnImportarConfiguracion.Text = "Importar configuración";
            btnImportarConfiguracion.UseVisualStyleBackColor = false;
            btnImportarConfiguracion.Click += btnImportarConfiguracion_Click;
            // 
            // btnColorTitulo
            // 
            btnColorTitulo.Location = new Point(13, 266);
            btnColorTitulo.Name = "btnColorTitulo";
            btnColorTitulo.Size = new Size(162, 30);
            btnColorTitulo.TabIndex = 3;
            btnColorTitulo.Text = "Configurar color título";
            btnColorTitulo.UseVisualStyleBackColor = true;
            btnColorTitulo.Click += btnColorTitulo_Click;
            // 
            // btnColorMensaje
            // 
            btnColorMensaje.Location = new Point(186, 266);
            btnColorMensaje.Name = "btnColorMensaje";
            btnColorMensaje.Size = new Size(162, 30);
            btnColorMensaje.TabIndex = 4;
            btnColorMensaje.Text = "Configurar color mensaje";
            btnColorMensaje.UseVisualStyleBackColor = true;
            btnColorMensaje.Click += btnColorMensaje_Click;
            // 
            // btnEliminarConfiguracion
            // 
            btnEliminarConfiguracion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminarConfiguracion.BackColor = Color.IndianRed;
            btnEliminarConfiguracion.FlatAppearance.BorderColor = Color.Firebrick;
            btnEliminarConfiguracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarConfiguracion.ForeColor = SystemColors.ControlLightLight;
            btnEliminarConfiguracion.Location = new Point(180, 415);
            btnEliminarConfiguracion.Name = "btnEliminarConfiguracion";
            btnEliminarConfiguracion.Size = new Size(162, 36);
            btnEliminarConfiguracion.TabIndex = 8;
            btnEliminarConfiguracion.Text = "Eliminar configuración";
            btnEliminarConfiguracion.UseVisualStyleBackColor = false;
            btnEliminarConfiguracion.Click += btnEliminarConfiguracion_Click;
            // 
            // FrmCartelera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 463);
            Controls.Add(btnEliminarConfiguracion);
            Controls.Add(btnColorMensaje);
            Controls.Add(btnColorTitulo);
            Controls.Add(btnImportarConfiguracion);
            Controls.Add(btnGuardarConfiguracion);
            Controls.Add(btnColorPanel);
            Controls.Add(grpContenido);
            Controls.Add(lblMenu);
            Controls.Add(pnlCartel);
            MinimumSize = new Size(989, 502);
            Name = "FrmCartelera";
            Text = "Cartelera";
            Load += FrmCartelera_Load;
            pnlCartel.ResumeLayout(false);
            pnlCartel.PerformLayout();
            grpContenido.ResumeLayout(false);
            grpContenido.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlCartel;
        private FontDialog dialogFuente;
        private ColorDialog colorDialog;
        private Label lblMenu;
        private GroupBox grpContenido;
        private Label lblTxtMensaje;
        private RichTextBox rtxtMensaje;
        private TextBox txtTitulo;
        private Label lblTxtTitulo;
        private Button btnColorPanel;
        private Button btnGuardarConfiguracion;
        private Button btnImportarConfiguracion;
        private Label lblMensaje;
        private Label lblTitulo;
        private Button btnColorTitulo;
        private Button btnColorMensaje;
        private Button btnEliminarConfiguracion;
    }
}