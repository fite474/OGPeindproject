namespace Eindproject
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
            this.lizardButton = new System.Windows.Forms.Button();
            this.spockButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreplayer1 = new System.Windows.Forms.Label();
            this.scoreplayer2 = new System.Windows.Forms.Label();
            this.player1choice = new System.Windows.Forms.PictureBox();
            this.player2choice = new System.Windows.Forms.PictureBox();
            this.WinLosePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RoundsLeftLabel = new System.Windows.Forms.Label();
            this.WinLoseLabel = new System.Windows.Forms.Label();
            this.Player1IndicatorLabel = new System.Windows.Forms.Label();
            this.Player2IndicatorLabel = new System.Windows.Forms.Label();
            this.WinnerIndicatorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1choice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2choice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinLosePictureBox)).BeginInit();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.Controls.Add(this.rockbutton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.paperbutton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.scissorbutton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lizardButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.spockButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.scoreLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.scoreplayer1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.scoreplayer2, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.player1choice, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.player2choice, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.WinLosePictureBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.RoundsLeftLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.WinLoseLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Player1IndicatorLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Player2IndicatorLabel, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.WinnerIndicatorLabel, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(945, 563);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rockbutton
            // 
            this.rockbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rockbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rockbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockbutton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rockbutton.Location = new System.Drawing.Point(3, 59);
            this.rockbutton.Name = "rockbutton";
            this.rockbutton.Size = new System.Drawing.Size(105, 95);
            this.rockbutton.TabIndex = 0;
            this.rockbutton.Text = "Rock";
            this.rockbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rockbutton.UseVisualStyleBackColor = true;
            this.rockbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // paperbutton
            // 
            this.paperbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paperbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paperbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.paperbutton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.paperbutton.Location = new System.Drawing.Point(3, 160);
            this.paperbutton.Name = "paperbutton";
            this.paperbutton.Size = new System.Drawing.Size(105, 95);
            this.paperbutton.TabIndex = 1;
            this.paperbutton.Text = "Paper";
            this.paperbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.paperbutton.UseVisualStyleBackColor = true;
            this.paperbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // scissorbutton
            // 
            this.scissorbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scissorbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scissorbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.scissorbutton.Location = new System.Drawing.Point(3, 261);
            this.scissorbutton.Name = "scissorbutton";
            this.scissorbutton.Size = new System.Drawing.Size(105, 95);
            this.scissorbutton.TabIndex = 2;
            this.scissorbutton.Text = "Scissors";
            this.scissorbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.scissorbutton.UseVisualStyleBackColor = true;
            this.scissorbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // lizardButton
            // 
            this.lizardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lizardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lizardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lizardButton.Location = new System.Drawing.Point(3, 362);
            this.lizardButton.Name = "lizardButton";
            this.lizardButton.Size = new System.Drawing.Size(105, 95);
            this.lizardButton.TabIndex = 3;
            this.lizardButton.Text = "Lizard";
            this.lizardButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lizardButton.UseVisualStyleBackColor = true;
            this.lizardButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // spockButton
            // 
            this.spockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.spockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.spockButton.Location = new System.Drawing.Point(3, 463);
            this.spockButton.Name = "spockButton";
            this.spockButton.Size = new System.Drawing.Size(105, 97);
            this.spockButton.TabIndex = 4;
            this.spockButton.Text = "Spock";
            this.spockButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.spockButton.UseVisualStyleBackColor = true;
            this.spockButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(513, 21);
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
            this.scoreplayer1.Location = new System.Drawing.Point(661, 21);
            this.scoreplayer1.Name = "scoreplayer1";
            this.scoreplayer1.Size = new System.Drawing.Size(133, 13);
            this.scoreplayer1.TabIndex = 6;
            this.scoreplayer1.Text = "player1";
            // 
            // scoreplayer2
            // 
            this.scoreplayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreplayer2.AutoSize = true;
            this.scoreplayer2.Location = new System.Drawing.Point(800, 21);
            this.scoreplayer2.Name = "scoreplayer2";
            this.scoreplayer2.Size = new System.Drawing.Size(142, 13);
            this.scoreplayer2.TabIndex = 7;
            this.scoreplayer2.Text = "label1";
            // 
            // player1choice
            // 
            this.player1choice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player1choice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player1choice.Location = new System.Drawing.Point(367, 261);
            this.player1choice.Name = "player1choice";
            this.player1choice.Size = new System.Drawing.Size(140, 95);
            this.player1choice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player1choice.TabIndex = 8;
            this.player1choice.TabStop = false;
            this.player1choice.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // player2choice
            // 
            this.player2choice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player2choice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player2choice.Location = new System.Drawing.Point(661, 261);
            this.player2choice.Name = "player2choice";
            this.player2choice.Size = new System.Drawing.Size(133, 95);
            this.player2choice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player2choice.TabIndex = 9;
            this.player2choice.TabStop = false;
            // 
            // WinLosePictureBox
            // 
            this.WinLosePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WinLosePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WinLosePictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.WinLosePictureBox.Location = new System.Drawing.Point(513, 362);
            this.WinLosePictureBox.Name = "WinLosePictureBox";
            this.WinLosePictureBox.Size = new System.Drawing.Size(142, 95);
            this.WinLosePictureBox.TabIndex = 10;
            this.WinLosePictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 201);
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
            this.RoundsLeftLabel.Location = new System.Drawing.Point(114, 15);
            this.RoundsLeftLabel.Name = "RoundsLeftLabel";
            this.RoundsLeftLabel.Size = new System.Drawing.Size(247, 25);
            this.RoundsLeftLabel.TabIndex = 12;
            this.RoundsLeftLabel.Text = "Rounds left:";
            this.RoundsLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinLoseLabel
            // 
            this.WinLoseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WinLoseLabel.AutoSize = true;
            this.WinLoseLabel.Location = new System.Drawing.Point(367, 201);
            this.WinLoseLabel.Name = "WinLoseLabel";
            this.WinLoseLabel.Size = new System.Drawing.Size(140, 13);
            this.WinLoseLabel.TabIndex = 13;
            this.WinLoseLabel.Text = "Jeh, winde nou ofnie?";
            this.WinLoseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WinLoseLabel.Visible = false;
            // 
            // Player1IndicatorLabel
            // 
            this.Player1IndicatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player1IndicatorLabel.AutoSize = true;
            this.Player1IndicatorLabel.Location = new System.Drawing.Point(367, 359);
            this.Player1IndicatorLabel.Name = "Player1IndicatorLabel";
            this.Player1IndicatorLabel.Size = new System.Drawing.Size(140, 13);
            this.Player1IndicatorLabel.TabIndex = 14;
            this.Player1IndicatorLabel.Text = "Your choice ^";
            this.Player1IndicatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player1IndicatorLabel.Visible = false;
            // 
            // Player2IndicatorLabel
            // 
            this.Player2IndicatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2IndicatorLabel.AutoSize = true;
            this.Player2IndicatorLabel.Location = new System.Drawing.Point(661, 359);
            this.Player2IndicatorLabel.Name = "Player2IndicatorLabel";
            this.Player2IndicatorLabel.Size = new System.Drawing.Size(133, 13);
            this.Player2IndicatorLabel.TabIndex = 15;
            this.Player2IndicatorLabel.Text = "^ Other players choice";
            this.Player2IndicatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player2IndicatorLabel.Visible = false;
            // 
            // WinnerIndicatorLabel
            // 
            this.WinnerIndicatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WinnerIndicatorLabel.AutoSize = true;
            this.WinnerIndicatorLabel.Location = new System.Drawing.Point(513, 346);
            this.WinnerIndicatorLabel.Name = "WinnerIndicatorLabel";
            this.WinnerIndicatorLabel.Size = new System.Drawing.Size(142, 13);
            this.WinnerIndicatorLabel.TabIndex = 16;
            this.WinnerIndicatorLabel.Text = "Did you win?";
            this.WinnerIndicatorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WinnerIndicatorLabel.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.WinLosePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button rockbutton;
        private System.Windows.Forms.Button paperbutton;
        private System.Windows.Forms.Button scissorbutton;
        private System.Windows.Forms.Button lizardButton;
        private System.Windows.Forms.Button spockButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreplayer1;
        private System.Windows.Forms.Label scoreplayer2;
        private System.Windows.Forms.PictureBox player1choice;
        private System.Windows.Forms.PictureBox player2choice;
        private System.Windows.Forms.PictureBox WinLosePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RoundsLeftLabel;
        private System.Windows.Forms.Label WinLoseLabel;
        private System.Windows.Forms.Label Player1IndicatorLabel;
        private System.Windows.Forms.Label Player2IndicatorLabel;
        private System.Windows.Forms.Label WinnerIndicatorLabel;
    }
}