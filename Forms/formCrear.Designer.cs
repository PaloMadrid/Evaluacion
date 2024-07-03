namespace FormulariosComputadoras
{
    partial class formCrear
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
            grb_hardware = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbx_procesadores = new ComboBox();
            num_disco = new NumericUpDown();
            num_ram = new NumericUpDown();
            grb_SO = new GroupBox();
            rb_macos = new RadioButton();
            rb_linux = new RadioButton();
            rb_windows = new RadioButton();
            grb_programas = new GroupBox();
            cb_dropbox = new CheckBox();
            cb_avast = new CheckBox();
            cb_winrar = new CheckBox();
            cb_reader = new CheckBox();
            cb_office = new CheckBox();
            btn_cancelar = new Button();
            btn_agregar = new Button();
            grb_hardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_disco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_ram).BeginInit();
            grb_SO.SuspendLayout();
            grb_programas.SuspendLayout();
            SuspendLayout();
            // 
            // grb_hardware
            // 
            grb_hardware.Controls.Add(label3);
            grb_hardware.Controls.Add(label2);
            grb_hardware.Controls.Add(label1);
            grb_hardware.Controls.Add(cmbx_procesadores);
            grb_hardware.Controls.Add(num_disco);
            grb_hardware.Controls.Add(num_ram);
            grb_hardware.Location = new Point(56, 37);
            grb_hardware.Name = "grb_hardware";
            grb_hardware.Size = new Size(356, 209);
            grb_hardware.TabIndex = 0;
            grb_hardware.TabStop = false;
            grb_hardware.Text = "Hardware";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 132);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Disco";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 92);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 4;
            label2.Text = "Memoria Ram";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 52);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 4;
            label1.Text = "Procesador";
            label1.Click += label1_Click;
            // 
            // cmbx_procesadores
            // 
            cmbx_procesadores.FormattingEnabled = true;
            cmbx_procesadores.Location = new Point(176, 49);
            cmbx_procesadores.Name = "cmbx_procesadores";
            cmbx_procesadores.Size = new Size(121, 23);
            cmbx_procesadores.TabIndex = 3;
            // 
            // num_disco
            // 
            num_disco.Location = new Point(176, 132);
            num_disco.Name = "num_disco";
            num_disco.Size = new Size(120, 23);
            num_disco.TabIndex = 2;
            // 
            // num_ram
            // 
            num_ram.Location = new Point(176, 90);
            num_ram.Name = "num_ram";
            num_ram.Size = new Size(120, 23);
            num_ram.TabIndex = 1;
            // 
            // grb_SO
            // 
            grb_SO.Controls.Add(rb_macos);
            grb_SO.Controls.Add(rb_linux);
            grb_SO.Controls.Add(rb_windows);
            grb_SO.Location = new Point(511, 37);
            grb_SO.Name = "grb_SO";
            grb_SO.Size = new Size(200, 110);
            grb_SO.TabIndex = 0;
            grb_SO.TabStop = false;
            grb_SO.Text = "Sistema Operativo";
            // 
            // rb_macos
            // 
            rb_macos.AutoSize = true;
            rb_macos.Location = new Point(31, 77);
            rb_macos.Name = "rb_macos";
            rb_macos.Size = new Size(63, 19);
            rb_macos.TabIndex = 2;
            rb_macos.TabStop = true;
            rb_macos.Text = "MacOS";
            rb_macos.UseVisualStyleBackColor = true;
            // 
            // rb_linux
            // 
            rb_linux.AutoSize = true;
            rb_linux.Location = new Point(31, 52);
            rb_linux.Name = "rb_linux";
            rb_linux.Size = new Size(54, 19);
            rb_linux.TabIndex = 1;
            rb_linux.TabStop = true;
            rb_linux.Text = "Linux";
            rb_linux.UseVisualStyleBackColor = true;
            // 
            // rb_windows
            // 
            rb_windows.AutoSize = true;
            rb_windows.Location = new Point(31, 27);
            rb_windows.Name = "rb_windows";
            rb_windows.Size = new Size(74, 19);
            rb_windows.TabIndex = 0;
            rb_windows.TabStop = true;
            rb_windows.Text = "Windows";
            rb_windows.UseVisualStyleBackColor = true;
            // 
            // grb_programas
            // 
            grb_programas.Controls.Add(cb_dropbox);
            grb_programas.Controls.Add(cb_avast);
            grb_programas.Controls.Add(cb_winrar);
            grb_programas.Controls.Add(cb_reader);
            grb_programas.Controls.Add(cb_office);
            grb_programas.Location = new Point(511, 166);
            grb_programas.Name = "grb_programas";
            grb_programas.Size = new Size(200, 173);
            grb_programas.TabIndex = 0;
            grb_programas.TabStop = false;
            grb_programas.Text = "Programas";
            // 
            // cb_dropbox
            // 
            cb_dropbox.AutoSize = true;
            cb_dropbox.Location = new Point(52, 110);
            cb_dropbox.Name = "cb_dropbox";
            cb_dropbox.Size = new Size(72, 19);
            cb_dropbox.TabIndex = 4;
            cb_dropbox.Text = "DropBox";
            cb_dropbox.UseVisualStyleBackColor = true;
            // 
            // cb_avast
            // 
            cb_avast.AutoSize = true;
            cb_avast.Location = new Point(52, 135);
            cb_avast.Name = "cb_avast";
            cb_avast.Size = new Size(55, 19);
            cb_avast.TabIndex = 3;
            cb_avast.Text = "Avast";
            cb_avast.UseVisualStyleBackColor = true;
            // 
            // cb_winrar
            // 
            cb_winrar.AutoSize = true;
            cb_winrar.Location = new Point(52, 85);
            cb_winrar.Name = "cb_winrar";
            cb_winrar.Size = new Size(61, 19);
            cb_winrar.TabIndex = 2;
            cb_winrar.Text = "Winrar";
            cb_winrar.UseVisualStyleBackColor = true;
            // 
            // cb_reader
            // 
            cb_reader.AutoSize = true;
            cb_reader.Location = new Point(52, 60);
            cb_reader.Name = "cb_reader";
            cb_reader.Size = new Size(100, 19);
            cb_reader.TabIndex = 1;
            cb_reader.Text = "Adobe Reader";
            cb_reader.UseVisualStyleBackColor = true;
            // 
            // cb_office
            // 
            cb_office.AutoSize = true;
            cb_office.Location = new Point(52, 35);
            cb_office.Name = "cb_office";
            cb_office.Size = new Size(58, 19);
            cb_office.TabIndex = 0;
            cb_office.Text = "Office";
            cb_office.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(135, 297);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(257, 297);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 6;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // formCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 368);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_agregar);
            Controls.Add(grb_SO);
            Controls.Add(grb_programas);
            Controls.Add(grb_hardware);
            Name = "formCrear";
            Text = "formCrear";
            Load += formCrear_Load;
            grb_hardware.ResumeLayout(false);
            grb_hardware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_disco).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_ram).EndInit();
            grb_SO.ResumeLayout(false);
            grb_SO.PerformLayout();
            grb_programas.ResumeLayout(false);
            grb_programas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_hardware;
        private GroupBox grb_SO;
        private GroupBox grb_programas;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbx_procesadores;
        private NumericUpDown num_disco;
        private NumericUpDown num_ram;
        private RadioButton rb_macos;
        private RadioButton rb_linux;
        private RadioButton rb_windows;
        private CheckBox cb_dropbox;
        private CheckBox cb_avast;
        private CheckBox cb_winrar;
        private CheckBox cb_reader;
        private CheckBox cb_office;
        private Button btn_cancelar;
        private Button btn_agregar;
    }
}