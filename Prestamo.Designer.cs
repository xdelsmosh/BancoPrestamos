namespace BancoPrestamos
{
    partial class Prestamo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamo));
            this.Saludo = new System.Windows.Forms.Label();
            this.confirmar = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Datos = new System.Windows.Forms.Panel();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.rut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Detalles = new System.Windows.Forms.Panel();
            this.cuotabox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dinero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Datos.SuspendLayout();
            this.Detalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Saludo
            // 
            this.Saludo.AutoSize = true;
            this.Saludo.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saludo.Location = new System.Drawing.Point(110, 43);
            this.Saludo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(130, 19);
            this.Saludo.TabIndex = 0;
            this.Saludo.Text = "Bienvenido,";
            this.Saludo.Click += new System.EventHandler(this.label1_Click);
            // 
            // confirmar
            // 
            this.confirmar.BackColor = System.Drawing.Color.Indigo;
            this.confirmar.ForeColor = System.Drawing.Color.Violet;
            this.confirmar.Location = new System.Drawing.Point(355, 360);
            this.confirmar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(117, 58);
            this.confirmar.TabIndex = 1;
            this.confirmar.Text = "CONFIRMAR SOLICITUD";
            this.confirmar.UseVisualStyleBackColor = false;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // volver
            // 
            this.volver.BackColor = System.Drawing.Color.Red;
            this.volver.Location = new System.Drawing.Point(700, 388);
            this.volver.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(101, 30);
            this.volver.TabIndex = 2;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = false;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos Personales:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(537, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalles del Préstamo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.Orange;
            this.Datos.Controls.Add(this.sexo);
            this.Datos.Controls.Add(this.rut);
            this.Datos.Controls.Add(this.label5);
            this.Datos.Controls.Add(this.label3);
            this.Datos.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(42, 150);
            this.Datos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(336, 180);
            this.Datos.TabIndex = 5;
            this.Datos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sexo
            // 
            this.sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexo.FormattingEnabled = true;
            this.sexo.Location = new System.Drawing.Point(152, 35);
            this.sexo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(159, 21);
            this.sexo.TabIndex = 4;
            this.sexo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rut
            // 
            this.rut.Location = new System.Drawing.Point(152, 118);
            this.rut.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rut.MaxLength = 9;
            this.rut.Name = "rut";
            this.rut.Size = new System.Drawing.Size(159, 20);
            this.rut.TabIndex = 3;
            this.rut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rut_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Rut(sin guion)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SEXO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Detalles
            // 
            this.Detalles.BackColor = System.Drawing.Color.Orange;
            this.Detalles.Controls.Add(this.cuotabox);
            this.Detalles.Controls.Add(this.label6);
            this.Detalles.Controls.Add(this.dinero);
            this.Detalles.Controls.Add(this.label4);
            this.Detalles.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detalles.Location = new System.Drawing.Point(454, 150);
            this.Detalles.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Detalles.Name = "Detalles";
            this.Detalles.Size = new System.Drawing.Size(336, 180);
            this.Detalles.TabIndex = 6;
            this.Detalles.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cuotabox
            // 
            this.cuotabox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuotabox.FormattingEnabled = true;
            this.cuotabox.Location = new System.Drawing.Point(142, 100);
            this.cuotabox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cuotabox.Name = "cuotabox";
            this.cuotabox.Size = new System.Drawing.Size(159, 24);
            this.cuotabox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cuotas";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dinero
            // 
            this.dinero.Location = new System.Drawing.Point(142, 31);
            this.dinero.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dinero.Name = "dinero";
            this.dinero.Size = new System.Drawing.Size(159, 21);
            this.dinero.TabIndex = 2;
            this.dinero.TextChanged += new System.EventHandler(this.dinero_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Monto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.Detalles);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.Saludo);
            this.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Prestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pestaña Préstamo";
            this.Load += new System.EventHandler(this.Prestamo_Load);
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.Detalles.ResumeLayout(false);
            this.Detalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Saludo;
        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Datos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Detalles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.TextBox rut;
        private System.Windows.Forms.ComboBox cuotabox;
        private System.Windows.Forms.TextBox dinero;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}