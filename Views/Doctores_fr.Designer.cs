namespace ParcialPoo1.Views
{
    partial class Doctores_fr
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
            this.lt_DO = new System.Windows.Forms.ListBox();
            this.md_DO_bt = new System.Windows.Forms.Button();
            this.el_DO_bt = new System.Windows.Forms.Button();
            this.agr_DO_bt = new System.Windows.Forms.Button();
            this.txt_telefono_DO = new System.Windows.Forms.TextBox();
            this.txt_apellido_DO = new System.Windows.Forms.TextBox();
            this.txt_nombre_DO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_especialidad_DO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lt_DO
            // 
            this.lt_DO.FormattingEnabled = true;
            this.lt_DO.ItemHeight = 20;
            this.lt_DO.Location = new System.Drawing.Point(128, 446);
            this.lt_DO.Name = "lt_DO";
            this.lt_DO.Size = new System.Drawing.Size(986, 204);
            this.lt_DO.TabIndex = 25;
            this.lt_DO.SelectedIndexChanged += new System.EventHandler(this.lt_DO_SelectedIndexChanged);
            // 
            // md_DO_bt
            // 
            this.md_DO_bt.Location = new System.Drawing.Point(754, 367);
            this.md_DO_bt.Name = "md_DO_bt";
            this.md_DO_bt.Size = new System.Drawing.Size(125, 43);
            this.md_DO_bt.TabIndex = 24;
            this.md_DO_bt.Text = "Modificar";
            this.md_DO_bt.UseVisualStyleBackColor = true;
            this.md_DO_bt.Click += new System.EventHandler(this.md_DO_bt_Click);
            // 
            // el_DO_bt
            // 
            this.el_DO_bt.Location = new System.Drawing.Point(562, 367);
            this.el_DO_bt.Name = "el_DO_bt";
            this.el_DO_bt.Size = new System.Drawing.Size(125, 43);
            this.el_DO_bt.TabIndex = 23;
            this.el_DO_bt.Text = "Eliminar";
            this.el_DO_bt.UseVisualStyleBackColor = true;
            this.el_DO_bt.Click += new System.EventHandler(this.el_DO_bt_Click);
            // 
            // agr_DO_bt
            // 
            this.agr_DO_bt.Location = new System.Drawing.Point(375, 367);
            this.agr_DO_bt.Name = "agr_DO_bt";
            this.agr_DO_bt.Size = new System.Drawing.Size(125, 43);
            this.agr_DO_bt.TabIndex = 22;
            this.agr_DO_bt.Text = "Agregar";
            this.agr_DO_bt.UseVisualStyleBackColor = true;
            this.agr_DO_bt.Click += new System.EventHandler(this.agr_DO_bt_Click);
            // 
            // txt_telefono_DO
            // 
            this.txt_telefono_DO.Location = new System.Drawing.Point(540, 313);
            this.txt_telefono_DO.Name = "txt_telefono_DO";
            this.txt_telefono_DO.Size = new System.Drawing.Size(297, 26);
            this.txt_telefono_DO.TabIndex = 21;
            // 
            // txt_apellido_DO
            // 
            this.txt_apellido_DO.Location = new System.Drawing.Point(540, 179);
            this.txt_apellido_DO.Name = "txt_apellido_DO";
            this.txt_apellido_DO.Size = new System.Drawing.Size(297, 26);
            this.txt_apellido_DO.TabIndex = 19;
            // 
            // txt_nombre_DO
            // 
            this.txt_nombre_DO.Location = new System.Drawing.Point(540, 115);
            this.txt_nombre_DO.Name = "txt_nombre_DO";
            this.txt_nombre_DO.Size = new System.Drawing.Size(297, 26);
            this.txt_nombre_DO.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Especialidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 68);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nuevos Doctores";
            // 
            // txt_especialidad_DO
            // 
            this.txt_especialidad_DO.Location = new System.Drawing.Point(540, 246);
            this.txt_especialidad_DO.Name = "txt_especialidad_DO";
            this.txt_especialidad_DO.Size = new System.Drawing.Size(297, 26);
            this.txt_especialidad_DO.TabIndex = 20;
            // 
            // Doctores_fr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 675);
            this.Controls.Add(this.txt_especialidad_DO);
            this.Controls.Add(this.lt_DO);
            this.Controls.Add(this.md_DO_bt);
            this.Controls.Add(this.el_DO_bt);
            this.Controls.Add(this.agr_DO_bt);
            this.Controls.Add(this.txt_telefono_DO);
            this.Controls.Add(this.txt_apellido_DO);
            this.Controls.Add(this.txt_nombre_DO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Doctores_fr";
            this.Text = "Doctores_fr";
            this.Load += new System.EventHandler(this.Doctores_fr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lt_DO;
        private System.Windows.Forms.Button md_DO_bt;
        private System.Windows.Forms.Button el_DO_bt;
        private System.Windows.Forms.Button agr_DO_bt;
        private System.Windows.Forms.TextBox txt_telefono_DO;
        private System.Windows.Forms.TextBox txt_apellido_DO;
        private System.Windows.Forms.TextBox txt_nombre_DO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_especialidad_DO;
    }
}