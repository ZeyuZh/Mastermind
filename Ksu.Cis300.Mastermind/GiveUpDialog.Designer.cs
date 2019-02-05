namespace Ksu.Cis300.Mastermind
{
    partial class uxGiveUp
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
            this.uxGiveupMessage = new System.Windows.Forms.Label();
            this.uxCode = new System.Windows.Forms.TextBox();
            this.uxEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxGiveupMessage
            // 
            this.uxGiveupMessage.AutoSize = true;
            this.uxGiveupMessage.Location = new System.Drawing.Point(12, 9);
            this.uxGiveupMessage.Name = "uxGiveupMessage";
            this.uxGiveupMessage.Size = new System.Drawing.Size(183, 15);
            this.uxGiveupMessage.TabIndex = 0;
            this.uxGiveupMessage.Text = "I give up. Please enter your code";
            // 
            // uxCode
            // 
            this.uxCode.Location = new System.Drawing.Point(15, 37);
            this.uxCode.Name = "uxCode";
            this.uxCode.Size = new System.Drawing.Size(180, 21);
            this.uxCode.TabIndex = 1;
            // 
            // uxEnter
            // 
            this.uxEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxEnter.Location = new System.Drawing.Point(15, 64);
            this.uxEnter.Name = "uxEnter";
            this.uxEnter.Size = new System.Drawing.Size(180, 31);
            this.uxEnter.TabIndex = 2;
            this.uxEnter.Text = "Enter";
            this.uxEnter.UseVisualStyleBackColor = true;
            // 
            // uxGiveUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 108);
            this.Controls.Add(this.uxEnter);
            this.Controls.Add(this.uxCode);
            this.Controls.Add(this.uxGiveupMessage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "uxGiveUp";
            this.Text = "I Give Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxGiveupMessage;
        private System.Windows.Forms.TextBox uxCode;
        private System.Windows.Forms.Button uxEnter;
    }
}