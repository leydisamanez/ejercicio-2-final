namespace ejercicio_2
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpuntuacion = new System.Windows.Forms.TextBox();
            this.Sumatoria = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtubicacion = new System.Windows.Forms.TextBox();
            this.btnlista = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProds = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpierde = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtgana = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 63);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Controls.Add(this.txtpuntuacion);
            this.groupBox1.Controls.Add(this.Sumatoria);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtubicacion);
            this.groupBox1.Controls.Add(this.btnlista);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvProds);
            this.groupBox1.Controls.Add(this.txtpierde);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtgana);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 475);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtpuntuacion
            // 
            this.txtpuntuacion.Location = new System.Drawing.Point(626, 380);
            this.txtpuntuacion.Name = "txtpuntuacion";
            this.txtpuntuacion.Size = new System.Drawing.Size(100, 23);
            this.txtpuntuacion.TabIndex = 16;
            // 
            // Sumatoria
            // 
            this.Sumatoria.AutoSize = true;
            this.Sumatoria.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sumatoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sumatoria.Location = new System.Drawing.Point(613, 346);
            this.Sumatoria.Name = "Sumatoria";
            this.Sumatoria.Size = new System.Drawing.Size(134, 20);
            this.Sumatoria.TabIndex = 15;
            this.Sumatoria.Text = "Sumatoria Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(303, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 145);
            this.label5.TabIndex = 14;
            this.label5.Text = "Informacion del puntaje:\r\nPor cada partida ganada \r\nseran 100 puntos,\r\n por cada " +
    "partida perdida\r\n seran - 20 puntos.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ubicacion del archivo:";
            // 
            // txtubicacion
            // 
            this.txtubicacion.Location = new System.Drawing.Point(36, 313);
            this.txtubicacion.Name = "txtubicacion";
            this.txtubicacion.Size = new System.Drawing.Size(197, 23);
            this.txtubicacion.TabIndex = 0;
            // 
            // btnlista
            // 
            this.btnlista.Location = new System.Drawing.Point(146, 362);
            this.btnlista.Name = "btnlista";
            this.btnlista.Size = new System.Drawing.Size(75, 23);
            this.btnlista.TabIndex = 12;
            this.btnlista.Text = "Ver lista";
            this.btnlista.UseVisualStyleBackColor = true;
            this.btnlista.Click += new System.EventHandler(this.btnlista_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(23, 362);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 11;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(36, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cuantas veces perdió?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(36, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cuantas veces ganó?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre del Juego:";
            // 
            // dgvProds
            // 
            this.dgvProds.AllowUserToOrderColumns = true;
            this.dgvProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column2});
            this.dgvProds.Location = new System.Drawing.Point(261, 30);
            this.dgvProds.Name = "dgvProds";
            this.dgvProds.RowTemplate.Height = 25;
            this.dgvProds.Size = new System.Drawing.Size(442, 268);
            this.dgvProds.TabIndex = 6;
            this.dgvProds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre del juego";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Puntaje de las jugadas ganadas";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Puntaje de las jugadas Perdidas";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Puntaje Total";
            this.Column2.Name = "Column2";
            // 
            // txtpierde
            // 
            this.txtpierde.Location = new System.Drawing.Point(36, 227);
            this.txtpierde.Name = "txtpierde";
            this.txtpierde.Size = new System.Drawing.Size(186, 23);
            this.txtpierde.TabIndex = 4;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(35, 67);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(186, 23);
            this.txtnombre.TabIndex = 3;
            // 
            // txtgana
            // 
            this.txtgana.Location = new System.Drawing.Point(36, 144);
            this.txtgana.Name = "txtgana";
            this.txtgana.Size = new System.Drawing.Size(186, 23);
            this.txtgana.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnagregar;
        private Label label4;
        private Label label3;
        private Label label1;
        private DataGridView dgvProds;
        private TextBox txtpierde;
        private TextBox txtnombre;
        private TextBox txtgana;
        private Button btnlista;
        private Label label2;
        private TextBox txtubicacion;
        private Label label5;
        private Label Sumatoria;
        private TextBox txtpuntuacion;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
    }
}