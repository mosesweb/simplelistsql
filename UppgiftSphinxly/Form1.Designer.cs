namespace UppgiftSphinxly
{
    partial class ProduktkatalogForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "ArticleList";
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(38, 485);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(714, 169);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ta bort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(38, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(714, 221);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produkt: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pris:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unikt ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 64);
            this.button2.TabIndex = 8;
            this.button2.Text = "Fyll på";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProduktkatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 853);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "ProduktkatalogForm";
            this.Text = "Produktkatalog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

