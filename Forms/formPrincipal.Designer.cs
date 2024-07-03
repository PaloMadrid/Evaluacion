namespace Forms
{
    partial class formPrincipal
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
            dtg_informacion = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_informacion).BeginInit();
            SuspendLayout();
            // 
            // dtg_informacion
            // 
            dtg_informacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_informacion.Location = new Point(34, 30);
            dtg_informacion.Name = "dtg_informacion";
            dtg_informacion.Size = new Size(719, 367);
            dtg_informacion.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(357, 415);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // formPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_agregar);
            Controls.Add(dtg_informacion);
            Name = "formPrincipal";
            Text = "formPrincipal";
            Load += formPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_informacion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_informacion;
        private Button btn_agregar;
    }
}