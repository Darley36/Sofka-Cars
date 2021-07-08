namespace PruebaJuegoDeCarros
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.lb_carro = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_jugar = new System.Windows.Forms.Button();
            this.btn_mostrarVictorias = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(55, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NickName";
            // 
            // txt_nickname
            // 
            this.txt_nickname.Location = new System.Drawing.Point(180, 69);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(100, 20);
            this.txt_nickname.TabIndex = 1;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(180, 114);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(100, 20);
            this.txt_edad.TabIndex = 2;
            // 
            // lb_carro
            // 
            this.lb_carro.FormattingEnabled = true;
            this.lb_carro.Location = new System.Drawing.Point(180, 185);
            this.lb_carro.Name = "lb_carro";
            this.lb_carro.Size = new System.Drawing.Size(120, 95);
            this.lb_carro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(55, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(55, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carro";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(443, 12);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(117, 59);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_jugar
            // 
            this.btn_jugar.Location = new System.Drawing.Point(443, 95);
            this.btn_jugar.Name = "btn_jugar";
            this.btn_jugar.Size = new System.Drawing.Size(117, 59);
            this.btn_jugar.TabIndex = 9;
            this.btn_jugar.Text = "Jugar";
            this.btn_jugar.UseVisualStyleBackColor = true;
            this.btn_jugar.Click += new System.EventHandler(this.btn_jugar_Click);
            // 
            // btn_mostrarVictorias
            // 
            this.btn_mostrarVictorias.Location = new System.Drawing.Point(443, 185);
            this.btn_mostrarVictorias.Name = "btn_mostrarVictorias";
            this.btn_mostrarVictorias.Size = new System.Drawing.Size(117, 58);
            this.btn_mostrarVictorias.TabIndex = 10;
            this.btn_mostrarVictorias.Text = "Victorias";
            this.btn_mostrarVictorias.UseVisualStyleBackColor = true;
            this.btn_mostrarVictorias.Click += new System.EventHandler(this.btn_mostrarVictorias_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(443, 274);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(117, 58);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(634, 359);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_mostrarVictorias);
            this.Controls.Add(this.btn_jugar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_carro);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_nickname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.ListBox lb_carro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_jugar;
        private System.Windows.Forms.Button btn_mostrarVictorias;
        private System.Windows.Forms.Button btn_salir;
    }
}

