namespace Formularios
{
    partial class FrmListaSuper
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
            components = new System.ComponentModel.Container();
            lstObjetos = new ListBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            toolTipAgregar = new ToolTip(components);
            toolTipEliminar = new ToolTip(components);
            toolTipModificar = new ToolTip(components);
            SuspendLayout();
            // 
            // lstObjetos
            // 
            lstObjetos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstObjetos.FormattingEnabled = true;
            lstObjetos.ItemHeight = 15;
            lstObjetos.Location = new Point(12, 12);
            lstObjetos.Name = "lstObjetos";
            lstObjetos.Size = new Size(306, 439);
            lstObjetos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Location = new Point(333, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(51, 50);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Location = new Point(334, 68);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(51, 50);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "-";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificar.Location = new Point(334, 124);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(51, 50);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "M";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FrmListaSuper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 468);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lstObjetos);
            Name = "FrmListaSuper";
            Text = "FrmListaSuper";
            Load += FrmListaSuper_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstObjetos;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private ToolTip toolTipAgregar;
        private ToolTip toolTipEliminar;
        private ToolTip toolTipModificar;
    }
}