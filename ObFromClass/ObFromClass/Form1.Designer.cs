namespace ObFromClass
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
            this.createObBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.setStrBtn = new System.Windows.Forms.Button();
            this.getStrBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createObBtn
            // 
            this.createObBtn.Location = new System.Drawing.Point(88, 200);
            this.createObBtn.Name = "createObBtn";
            this.createObBtn.Size = new System.Drawing.Size(75, 23);
            this.createObBtn.TabIndex = 0;
            this.createObBtn.Text = "Create Ob";
            this.createObBtn.UseVisualStyleBackColor = true;
            this.createObBtn.Click += new System.EventHandler(this.createObBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(369, 118);
            this.textBox1.TabIndex = 1;
            // 
            // setStrBtn
            // 
            this.setStrBtn.Location = new System.Drawing.Point(229, 200);
            this.setStrBtn.Name = "setStrBtn";
            this.setStrBtn.Size = new System.Drawing.Size(75, 23);
            this.setStrBtn.TabIndex = 2;
            this.setStrBtn.Text = "Set String";
            this.setStrBtn.UseVisualStyleBackColor = true;
            this.setStrBtn.Click += new System.EventHandler(this.setStrBtn_Click);
            // 
            // getStrBtn
            // 
            this.getStrBtn.Location = new System.Drawing.Point(382, 200);
            this.getStrBtn.Name = "getStrBtn";
            this.getStrBtn.Size = new System.Drawing.Size(75, 23);
            this.getStrBtn.TabIndex = 3;
            this.getStrBtn.Text = "Get String";
            this.getStrBtn.UseVisualStyleBackColor = true;
            this.getStrBtn.Click += new System.EventHandler(this.getStrBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 289);
            this.Controls.Add(this.getStrBtn);
            this.Controls.Add(this.setStrBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.createObBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createObBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button setStrBtn;
        private System.Windows.Forms.Button getStrBtn;
    }
}

