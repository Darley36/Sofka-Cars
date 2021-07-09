namespace PruebaJuegoDeCarros.Forms
{
    partial class form_victorias
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
            this.DGV_victorias = new System.Windows.Forms.DataGridView();
            this.btn_volver = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_vic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_victorias)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_victorias
            // 
            this.DGV_victorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_victorias.Location = new System.Drawing.Point(12, 12);
            this.DGV_victorias.Name = "DGV_victorias";
            this.DGV_victorias.ReadOnly = true;
            this.DGV_victorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_victorias.Size = new System.Drawing.Size(561, 185);
            this.DGV_victorias.TabIndex = 0;
            this.DGV_victorias.Click += new System.EventHandler(this.DGV_victorias_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(12, 220);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(130, 33);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(277, 227);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 2;
            // 
            // txt_vic
            // 
            this.txt_vic.Enabled = false;
            this.txt_vic.Location = new System.Drawing.Point(473, 227);
            this.txt_vic.Name = "txt_vic";
            this.txt_vic.Size = new System.Drawing.Size(100, 20);
            this.txt_vic.TabIndex = 3;
            this.txt_vic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(383, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "# Victorias :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(193, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ganador :";
            // 
            // form_victorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(579, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_vic);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.DGV_victorias);
            this.Name = "form_victorias";
            this.Text = "form_victorias";
            this.Load += new System.EventHandler(this.form_victorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_victorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_victorias;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_vic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}