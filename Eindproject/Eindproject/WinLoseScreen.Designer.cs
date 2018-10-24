using System;

namespace Eindproject
{
    partial class WinLoseScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinLoseScreen));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.WinLoseLabel = new System.Windows.Forms.Label();
            this.WinOrLosePictureBox = new System.Windows.Forms.PictureBox();
            this.GameResultPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinOrLosePictureBox)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GameResultPanel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.WinLoseLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.WinOrLosePictureBox, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // WinLoseLabel
            // 
            resources.ApplyResources(this.WinLoseLabel, "WinLoseLabel");
            this.WinLoseLabel.Name = "WinLoseLabel";
            // 
            // WinOrLosePictureBox
            // 
            resources.ApplyResources(this.WinOrLosePictureBox, "WinOrLosePictureBox");
            this.WinOrLosePictureBox.Name = "WinOrLosePictureBox";
            this.WinOrLosePictureBox.TabStop = false;
            // 
            // GameResultPanel
            // 
            resources.ApplyResources(this.GameResultPanel, "GameResultPanel");
            this.GameResultPanel.Name = "GameResultPanel";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.FileNameLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.SaveFileButton, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.FileNameTextBox, 0, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // FileNameLabel
            // 
            resources.ApplyResources(this.FileNameLabel, "FileNameLabel");
            this.FileNameLabel.Name = "FileNameLabel";
            // 
            // SaveFileButton
            // 
            resources.ApplyResources(this.SaveFileButton, "SaveFileButton");
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.AcceptsTab = true;
            resources.ApplyResources(this.FileNameTextBox, "FileNameTextBox");
            this.FileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.TextChanged += new System.EventHandler(this.FileNameTextBox_TextChanged);
            // 
            // WinLoseScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WinLoseScreen";
            this.Load += new System.EventHandler(this.WinLoseScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinOrLosePictureBox)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        



        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label WinLoseLabel;
        private System.Windows.Forms.PictureBox WinOrLosePictureBox;
        private System.Windows.Forms.Panel GameResultPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.TextBox FileNameTextBox;
    }
}