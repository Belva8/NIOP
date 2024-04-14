namespace Aplikacija_Trgovine
{
    partial class PopisProizvoda
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCijenaJela = new System.Windows.Forms.Label();
            this.textBoxCJ1 = new System.Windows.Forms.TextBox();
            this.textBoxCJ2 = new System.Windows.Forms.TextBox();
            this.textBoxCP1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCP2 = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj Proizvod";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Uredi Proizvod";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(669, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Obriši Proizvod";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(574, 277);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "POPIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PROIZVODA";
            // 
            // labelCijenaJela
            // 
            this.labelCijenaJela.AutoSize = true;
            this.labelCijenaJela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCijenaJela.Location = new System.Drawing.Point(666, 24);
            this.labelCijenaJela.Name = "labelCijenaJela";
            this.labelCijenaJela.Size = new System.Drawing.Size(55, 13);
            this.labelCijenaJela.TabIndex = 14;
            this.labelCijenaJela.Text = "Cijena jela";
            // 
            // textBoxCJ1
            // 
            this.textBoxCJ1.Location = new System.Drawing.Point(626, 40);
            this.textBoxCJ1.Name = "textBoxCJ1";
            this.textBoxCJ1.Size = new System.Drawing.Size(66, 20);
            this.textBoxCJ1.TabIndex = 15;
            // 
            // textBoxCJ2
            // 
            this.textBoxCJ2.Location = new System.Drawing.Point(698, 39);
            this.textBoxCJ2.Name = "textBoxCJ2";
            this.textBoxCJ2.Size = new System.Drawing.Size(66, 20);
            this.textBoxCJ2.TabIndex = 16;
            // 
            // textBoxCP1
            // 
            this.textBoxCP1.Location = new System.Drawing.Point(626, 78);
            this.textBoxCP1.Name = "textBoxCP1";
            this.textBoxCP1.Size = new System.Drawing.Size(66, 20);
            this.textBoxCP1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(662, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cijena pića";
            // 
            // textBoxCP2
            // 
            this.textBoxCP2.Location = new System.Drawing.Point(698, 78);
            this.textBoxCP2.Name = "textBoxCP2";
            this.textBoxCP2.Size = new System.Drawing.Size(66, 20);
            this.textBoxCP2.TabIndex = 20;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(520, 36);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 21;
            this.buttonFilter.Text = "Filtriraj";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // PopisProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.textBoxCP2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCP1);
            this.Controls.Add(this.textBoxCJ2);
            this.Controls.Add(this.textBoxCJ1);
            this.Controls.Add(this.labelCijenaJela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "PopisProizvoda";
            this.Text = "PopisProizvoda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCijenaJela;
        private System.Windows.Forms.TextBox textBoxCJ1;
        private System.Windows.Forms.TextBox textBoxCJ2;
        private System.Windows.Forms.TextBox textBoxCP1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCP2;
        private System.Windows.Forms.Button buttonFilter;
    }
}