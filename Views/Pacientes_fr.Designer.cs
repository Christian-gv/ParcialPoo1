namespace ParcialPoo1
{
    partial class Pacientes_fr
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre_PA = new System.Windows.Forms.TextBox();
            this.txt_apellido_PA = new System.Windows.Forms.TextBox();
            this.txt_telefono_PA = new System.Windows.Forms.TextBox();
            this.FN_PA = new System.Windows.Forms.DateTimePicker();
            this.agr_PA_bt = new System.Windows.Forms.Button();
            this.el_PA_bt = new System.Windows.Forms.Button();
            this.md_PA_bt = new System.Windows.Forms.Button();
            this.lt_PA = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevos Pacientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // txt_nombre_PA
            // 
            this.txt_nombre_PA.Location = new System.Drawing.Point(424, 100);
            this.txt_nombre_PA.Name = "txt_nombre_PA";
            this.txt_nombre_PA.Size = new System.Drawing.Size(297, 26);
            this.txt_nombre_PA.TabIndex = 5;
            this.txt_nombre_PA.TextChanged += new System.EventHandler(this.txt_nombre_PA_TextChanged);
            // 
            // txt_apellido_PA
            // 
            this.txt_apellido_PA.Location = new System.Drawing.Point(424, 164);
            this.txt_apellido_PA.Name = "txt_apellido_PA";
            this.txt_apellido_PA.Size = new System.Drawing.Size(297, 26);
            this.txt_apellido_PA.TabIndex = 6;
            this.txt_apellido_PA.TextChanged += new System.EventHandler(this.txt_apellido_PA_TextChanged);
            // 
            // txt_telefono_PA
            // 
            this.txt_telefono_PA.Location = new System.Drawing.Point(424, 298);
            this.txt_telefono_PA.Name = "txt_telefono_PA";
            this.txt_telefono_PA.Size = new System.Drawing.Size(297, 26);
            this.txt_telefono_PA.TabIndex = 7;
            this.txt_telefono_PA.TextChanged += new System.EventHandler(this.txt_telefono_PA_TextChanged);
            // 
            // FN_PA
            // 
            this.FN_PA.Location = new System.Drawing.Point(424, 229);
            this.FN_PA.Name = "FN_PA";
            this.FN_PA.Size = new System.Drawing.Size(297, 26);
            this.FN_PA.TabIndex = 8;
            this.FN_PA.ValueChanged += new System.EventHandler(this.FN_PA_ValueChanged);
            // 
            // agr_PA_bt
            // 
            this.agr_PA_bt.Location = new System.Drawing.Point(259, 352);
            this.agr_PA_bt.Name = "agr_PA_bt";
            this.agr_PA_bt.Size = new System.Drawing.Size(125, 43);
            this.agr_PA_bt.TabIndex = 9;
            this.agr_PA_bt.Text = "Agregar";
            this.agr_PA_bt.UseVisualStyleBackColor = true;
            this.agr_PA_bt.Click += new System.EventHandler(this.agr_PA_bt_Click);
            // 
            // el_PA_bt
            // 
            this.el_PA_bt.Location = new System.Drawing.Point(446, 352);
            this.el_PA_bt.Name = "el_PA_bt";
            this.el_PA_bt.Size = new System.Drawing.Size(125, 43);
            this.el_PA_bt.TabIndex = 10;
            this.el_PA_bt.Text = "Eliminar";
            this.el_PA_bt.UseVisualStyleBackColor = true;
            this.el_PA_bt.Click += new System.EventHandler(this.el_PA_bt_Click);
            // 
            // md_PA_bt
            // 
            this.md_PA_bt.Location = new System.Drawing.Point(638, 352);
            this.md_PA_bt.Name = "md_PA_bt";
            this.md_PA_bt.Size = new System.Drawing.Size(125, 43);
            this.md_PA_bt.TabIndex = 11;
            this.md_PA_bt.Text = "Modificar";
            this.md_PA_bt.UseVisualStyleBackColor = true;
            this.md_PA_bt.Click += new System.EventHandler(this.md_PA_bt_Click);
            // 
            // lt_PA
            // 
            this.lt_PA.FormattingEnabled = true;
            this.lt_PA.ItemHeight = 20;
            this.lt_PA.Location = new System.Drawing.Point(12, 431);
            this.lt_PA.Name = "lt_PA";
            this.lt_PA.Size = new System.Drawing.Size(986, 204);
            this.lt_PA.TabIndex = 12;
            this.lt_PA.SelectedIndexChanged += new System.EventHandler(this.lt_PA_SelectedIndexChanged);
            this.lt_PA.MouseEnter += new System.EventHandler(this.md_PA_bt_Click);
            // 
            // Pacientes_fr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 651);
            this.Controls.Add(this.lt_PA);
            this.Controls.Add(this.md_PA_bt);
            this.Controls.Add(this.el_PA_bt);
            this.Controls.Add(this.agr_PA_bt);
            this.Controls.Add(this.FN_PA);
            this.Controls.Add(this.txt_telefono_PA);
            this.Controls.Add(this.txt_apellido_PA);
            this.Controls.Add(this.txt_nombre_PA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pacientes_fr";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_fr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombre_PA;
        private System.Windows.Forms.TextBox txt_apellido_PA;
        private System.Windows.Forms.TextBox txt_telefono_PA;
        private System.Windows.Forms.DateTimePicker FN_PA;
        private System.Windows.Forms.Button agr_PA_bt;
        private System.Windows.Forms.Button el_PA_bt;
        private System.Windows.Forms.Button md_PA_bt;
        private System.Windows.Forms.ListBox lt_PA;
    }
}

