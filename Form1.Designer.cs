
namespace ImagesTest
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
            this.collisionCheckLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // collisionCheckLabel
            // 
            this.collisionCheckLabel.AutoSize = true;
            this.collisionCheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.collisionCheckLabel.Location = new System.Drawing.Point(1858, 1235);
            this.collisionCheckLabel.Name = "collisionCheckLabel";
            this.collisionCheckLabel.Size = new System.Drawing.Size(92, 32);
            this.collisionCheckLabel.TabIndex = 0;
            this.collisionCheckLabel.Text = "empty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2304, 1364);
            this.Controls.Add(this.collisionCheckLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label collisionCheckLabel;
    }
}

