namespace CoffeeAndSweets
{
    partial class Replenishment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSugar = new System.Windows.Forms.Label();
            this.lblMilk = new System.Windows.Forms.Label();
            this.lblCoffeeBean = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblSugar);
            this.panel1.Controls.Add(this.lblMilk);
            this.panel1.Controls.Add(this.lblCoffeeBean);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 323);
            this.panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(241, 218);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(241, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // lblSugar
            // 
            this.lblSugar.AutoSize = true;
            this.lblSugar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSugar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSugar.Location = new System.Drawing.Point(101, 219);
            this.lblSugar.Name = "lblSugar";
            this.lblSugar.Size = new System.Drawing.Size(54, 19);
            this.lblSugar.TabIndex = 3;
            this.lblSugar.Text = "Sugar";
            // 
            // lblMilk
            // 
            this.lblMilk.AutoSize = true;
            this.lblMilk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilk.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMilk.Location = new System.Drawing.Point(101, 171);
            this.lblMilk.Name = "lblMilk";
            this.lblMilk.Size = new System.Drawing.Size(40, 19);
            this.lblMilk.TabIndex = 2;
            this.lblMilk.Text = "Milk";
            // 
            // lblCoffeeBean
            // 
            this.lblCoffeeBean.AutoSize = true;
            this.lblCoffeeBean.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeBean.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCoffeeBean.Location = new System.Drawing.Point(101, 123);
            this.lblCoffeeBean.Name = "lblCoffeeBean";
            this.lblCoffeeBean.Size = new System.Drawing.Size(103, 19);
            this.lblCoffeeBean.TabIndex = 1;
            this.lblCoffeeBean.Text = "Coffee Bean";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(134, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Replenishment Form";
            // 
            // Replenishment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 322);
            this.Controls.Add(this.panel1);
            this.Name = "Replenishment";
            this.Text = "Replenishment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSugar;
        private System.Windows.Forms.Label lblMilk;
        private System.Windows.Forms.Label lblCoffeeBean;
        private System.Windows.Forms.Label label1;
    }
}