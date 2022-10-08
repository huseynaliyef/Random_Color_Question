namespace Random_Color_Question_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Question_box = new System.Windows.Forms.TextBox();
            this.aVarianti = new System.Windows.Forms.Button();
            this.bVarianti = new System.Windows.Forms.Button();
            this.cVarianti = new System.Windows.Forms.Button();
            this.dVarianti = new System.Windows.Forms.Button();
            this.eVarianti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Question_box
            // 
            this.Question_box.Enabled = false;
            this.Question_box.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Question_box.Location = new System.Drawing.Point(177, 98);
            this.Question_box.Multiline = true;
            this.Question_box.Name = "Question_box";
            this.Question_box.Size = new System.Drawing.Size(425, 55);
            this.Question_box.TabIndex = 0;
            this.Question_box.Text = "Which Color is the background ?";
            // 
            // aVarianti
            // 
            this.aVarianti.Location = new System.Drawing.Point(46, 244);
            this.aVarianti.Name = "aVarianti";
            this.aVarianti.Size = new System.Drawing.Size(75, 23);
            this.aVarianti.TabIndex = 1;
            this.aVarianti.Text = "A)";
            this.aVarianti.UseVisualStyleBackColor = true;
            this.aVarianti.Click += new System.EventHandler(this.duymeler);
            // 
            // bVarianti
            // 
            this.bVarianti.Location = new System.Drawing.Point(177, 244);
            this.bVarianti.Name = "bVarianti";
            this.bVarianti.Size = new System.Drawing.Size(75, 23);
            this.bVarianti.TabIndex = 2;
            this.bVarianti.Text = "B)";
            this.bVarianti.UseVisualStyleBackColor = true;
            this.bVarianti.Click += new System.EventHandler(this.duymeler);
            // 
            // cVarianti
            // 
            this.cVarianti.Location = new System.Drawing.Point(335, 244);
            this.cVarianti.Name = "cVarianti";
            this.cVarianti.Size = new System.Drawing.Size(75, 23);
            this.cVarianti.TabIndex = 3;
            this.cVarianti.Text = "C)";
            this.cVarianti.UseVisualStyleBackColor = true;
            this.cVarianti.Click += new System.EventHandler(this.duymeler);
            // 
            // dVarianti
            // 
            this.dVarianti.Location = new System.Drawing.Point(500, 244);
            this.dVarianti.Name = "dVarianti";
            this.dVarianti.Size = new System.Drawing.Size(75, 23);
            this.dVarianti.TabIndex = 4;
            this.dVarianti.Text = "D)";
            this.dVarianti.UseVisualStyleBackColor = true;
            this.dVarianti.Click += new System.EventHandler(this.duymeler);
            // 
            // eVarianti
            // 
            this.eVarianti.Location = new System.Drawing.Point(652, 244);
            this.eVarianti.Name = "eVarianti";
            this.eVarianti.Size = new System.Drawing.Size(75, 23);
            this.eVarianti.TabIndex = 5;
            this.eVarianti.Text = "E)";
            this.eVarianti.UseVisualStyleBackColor = true;
            this.eVarianti.Click += new System.EventHandler(this.duymeler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 398);
            this.Controls.Add(this.eVarianti);
            this.Controls.Add(this.dVarianti);
            this.Controls.Add(this.cVarianti);
            this.Controls.Add(this.bVarianti);
            this.Controls.Add(this.aVarianti);
            this.Controls.Add(this.Question_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Question_box;
        private Button aVarianti;
        private Button bVarianti;
        private Button cVarianti;
        private Button dVarianti;
        private Button eVarianti;
    }
}