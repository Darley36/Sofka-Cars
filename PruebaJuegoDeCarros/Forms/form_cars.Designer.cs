namespace PruebaJuegoDeCarros.Forms
{
    partial class form_cars
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.btn_dado = new System.Windows.Forms.Button();
            this.txt_dado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_jugador = new System.Windows.Forms.TextBox();
            this.txt_Dis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_jugador = new System.Windows.Forms.ComboBox();
            this.txt_recorrido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_falta = new System.Windows.Forms.TextBox();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(16, 286);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(65, 36);
            this.btn_salir.TabIndex = 0;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(489, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distancia";
            // 
            // txt_km
            // 
            this.txt_km.Enabled = false;
            this.txt_km.Location = new System.Drawing.Point(493, 45);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(81, 20);
            this.txt_km.TabIndex = 2;
            // 
            // btn_dado
            // 
            this.btn_dado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dado.Location = new System.Drawing.Point(270, 71);
            this.btn_dado.Name = "btn_dado";
            this.btn_dado.Size = new System.Drawing.Size(105, 46);
            this.btn_dado.TabIndex = 3;
            this.btn_dado.Text = "Lanzar";
            this.btn_dado.UseVisualStyleBackColor = true;
            this.btn_dado.Click += new System.EventHandler(this.btn_dado_Click);
            // 
            // txt_dado
            // 
            this.txt_dado.Enabled = false;
            this.txt_dado.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dado.Location = new System.Drawing.Point(270, 132);
            this.txt_dado.Multiline = true;
            this.txt_dado.Name = "txt_dado";
            this.txt_dado.Size = new System.Drawing.Size(105, 83);
            this.txt_dado.TabIndex = 4;
            this.txt_dado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "JUGADOR";
            // 
            // txt_jugador
            // 
            this.txt_jugador.Enabled = false;
            this.txt_jugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jugador.Location = new System.Drawing.Point(16, 93);
            this.txt_jugador.Name = "txt_jugador";
            this.txt_jugador.Size = new System.Drawing.Size(160, 24);
            this.txt_jugador.TabIndex = 6;
            // 
            // txt_Dis
            // 
            this.txt_Dis.Enabled = false;
            this.txt_Dis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dis.Location = new System.Drawing.Point(16, 191);
            this.txt_Dis.Name = "txt_Dis";
            this.txt_Dis.Size = new System.Drawing.Size(160, 24);
            this.txt_Dis.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Distancia Recorrida";
            // 
            // cmb_jugador
            // 
            this.cmb_jugador.FormattingEnabled = true;
            this.cmb_jugador.Location = new System.Drawing.Point(489, 155);
            this.cmb_jugador.Name = "cmb_jugador";
            this.cmb_jugador.Size = new System.Drawing.Size(100, 21);
            this.cmb_jugador.TabIndex = 9;
            // 
            // txt_recorrido
            // 
            this.txt_recorrido.Location = new System.Drawing.Point(489, 228);
            this.txt_recorrido.Name = "txt_recorrido";
            this.txt_recorrido.Size = new System.Drawing.Size(100, 20);
            this.txt_recorrido.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(486, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jugador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(486, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Recorrido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(486, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Falta";
            // 
            // txt_falta
            // 
            this.txt_falta.Location = new System.Drawing.Point(489, 302);
            this.txt_falta.Name = "txt_falta";
            this.txt_falta.Size = new System.Drawing.Size(100, 20);
            this.txt_falta.TabIndex = 14;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_siguiente.Location = new System.Drawing.Point(270, 242);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(105, 46);
            this.btn_siguiente.TabIndex = 16;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // form_cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(601, 335);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_falta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_recorrido);
            this.Controls.Add(this.cmb_jugador);
            this.Controls.Add(this.txt_Dis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_jugador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dado);
            this.Controls.Add(this.btn_dado);
            this.Controls.Add(this.txt_km);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "form_cars";
            this.Text = "form_carros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_km;
        private System.Windows.Forms.Button btn_dado;
        private System.Windows.Forms.TextBox txt_dado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_jugador;
        private System.Windows.Forms.TextBox txt_Dis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_jugador;
        private System.Windows.Forms.TextBox txt_recorrido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_falta;
        private System.Windows.Forms.Button btn_siguiente;
    }
}