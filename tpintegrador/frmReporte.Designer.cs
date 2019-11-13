namespace tpintegrador
{
    partial class frmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportClientes1 = new tpintegrador.reportClientes();
            this.txtFiltroApellido = new System.Windows.Forms.TextBox();
            this.txtFiltroDni = new System.Windows.Forms.TextBox();
            this.chkNombre = new System.Windows.Forms.CheckBox();
            this.chkApellido = new System.Windows.Forms.CheckBox();
            this.chkDni = new System.Windows.Forms.CheckBox();
            this.chkId = new System.Windows.Forms.CheckBox();
            this.txtFiltroId = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1036, 28);
            this.panel4.TabIndex = 28;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(977, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1010, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.Silver;
            this.btnFiltro.FlatAppearance.BorderSize = 0;
            this.btnFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnFiltro.Location = new System.Drawing.Point(824, 80);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(180, 29);
            this.btnFiltro.TabIndex = 9;
            this.btnFiltro.Text = "Aplicar filtro";
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click_1);
            // 
            // btnTodo
            // 
            this.btnTodo.BackColor = System.Drawing.Color.Silver;
            this.btnTodo.FlatAppearance.BorderSize = 0;
            this.btnTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnTodo.Location = new System.Drawing.Point(14, 80);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(180, 29);
            this.btnTodo.TabIndex = 0;
            this.btnTodo.Text = "Mostrar todos";
            this.btnTodo.UseVisualStyleBackColor = false;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(586, 69);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(203, 20);
            this.txtFiltroNombre.TabIndex = 6;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(14, 166);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(990, 542);
            this.crystalReportViewer1.TabIndex = 33;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txtFiltroApellido
            // 
            this.txtFiltroApellido.Location = new System.Drawing.Point(586, 99);
            this.txtFiltroApellido.Name = "txtFiltroApellido";
            this.txtFiltroApellido.Size = new System.Drawing.Size(203, 20);
            this.txtFiltroApellido.TabIndex = 8;
            // 
            // txtFiltroDni
            // 
            this.txtFiltroDni.Location = new System.Drawing.Point(279, 99);
            this.txtFiltroDni.Name = "txtFiltroDni";
            this.txtFiltroDni.Size = new System.Drawing.Size(203, 20);
            this.txtFiltroDni.TabIndex = 4;
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkNombre.Location = new System.Drawing.Point(494, 67);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(87, 22);
            this.chkNombre.TabIndex = 5;
            this.chkNombre.Text = "Nombre";
            this.chkNombre.UseVisualStyleBackColor = true;
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkNombre_CheckedChanged);
            // 
            // chkApellido
            // 
            this.chkApellido.AutoSize = true;
            this.chkApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkApellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkApellido.Location = new System.Drawing.Point(494, 99);
            this.chkApellido.Name = "chkApellido";
            this.chkApellido.Size = new System.Drawing.Size(86, 22);
            this.chkApellido.TabIndex = 7;
            this.chkApellido.Text = "Apellido";
            this.chkApellido.UseVisualStyleBackColor = true;
            this.chkApellido.CheckedChanged += new System.EventHandler(this.chkApellido_CheckedChanged);
            // 
            // chkDni
            // 
            this.chkDni.AutoSize = true;
            this.chkDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkDni.Location = new System.Drawing.Point(224, 99);
            this.chkDni.Name = "chkDni";
            this.chkDni.Size = new System.Drawing.Size(55, 22);
            this.chkDni.TabIndex = 3;
            this.chkDni.Text = "DNI";
            this.chkDni.UseVisualStyleBackColor = true;
            this.chkDni.CheckedChanged += new System.EventHandler(this.chkDni_CheckedChanged);
            // 
            // chkId
            // 
            this.chkId.AutoSize = true;
            this.chkId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkId.Location = new System.Drawing.Point(225, 67);
            this.chkId.Name = "chkId";
            this.chkId.Size = new System.Drawing.Size(43, 22);
            this.chkId.TabIndex = 1;
            this.chkId.Text = "ID";
            this.chkId.UseVisualStyleBackColor = true;
            this.chkId.CheckedChanged += new System.EventHandler(this.chkId_CheckedChanged);
            // 
            // txtFiltroId
            // 
            this.txtFiltroId.Location = new System.Drawing.Point(279, 69);
            this.txtFiltroId.Name = "txtFiltroId";
            this.txtFiltroId.Size = new System.Drawing.Size(203, 20);
            this.txtFiltroId.TabIndex = 2;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1036, 720);
            this.Controls.Add(this.chkId);
            this.Controls.Add(this.txtFiltroId);
            this.Controls.Add(this.chkDni);
            this.Controls.Add(this.chkApellido);
            this.Controls.Add(this.chkNombre);
            this.Controls.Add(this.txtFiltroDni);
            this.Controls.Add(this.txtFiltroApellido);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.txtFiltroNombre);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporte";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private reportClientes reportClientes1;
        private System.Windows.Forms.TextBox txtFiltroApellido;
        private System.Windows.Forms.TextBox txtFiltroDni;
        private System.Windows.Forms.CheckBox chkNombre;
        private System.Windows.Forms.CheckBox chkApellido;
        private System.Windows.Forms.CheckBox chkDni;
        private System.Windows.Forms.CheckBox chkId;
        private System.Windows.Forms.TextBox txtFiltroId;
    }
}