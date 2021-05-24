namespace Ohm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.StromButton = new System.Windows.Forms.RadioButton();
            this.Spannungbutton = new System.Windows.Forms.RadioButton();
            this.WiderstandButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BerechnenButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StromButton
            // 
            this.StromButton.AutoSize = true;
            this.StromButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StromButton.Location = new System.Drawing.Point(342, 72);
            this.StromButton.Name = "StromButton";
            this.StromButton.Size = new System.Drawing.Size(67, 22);
            this.StromButton.TabIndex = 0;
            this.StromButton.TabStop = true;
            this.StromButton.Text = "Strom";
            this.StromButton.UseVisualStyleBackColor = true;
            this.StromButton.CheckedChanged += new System.EventHandler(this.StromButton_CheckedChanged);
            // 
            // Spannungbutton
            // 
            this.Spannungbutton.AutoSize = true;
            this.Spannungbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spannungbutton.Location = new System.Drawing.Point(342, 95);
            this.Spannungbutton.Name = "Spannungbutton";
            this.Spannungbutton.Size = new System.Drawing.Size(92, 22);
            this.Spannungbutton.TabIndex = 1;
            this.Spannungbutton.TabStop = true;
            this.Spannungbutton.Text = "Spannung";
            this.Spannungbutton.UseVisualStyleBackColor = true;
            this.Spannungbutton.CheckedChanged += new System.EventHandler(this.Spannungbutton_CheckedChanged);
            // 
            // WiderstandButton
            // 
            this.WiderstandButton.AutoSize = true;
            this.WiderstandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WiderstandButton.Location = new System.Drawing.Point(342, 119);
            this.WiderstandButton.Name = "WiderstandButton";
            this.WiderstandButton.Size = new System.Drawing.Size(101, 22);
            this.WiderstandButton.TabIndex = 2;
            this.WiderstandButton.TabStop = true;
            this.WiderstandButton.Text = "Widerstand";
            this.WiderstandButton.UseVisualStyleBackColor = true;
            this.WiderstandButton.CheckedChanged += new System.EventHandler(this.WiderstandButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gesucht";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 11;
            // 
            // BerechnenButton
            // 
            this.BerechnenButton.Location = new System.Drawing.Point(58, 220);
            this.BerechnenButton.Name = "BerechnenButton";
            this.BerechnenButton.Size = new System.Drawing.Size(75, 23);
            this.BerechnenButton.TabIndex = 12;
            this.BerechnenButton.Text = "Berechnen";
            this.BerechnenButton.UseVisualStyleBackColor = true;
            this.BerechnenButton.Click += new System.EventHandler(this.BerechnenButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bitte geben Sie im Textbox die gewünschten Zahlen ein!";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 41);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 107);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 41);
            this.textBox2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ohmsche Gesetz Rechner";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Geschwindigkeit",
            "Ohmsches Gesetz"});
            this.comboBox1.Location = new System.Drawing.Point(342, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 283);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BerechnenButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WiderstandButton);
            this.Controls.Add(this.Spannungbutton);
            this.Controls.Add(this.StromButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton StromButton;
        private System.Windows.Forms.RadioButton Spannungbutton;
        private System.Windows.Forms.RadioButton WiderstandButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BerechnenButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

