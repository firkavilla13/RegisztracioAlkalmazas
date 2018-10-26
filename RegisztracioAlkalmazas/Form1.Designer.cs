namespace RegisztracioAlkalmazas
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.rb_f = new System.Windows.Forms.RadioButton();
            this.rb_n = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ujhobbi = new System.Windows.Forms.TextBox();
            this.hozzaadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lb_hobbi = new System.Windows.Forms.ListBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.buttonTallozas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szül. dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nem:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(97, 13);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(130, 20);
            this.tb_name.TabIndex = 3;
            // 
            // rb_f
            // 
            this.rb_f.AutoSize = true;
            this.rb_f.Location = new System.Drawing.Point(116, 79);
            this.rb_f.Name = "rb_f";
            this.rb_f.Size = new System.Drawing.Size(31, 17);
            this.rb_f.TabIndex = 5;
            this.rb_f.TabStop = true;
            this.rb_f.Text = "F";
            this.rb_f.UseVisualStyleBackColor = true;
            // 
            // rb_n
            // 
            this.rb_n.AutoSize = true;
            this.rb_n.Location = new System.Drawing.Point(167, 79);
            this.rb_n.Name = "rb_n";
            this.rb_n.Size = new System.Drawing.Size(33, 17);
            this.rb_n.TabIndex = 6;
            this.rb_n.TabStop = true;
            this.rb_n.Text = "N";
            this.rb_n.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kedvenc: hobbi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Új hobbi:";
            // 
            // tb_ujhobbi
            // 
            this.tb_ujhobbi.Location = new System.Drawing.Point(255, 168);
            this.tb_ujhobbi.Name = "tb_ujhobbi";
            this.tb_ujhobbi.Size = new System.Drawing.Size(100, 20);
            this.tb_ujhobbi.TabIndex = 10;
            // 
            // hozzaadButton
            // 
            this.hozzaadButton.Location = new System.Drawing.Point(272, 208);
            this.hozzaadButton.Name = "hozzaadButton";
            this.hozzaadButton.Size = new System.Drawing.Size(75, 23);
            this.hozzaadButton.TabIndex = 11;
            this.hozzaadButton.Text = "Hozzáad";
            this.hozzaadButton.UseVisualStyleBackColor = true;
            this.hozzaadButton.Click += new System.EventHandler(this.hozzaadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(272, 249);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Mentés";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(152, 208);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 13;
            this.openButton.Text = "Betöltés";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lb_hobbi
            // 
            this.lb_hobbi.DisplayMember = "zjgfzj";
            this.lb_hobbi.FormattingEnabled = true;
            this.lb_hobbi.Items.AddRange(new object[] {
            "Úszás",
            "Horgászat",
            "Futás"});
            this.lb_hobbi.Location = new System.Drawing.Point(234, 44);
            this.lb_hobbi.Name = "lb_hobbi";
            this.lb_hobbi.Size = new System.Drawing.Size(120, 95);
            this.lb_hobbi.TabIndex = 14;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(97, 45);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(130, 20);
            this.dtp_date.TabIndex = 15;
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(12, 249);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(215, 20);
            this.tb_path.TabIndex = 16;
            // 
            // buttonTallozas
            // 
            this.buttonTallozas.Location = new System.Drawing.Point(16, 208);
            this.buttonTallozas.Name = "buttonTallozas";
            this.buttonTallozas.Size = new System.Drawing.Size(75, 23);
            this.buttonTallozas.TabIndex = 17;
            this.buttonTallozas.Text = "Tallozás";
            this.buttonTallozas.UseVisualStyleBackColor = true;
            this.buttonTallozas.Click += new System.EventHandler(this.buttonTallozas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 284);
            this.Controls.Add(this.buttonTallozas);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.lb_hobbi);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.hozzaadButton);
            this.Controls.Add(this.tb_ujhobbi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_n);
            this.Controls.Add(this.rb_f);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.RadioButton rb_f;
        private System.Windows.Forms.RadioButton rb_n;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button hozzaadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListBox lb_hobbi;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.TextBox tb_ujhobbi;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button buttonTallozas;
    }
}

