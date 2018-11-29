namespace Solicitudes
{
    partial class frm_CintasNegras
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gradoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parciales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_ExamenAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_GradoActual = new System.Windows.Forms.ComboBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.mtb_f_nacimiento = new System.Windows.Forms.MaskedTextBox();
            this.txt_Ocupacion = new System.Windows.Forms.TextBox();
            this.mtb_f_ExamenAnterior = new System.Windows.Forms.MaskedTextBox();
            this.mtb_fIngreso = new System.Windows.Forms.MaskedTextBox();
            this.txt_Comentarios = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nud_Parciales = new System.Windows.Forms.NumericUpDown();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Solicitudes.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Parciales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gradoActual,
            this.parciales,
            this.nombre,
            this.f_Nacimiento,
            this.Edad,
            this.Ocupacion,
            this.f_ExamenAnterior,
            this.f_Ingreso,
            this.Comentarios});
            this.dataGridView1.Location = new System.Drawing.Point(202, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(726, 420);
            this.dataGridView1.TabIndex = 0;
            // 
            // gradoActual
            // 
            this.gradoActual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gradoActual.HeaderText = "Grado Actual";
            this.gradoActual.Name = "gradoActual";
            this.gradoActual.Width = 94;
            // 
            // parciales
            // 
            this.parciales.HeaderText = "No. Parciales";
            this.parciales.Name = "parciales";
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 69;
            // 
            // f_Nacimiento
            // 
            this.f_Nacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.f_Nacimiento.HeaderText = "F. Nacimiento";
            this.f_Nacimiento.Name = "f_Nacimiento";
            this.f_Nacimiento.Width = 97;
            // 
            // Edad
            // 
            this.Edad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.Width = 57;
            // 
            // Ocupacion
            // 
            this.Ocupacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ocupacion.HeaderText = "Ocupacion";
            this.Ocupacion.Name = "Ocupacion";
            this.Ocupacion.Width = 84;
            // 
            // f_ExamenAnterior
            // 
            this.f_ExamenAnterior.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.f_ExamenAnterior.HeaderText = "F. Ex. Anterior";
            this.f_ExamenAnterior.Name = "f_ExamenAnterior";
            this.f_ExamenAnterior.Width = 98;
            // 
            // f_Ingreso
            // 
            this.f_Ingreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.f_Ingreso.HeaderText = "F. Ingreso";
            this.f_Ingreso.Name = "f_Ingreso";
            this.f_Ingreso.Width = 79;
            // 
            // Comentarios
            // 
            this.Comentarios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Comentarios.HeaderText = "Comentarios";
            this.Comentarios.Name = "Comentarios";
            this.Comentarios.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grado Actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ocupacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha Examen Anterior:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de Ingreso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Comentarios:";
            // 
            // cb_GradoActual
            // 
            this.cb_GradoActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_GradoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_GradoActual.FormattingEnabled = true;
            this.cb_GradoActual.Items.AddRange(new object[] {
            "IEBY DAN/POOM",
            "1° DAN/POOM",
            "2° DAN/POOM",
            "3º DAN/POOM",
            "4º DAN/POOM",
            "5º DAN/POOM",
            "6º DAN/POOM",
            "7º DAN/POOM"});
            this.cb_GradoActual.Location = new System.Drawing.Point(6, 36);
            this.cb_GradoActual.Name = "cb_GradoActual";
            this.cb_GradoActual.Size = new System.Drawing.Size(184, 24);
            this.cb_GradoActual.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(6, 126);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(184, 22);
            this.txt_nombre.TabIndex = 3;
            // 
            // mtb_f_nacimiento
            // 
            this.mtb_f_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_f_nacimiento.Location = new System.Drawing.Point(6, 170);
            this.mtb_f_nacimiento.Mask = "00/00/0000";
            this.mtb_f_nacimiento.Name = "mtb_f_nacimiento";
            this.mtb_f_nacimiento.Size = new System.Drawing.Size(184, 22);
            this.mtb_f_nacimiento.TabIndex = 4;
            this.mtb_f_nacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Ocupacion
            // 
            this.txt_Ocupacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Ocupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ocupacion.Location = new System.Drawing.Point(6, 214);
            this.txt_Ocupacion.Name = "txt_Ocupacion";
            this.txt_Ocupacion.Size = new System.Drawing.Size(184, 22);
            this.txt_Ocupacion.TabIndex = 5;
            // 
            // mtb_f_ExamenAnterior
            // 
            this.mtb_f_ExamenAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_f_ExamenAnterior.Location = new System.Drawing.Point(6, 258);
            this.mtb_f_ExamenAnterior.Mask = "00/00/0000";
            this.mtb_f_ExamenAnterior.Name = "mtb_f_ExamenAnterior";
            this.mtb_f_ExamenAnterior.Size = new System.Drawing.Size(184, 22);
            this.mtb_f_ExamenAnterior.TabIndex = 6;
            this.mtb_f_ExamenAnterior.ValidatingType = typeof(System.DateTime);
            // 
            // mtb_fIngreso
            // 
            this.mtb_fIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_fIngreso.Location = new System.Drawing.Point(6, 302);
            this.mtb_fIngreso.Mask = "00/00/0000";
            this.mtb_fIngreso.Name = "mtb_fIngreso";
            this.mtb_fIngreso.Size = new System.Drawing.Size(184, 22);
            this.mtb_fIngreso.TabIndex = 7;
            this.mtb_fIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Comentarios
            // 
            this.txt_Comentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Comentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Comentarios.Location = new System.Drawing.Point(6, 346);
            this.txt_Comentarios.MaxLength = 50;
            this.txt_Comentarios.Multiline = true;
            this.txt_Comentarios.Name = "txt_Comentarios";
            this.txt_Comentarios.Size = new System.Drawing.Size(184, 86);
            this.txt_Comentarios.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(104, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Print 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(702, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 38);
            this.button3.TabIndex = 17;
            this.button3.Text = "Imprimir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "No. Parciales Aprobados:";
            // 
            // nud_Parciales
            // 
            this.nud_Parciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Parciales.Location = new System.Drawing.Point(6, 82);
            this.nud_Parciales.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Parciales.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Parciales.Name = "nud_Parciales";
            this.nud_Parciales.Size = new System.Drawing.Size(181, 22);
            this.nud_Parciales.TabIndex = 2;
            this.nud_Parciales.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frm_CintasNegras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 489);
            this.Controls.Add(this.nud_Parciales);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Comentarios);
            this.Controls.Add(this.mtb_fIngreso);
            this.Controls.Add(this.mtb_f_ExamenAnterior);
            this.Controls.Add(this.txt_Ocupacion);
            this.Controls.Add(this.mtb_f_nacimiento);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.cb_GradoActual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_CintasNegras";
            this.Text = "Solicitudes Cintas Negras";
            this.Load += new System.EventHandler(this.frm_CintasNegras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Parciales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_GradoActual;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.MaskedTextBox mtb_f_nacimiento;
        private System.Windows.Forms.TextBox txt_Ocupacion;
        private System.Windows.Forms.MaskedTextBox mtb_f_ExamenAnterior;
        private System.Windows.Forms.MaskedTextBox mtb_fIngreso;
        private System.Windows.Forms.TextBox txt_Comentarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nud_Parciales;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn parciales;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_ExamenAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentarios;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}