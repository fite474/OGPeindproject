namespace Eindproject
{
    partial class Player1Screen
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bo3Button = new System.Windows.Forms.Button();
            this.bo7Button = new System.Windows.Forms.Button();
            this.bo13Button = new System.Windows.Forms.Button();
            this.infiniteButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "choose a game mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bo3Button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bo7Button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bo13Button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.infiniteButton, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 277);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // bo3Button
            // 
            this.bo3Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bo3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bo3Button.Location = new System.Drawing.Point(3, 3);
            this.bo3Button.Name = "bo3Button";
            this.bo3Button.Size = new System.Drawing.Size(175, 132);
            this.bo3Button.TabIndex = 0;
            this.bo3Button.Text = "Best of 3";
            this.bo3Button.UseVisualStyleBackColor = true;
            this.bo3Button.Click += new System.EventHandler(this.bo3Button_Click);
            // 
            // bo7Button
            // 
            this.bo7Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bo7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bo7Button.Location = new System.Drawing.Point(184, 3);
            this.bo7Button.Name = "bo7Button";
            this.bo7Button.Size = new System.Drawing.Size(175, 132);
            this.bo7Button.TabIndex = 1;
            this.bo7Button.Text = "Best of 7";
            this.bo7Button.UseVisualStyleBackColor = true;
            this.bo7Button.Click += new System.EventHandler(this.bo7Button_Click);
            // 
            // bo13Button
            // 
            this.bo13Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bo13Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bo13Button.Location = new System.Drawing.Point(3, 141);
            this.bo13Button.Name = "bo13Button";
            this.bo13Button.Size = new System.Drawing.Size(175, 133);
            this.bo13Button.TabIndex = 2;
            this.bo13Button.Text = "Best of 13";
            this.bo13Button.UseVisualStyleBackColor = true;
            this.bo13Button.Click += new System.EventHandler(this.bo13Button_Click);
            // 
            // infiniteButton
            // 
            this.infiniteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infiniteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infiniteButton.Location = new System.Drawing.Point(184, 141);
            this.infiniteButton.Name = "infiniteButton";
            this.infiniteButton.Size = new System.Drawing.Size(175, 133);
            this.infiniteButton.TabIndex = 3;
            this.infiniteButton.Text = "Infinit Game mode";
            this.infiniteButton.UseVisualStyleBackColor = true;
            this.infiniteButton.Click += new System.EventHandler(this.infiniteButton_Click);
            // 
            // Player1Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 326);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Player1Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Start Challenge";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bo3Button;
        private System.Windows.Forms.Button bo7Button;
        private System.Windows.Forms.Button bo13Button;
        private System.Windows.Forms.Button infiniteButton;
    }
}