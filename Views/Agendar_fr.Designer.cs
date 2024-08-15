namespace ParcialPoo1.Views
{
    partial class Agendar_fr
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
            this.label1 = new System.Windows.Forms.Label();
            this.Dt_PA_lt = new System.Windows.Forms.ListBox();
            this.Dt_DO_lt = new System.Windows.Forms.ListBox();
            this.Dt_ct_lt = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Ag_ct_BT = new System.Windows.Forms.Button();
            this.El_ct_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 68);
            this.label1.TabIndex = 14;
            this.label1.Text = "Agendar Cita Medica";
            // 
            // Dt_PA_lt
            // 
            this.Dt_PA_lt.FormattingEnabled = true;
            this.Dt_PA_lt.ItemHeight = 20;
            this.Dt_PA_lt.Location = new System.Drawing.Point(12, 367);
            this.Dt_PA_lt.Name = "Dt_PA_lt";
            this.Dt_PA_lt.Size = new System.Drawing.Size(345, 264);
            this.Dt_PA_lt.TabIndex = 15;
            this.Dt_PA_lt.SelectedIndexChanged += new System.EventHandler(this.Dt_PA_lt_SelectedIndexChanged);
            // 
            // Dt_DO_lt
            // 
            this.Dt_DO_lt.FormattingEnabled = true;
            this.Dt_DO_lt.ItemHeight = 20;
            this.Dt_DO_lt.Location = new System.Drawing.Point(392, 367);
            this.Dt_DO_lt.Name = "Dt_DO_lt";
            this.Dt_DO_lt.Size = new System.Drawing.Size(345, 264);
            this.Dt_DO_lt.TabIndex = 16;
            this.Dt_DO_lt.SelectedIndexChanged += new System.EventHandler(this.Dt_DO_lt_SelectedIndexChanged);
            // 
            // Dt_ct_lt
            // 
            this.Dt_ct_lt.FormattingEnabled = true;
            this.Dt_ct_lt.ItemHeight = 20;
            this.Dt_ct_lt.Location = new System.Drawing.Point(789, 127);
            this.Dt_ct_lt.Name = "Dt_ct_lt";
            this.Dt_ct_lt.Size = new System.Drawing.Size(396, 504);
            this.Dt_ct_lt.TabIndex = 17;
            this.Dt_ct_lt.SelectedIndexChanged += new System.EventHandler(this.Dt_ct_lt_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Doctor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Motivo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(271, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 26);
            this.textBox2.TabIndex = 23;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(271, 284);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(466, 64);
            this.textBox3.TabIndex = 24;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(271, 247);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Ag_ct_BT
            // 
            this.Ag_ct_BT.Location = new System.Drawing.Point(552, 155);
            this.Ag_ct_BT.Name = "Ag_ct_BT";
            this.Ag_ct_BT.Size = new System.Drawing.Size(130, 38);
            this.Ag_ct_BT.TabIndex = 26;
            this.Ag_ct_BT.Text = "Agendar";
            this.Ag_ct_BT.UseVisualStyleBackColor = true;
            this.Ag_ct_BT.Click += new System.EventHandler(this.Ag_ct_BT_Click);
            // 
            // El_ct_BT
            // 
            this.El_ct_BT.Location = new System.Drawing.Point(552, 216);
            this.El_ct_BT.Name = "El_ct_BT";
            this.El_ct_BT.Size = new System.Drawing.Size(130, 38);
            this.El_ct_BT.TabIndex = 27;
            this.El_ct_BT.Text = "Eliminar";
            this.El_ct_BT.UseVisualStyleBackColor = true;
            this.El_ct_BT.Click += new System.EventHandler(this.El_ct_BT_Click);
            // 
            // Agendar_fr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 645);
            this.Controls.Add(this.El_ct_BT);
            this.Controls.Add(this.Ag_ct_BT);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dt_ct_lt);
            this.Controls.Add(this.Dt_DO_lt);
            this.Controls.Add(this.Dt_PA_lt);
            this.Controls.Add(this.label1);
            this.Name = "Agendar_fr";
            this.Text = "Agendar_fr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Dt_PA_lt;
        private System.Windows.Forms.ListBox Dt_DO_lt;
        private System.Windows.Forms.ListBox Dt_ct_lt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Ag_ct_BT;
        private System.Windows.Forms.Button El_ct_BT;
    }
}