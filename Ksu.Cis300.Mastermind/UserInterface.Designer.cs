namespace Ksu.Cis300.Mastermind
{
    partial class uxUserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxUserInterface));
            this.uxToolStrip = new System.Windows.Forms.ToolStrip();
            this.uxOpen = new System.Windows.Forms.ToolStripButton();
            this.uxNew = new System.Windows.Forms.ToolStripButton();
            this.uxList = new System.Windows.Forms.ListView();
            this.uxPlay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxGuess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxBlack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxWhite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxBlackNumeric = new System.Windows.Forms.NumericUpDown();
            this.uxWhiteNumeric = new System.Windows.Forms.NumericUpDown();
            this.uxBlackLabel = new System.Windows.Forms.Label();
            this.uxWhiteLable = new System.Windows.Forms.Label();
            this.uxConfirm = new System.Windows.Forms.Button();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxBlackNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxWhiteNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // uxToolStrip
            // 
            this.uxToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpen,
            this.uxNew});
            this.uxToolStrip.Location = new System.Drawing.Point(0, 0);
            this.uxToolStrip.Name = "uxToolStrip";
            this.uxToolStrip.Size = new System.Drawing.Size(260, 25);
            this.uxToolStrip.TabIndex = 0;
            this.uxToolStrip.Text = "toolStrip1";
            // 
            // uxOpen
            // 
            this.uxOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxOpen.Image = ((System.Drawing.Image)(resources.GetObject("uxOpen.Image")));
            this.uxOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(119, 22);
            this.uxOpen.Text = "Open Strategy File";
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxNew
            // 
            this.uxNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxNew.Enabled = false;
            this.uxNew.Image = ((System.Drawing.Image)(resources.GetObject("uxNew.Image")));
            this.uxNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxNew.Name = "uxNew";
            this.uxNew.Size = new System.Drawing.Size(76, 22);
            this.uxNew.Text = "New Game";
            this.uxNew.Click += new System.EventHandler(this.uxNew_Click);
            // 
            // uxList
            // 
            this.uxList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uxPlay,
            this.uxGuess,
            this.uxBlack,
            this.uxWhite});
            this.uxList.GridLines = true;
            this.uxList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.uxList.Location = new System.Drawing.Point(14, 36);
            this.uxList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxList.Name = "uxList";
            this.uxList.Size = new System.Drawing.Size(224, 237);
            this.uxList.TabIndex = 1;
            this.uxList.UseCompatibleStateImageBehavior = false;
            this.uxList.View = System.Windows.Forms.View.Details;
            // 
            // uxPlay
            // 
            this.uxPlay.Text = "Play";
            this.uxPlay.Width = 35;
            // 
            // uxGuess
            // 
            this.uxGuess.Text = "Guess";
            this.uxGuess.Width = 47;
            // 
            // uxBlack
            // 
            this.uxBlack.Text = "Black Hits";
            this.uxBlack.Width = 66;
            // 
            // uxWhite
            // 
            this.uxWhite.Text = "White Hits";
            this.uxWhite.Width = 119;
            // 
            // uxBlackNumeric
            // 
            this.uxBlackNumeric.Location = new System.Drawing.Point(82, 279);
            this.uxBlackNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxBlackNumeric.Name = "uxBlackNumeric";
            this.uxBlackNumeric.Size = new System.Drawing.Size(31, 21);
            this.uxBlackNumeric.TabIndex = 2;
            this.uxBlackNumeric.ValueChanged += new System.EventHandler(this.uxBlackNumeric_ValueChanged);
            // 
            // uxWhiteNumeric
            // 
            this.uxWhiteNumeric.Location = new System.Drawing.Point(203, 281);
            this.uxWhiteNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxWhiteNumeric.Name = "uxWhiteNumeric";
            this.uxWhiteNumeric.Size = new System.Drawing.Size(30, 21);
            this.uxWhiteNumeric.TabIndex = 3;
            // 
            // uxBlackLabel
            // 
            this.uxBlackLabel.AutoSize = true;
            this.uxBlackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBlackLabel.Location = new System.Drawing.Point(14, 281);
            this.uxBlackLabel.Name = "uxBlackLabel";
            this.uxBlackLabel.Size = new System.Drawing.Size(64, 15);
            this.uxBlackLabel.TabIndex = 4;
            this.uxBlackLabel.Text = "Black Hits:";
            // 
            // uxWhiteLable
            // 
            this.uxWhiteLable.AutoSize = true;
            this.uxWhiteLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWhiteLable.Location = new System.Drawing.Point(132, 281);
            this.uxWhiteLable.Name = "uxWhiteLable";
            this.uxWhiteLable.Size = new System.Drawing.Size(65, 15);
            this.uxWhiteLable.TabIndex = 5;
            this.uxWhiteLable.Text = "White Hits:";
            // 
            // uxConfirm
            // 
            this.uxConfirm.Enabled = false;
            this.uxConfirm.Location = new System.Drawing.Point(17, 310);
            this.uxConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxConfirm.Name = "uxConfirm";
            this.uxConfirm.Size = new System.Drawing.Size(221, 29);
            this.uxConfirm.TabIndex = 6;
            this.uxConfirm.Text = "Confirm Hits";
            this.uxConfirm.UseVisualStyleBackColor = true;
            this.uxConfirm.Click += new System.EventHandler(this.uxConfirm_Click);
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.FileName = "openFileDialog1";
            this.uxOpenDialog.Filter = "XML files|*.xml|All files|*.*";
            this.uxOpenDialog.Title = "Open Strategy File";
            // 
            // uxUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 346);
            this.Controls.Add(this.uxConfirm);
            this.Controls.Add(this.uxWhiteLable);
            this.Controls.Add(this.uxBlackLabel);
            this.Controls.Add(this.uxWhiteNumeric);
            this.Controls.Add(this.uxBlackNumeric);
            this.Controls.Add(this.uxList);
            this.Controls.Add(this.uxToolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "uxUserInterface";
            this.Text = "Matermind";
            this.uxToolStrip.ResumeLayout(false);
            this.uxToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxBlackNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxWhiteNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip uxToolStrip;
        private System.Windows.Forms.ToolStripButton uxOpen;
        private System.Windows.Forms.ToolStripButton uxNew;
        private System.Windows.Forms.ListView uxList;
        private System.Windows.Forms.ColumnHeader uxPlay;
        private System.Windows.Forms.ColumnHeader uxGuess;
        private System.Windows.Forms.ColumnHeader uxBlack;
        private System.Windows.Forms.ColumnHeader uxWhite;
        private System.Windows.Forms.NumericUpDown uxBlackNumeric;
        private System.Windows.Forms.NumericUpDown uxWhiteNumeric;
        private System.Windows.Forms.Label uxBlackLabel;
        private System.Windows.Forms.Label uxWhiteLable;
        private System.Windows.Forms.Button uxConfirm;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
    }
}

