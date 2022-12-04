namespace EstadoCuentas
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(47)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 82);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(95)))), ((int)(((byte)(205)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(843, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 30);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(95)))), ((int)(((byte)(205)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(797, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 30);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Text = "__";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(47)))), ((int)(((byte)(102)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 534);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 50);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 88);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(361, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estados de Cuenta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.DGVDatos);
            this.panel4.Controls.Add(this.txt_Id);
            this.panel4.Controls.Add(this.btn_Mostrar);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(88, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(720, 352);
            this.panel4.TabIndex = 3;
            // 
            // DGVDatos
            // 
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Location = new System.Drawing.Point(-2, 164);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.RowTemplate.Height = 25;
            this.DGVDatos.Size = new System.Drawing.Size(715, 181);
            this.DGVDatos.TabIndex = 3;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(298, 65);
            this.txt_Id.MaxLength = 10;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(173, 23);
            this.txt_Id.TabIndex = 2;
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Mostrar.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Mostrar.ForeColor = System.Drawing.Color.White;
            this.btn_Mostrar.Location = new System.Drawing.Point(339, 94);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(87, 40);
            this.btn_Mostrar.TabIndex = 1;
            this.btn_Mostrar.Text = "Buscar";
            this.btn_Mostrar.UseVisualStyleBackColor = false;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(235, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese el Numero de Matricula";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 584);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox txt_Id;
        private Button btn_Mostrar;
        private Label label2;
        private Label label4;
        private Button btnCerrar;
        private Button btnMinimizar;
        private DataGridView DGVDatos;
    }
}