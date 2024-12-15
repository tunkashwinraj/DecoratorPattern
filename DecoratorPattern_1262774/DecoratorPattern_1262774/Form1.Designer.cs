namespace DecoratorPattern_1262774
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
            this.btnDecoratorSimple = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubClassing = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDecoratorSimple
            // 
            this.btnDecoratorSimple.Location = new System.Drawing.Point(45, 107);
            this.btnDecoratorSimple.Name = "btnDecoratorSimple";
            this.btnDecoratorSimple.Size = new System.Drawing.Size(215, 23);
            this.btnDecoratorSimple.TabIndex = 0;
            this.btnDecoratorSimple.Text = "btnDecoratorSimple";
            this.btnDecoratorSimple.UseVisualStyleBackColor = true;
            this.btnDecoratorSimple.Click += new System.EventHandler(this.btnDecoratorSimple_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test Decorator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSubClassing
            // 
            this.btnSubClassing.Location = new System.Drawing.Point(315, 106);
            this.btnSubClassing.Name = "btnSubClassing";
            this.btnSubClassing.Size = new System.Drawing.Size(167, 23);
            this.btnSubClassing.TabIndex = 2;
            this.btnSubClassing.Text = "btnSubClassing";
            this.btnSubClassing.UseVisualStyleBackColor = true;
            this.btnSubClassing.Click += new System.EventHandler(this.btnSubClassing_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Test Subclassing";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubClassing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecoratorSimple);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecoratorSimple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubClassing;
        private System.Windows.Forms.Label label2;
    }
}

