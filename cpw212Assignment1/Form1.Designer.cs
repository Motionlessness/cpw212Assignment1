namespace cpw212Assignment1
{
    partial class Oopsform
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
            this.Clickmebutt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clickmebutt
            // 
            this.Clickmebutt.Location = new System.Drawing.Point(62, 52);
            this.Clickmebutt.Name = "Clickmebutt";
            this.Clickmebutt.Size = new System.Drawing.Size(209, 78);
            this.Clickmebutt.TabIndex = 0;
            this.Clickmebutt.Text = "Click Me!";
            this.Clickmebutt.UseVisualStyleBackColor = true;
            this.Clickmebutt.Click += new System.EventHandler(this.Clickmebutt_Click);
            // 
            // Oopsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 173);
            this.Controls.Add(this.Clickmebutt);
            this.Name = "Oopsform";
            this.Text = "Oops";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Clickmebutt;
    }
}

