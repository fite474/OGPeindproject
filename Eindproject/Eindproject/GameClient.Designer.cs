﻿namespace Eindproject
{
    partial class GameClient
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rockbutton = new System.Windows.Forms.Button();
            this.paperbutton = new System.Windows.Forms.Button();
            this.scissorbutton = new System.Windows.Forms.Button();
            this.pockbutton = new System.Windows.Forms.Button();
            this.lizardbutton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreplayer1 = new System.Windows.Forms.Label();
            this.scoreplayer2 = new System.Windows.Forms.Label();
            this.player1choice = new System.Windows.Forms.PictureBox();
            this.player2choice = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RoundsLeftLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1choice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2choice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.43478F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.56522F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.Controls.Add(this.rockbutton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.paperbutton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.scissorbutton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pockbutton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lizardbutton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.scoreLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.scoreplayer1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.scoreplayer2, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.player1choice, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.player2choice, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.RoundsLeftLabel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.06569F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.93431F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(945, 563);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rockbutton
            // 
            this.rockbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rockbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rockbutton.Location = new System.Drawing.Point(3, 93);
            this.rockbutton.Name = "rockbutton";
            this.rockbutton.Size = new System.Drawing.Size(105, 114);
            this.rockbutton.TabIndex = 0;
            this.rockbutton.Text = "button1";
            this.rockbutton.UseVisualStyleBackColor = true;
            this.rockbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // paperbutton
            // 
            this.paperbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paperbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paperbutton.Location = new System.Drawing.Point(3, 213);
            this.paperbutton.Name = "paperbutton";
            this.paperbutton.Size = new System.Drawing.Size(105, 90);
            this.paperbutton.TabIndex = 1;
            this.paperbutton.Text = "button2";
            this.paperbutton.UseVisualStyleBackColor = true;
            this.paperbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // scissorbutton
            // 
            this.scissorbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scissorbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scissorbutton.Location = new System.Drawing.Point(3, 309);
            this.scissorbutton.Name = "scissorbutton";
            this.scissorbutton.Size = new System.Drawing.Size(105, 79);
            this.scissorbutton.TabIndex = 2;
            this.scissorbutton.Text = "button3";
            this.scissorbutton.UseVisualStyleBackColor = true;
            this.scissorbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // pockbutton
            // 
            this.pockbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pockbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pockbutton.Location = new System.Drawing.Point(3, 394);
            this.pockbutton.Name = "pockbutton";
            this.pockbutton.Size = new System.Drawing.Size(105, 84);
            this.pockbutton.TabIndex = 3;
            this.pockbutton.Text = "button4";
            this.pockbutton.UseVisualStyleBackColor = true;
            this.pockbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // lizardbutton
            // 
            this.lizardbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lizardbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lizardbutton.Location = new System.Drawing.Point(3, 484);
            this.lizardbutton.Name = "lizardbutton";
            this.lizardbutton.Size = new System.Drawing.Size(105, 76);
            this.lizardbutton.TabIndex = 4;
            this.lizardbutton.Text = "button5";
            this.lizardbutton.UseVisualStyleBackColor = true;
            this.lizardbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(515, 38);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(142, 13);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "Score";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreplayer1
            // 
            this.scoreplayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreplayer1.AutoSize = true;
            this.scoreplayer1.Location = new System.Drawing.Point(663, 38);
            this.scoreplayer1.Name = "scoreplayer1";
            this.scoreplayer1.Size = new System.Drawing.Size(133, 13);
            this.scoreplayer1.TabIndex = 6;
            this.scoreplayer1.Text = "player1";
            // 
            // scoreplayer2
            // 
            this.scoreplayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreplayer2.AutoSize = true;
            this.scoreplayer2.Location = new System.Drawing.Point(802, 38);
            this.scoreplayer2.Name = "scoreplayer2";
            this.scoreplayer2.Size = new System.Drawing.Size(140, 13);
            this.scoreplayer2.TabIndex = 7;
            this.scoreplayer2.Text = "label1";
            // 
            // player1choice
            // 
            this.player1choice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player1choice.Location = new System.Drawing.Point(369, 309);
            this.player1choice.Name = "player1choice";
            this.player1choice.Size = new System.Drawing.Size(140, 79);
            this.player1choice.TabIndex = 8;
            this.player1choice.TabStop = false;
            this.player1choice.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // player2choice
            // 
            this.player2choice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player2choice.Location = new System.Drawing.Point(663, 309);
            this.player2choice.Name = "player2choice";
            this.player2choice.Size = new System.Drawing.Size(133, 79);
            this.player2choice.TabIndex = 9;
            this.player2choice.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(515, 394);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 84);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Last Game Result";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoundsLeftLabel
            // 
            this.RoundsLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RoundsLeftLabel.AutoSize = true;
            this.RoundsLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.RoundsLeftLabel.Location = new System.Drawing.Point(114, 32);
            this.RoundsLeftLabel.Name = "RoundsLeftLabel";
            this.RoundsLeftLabel.Size = new System.Drawing.Size(249, 25);
            this.RoundsLeftLabel.TabIndex = 12;
            this.RoundsLeftLabel.Text = "Rounds left:";
            this.RoundsLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 587);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameClient";
            this.Text = "Rock Paper Scissors Spock Lizard Game";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1choice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2choice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button rockbutton;
        private System.Windows.Forms.Button paperbutton;
        private System.Windows.Forms.Button scissorbutton;
        private System.Windows.Forms.Button pockbutton;
        private System.Windows.Forms.Button lizardbutton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreplayer1;
        private System.Windows.Forms.Label scoreplayer2;
        private System.Windows.Forms.PictureBox player1choice;
        private System.Windows.Forms.PictureBox player2choice;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RoundsLeftLabel;
    }
}