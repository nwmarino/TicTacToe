namespace TicTacToe
{
    partial class Board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.boardCenter = new System.Windows.Forms.Button();
            this.boardRight = new System.Windows.Forms.Button();
            this.boardLeft = new System.Windows.Forms.Button();
            this.boardTop = new System.Windows.Forms.Button();
            this.boardBottom = new System.Windows.Forms.Button();
            this.boardTopLeft = new System.Windows.Forms.Button();
            this.boardTopRight = new System.Windows.Forms.Button();
            this.boardBottomLeft = new System.Windows.Forms.Button();
            this.boardBottomRight = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.TitlePic = new System.Windows.Forms.PictureBox();
            this.resetButton = new TicTacToe.RButton();
            this.scoreLabel = new TicTacToe.RLabel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.xPlayer = new System.Windows.Forms.RadioButton();
            this.oPlayer = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePic)).BeginInit();
            this.SuspendLayout();
            // 
            // boardCenter
            // 
            this.boardCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boardCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boardCenter.FlatAppearance.BorderSize = 0;
            this.boardCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.boardCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.boardCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boardCenter.Location = new System.Drawing.Point(248, 230);
            this.boardCenter.Name = "boardCenter";
            this.boardCenter.Size = new System.Drawing.Size(60, 60);
            this.boardCenter.TabIndex = 0;
            this.boardCenter.UseVisualStyleBackColor = false;
            this.boardCenter.Click += new System.EventHandler(this.boardCenter_Click);
            // 
            // boardRight
            // 
            this.boardRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boardRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boardRight.FlatAppearance.BorderSize = 0;
            this.boardRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.boardRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.boardRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boardRight.Location = new System.Drawing.Point(315, 230);
            this.boardRight.Name = "boardRight";
            this.boardRight.Size = new System.Drawing.Size(60, 60);
            this.boardRight.TabIndex = 1;
            this.boardRight.UseVisualStyleBackColor = false;
            this.boardRight.Click += new System.EventHandler(this.boardRight_Click);
            // 
            // boardLeft
            // 
            this.boardLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boardLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boardLeft.FlatAppearance.BorderSize = 0;
            this.boardLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.boardLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.boardLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boardLeft.Location = new System.Drawing.Point(181, 230);
            this.boardLeft.Name = "boardLeft";
            this.boardLeft.Size = new System.Drawing.Size(60, 60);
            this.boardLeft.TabIndex = 2;
            this.boardLeft.UseVisualStyleBackColor = false;
            this.boardLeft.Click += new System.EventHandler(this.boardLeft_Click);
            // 
            // boardTop
            // 
            this.boardTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boardTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boardTop.FlatAppearance.BorderSize = 0;
            this.boardTop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.boardTop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.boardTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boardTop.Location = new System.Drawing.Point(248, 163);
            this.boardTop.Name = "boardTop";
            this.boardTop.Size = new System.Drawing.Size(60, 60);
            this.boardTop.TabIndex = 3;
            this.boardTop.UseVisualStyleBackColor = false;
            this.boardTop.Click += new System.EventHandler(this.boardTop_Click);
            // 
            // boardBottom
            // 
            this.boardBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boardBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boardBottom.FlatAppearance.BorderSize = 0;
            this.boardBottom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.boardBottom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.boardBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boardBottom.Location = new System.Drawing.Point(248, 297);
            this.boardBottom.Name = "boardBottom";
            this.boardBottom.Size = new System.Drawing.Size(60, 60);
            this.boardBottom.TabIndex = 4;
            this.boardBottom.UseVisualStyleBackColor = false;
            this.boardBottom.Click += new System.EventHandler(this.boardBottom_Click);
            // 
            // boardTopLeft
            // 
            this.boardTopLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boardTopLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boardTopLeft.FlatAppearance.BorderSize = 0;
            this.boardTopLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.boardTopLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.boardTopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boardTopLeft.Location = new System.Drawing.Point(181, 163);
            this.boardTopLeft.Name = "boardTopLeft";
            this.boardTopLeft.Size = new System.Drawing.Size(60, 60);
            this.boardTopLeft.TabIndex = 5;
            this.boardTopLeft.UseVisualStyleBackColor = false;
            this.boardTopLeft.Click += new System.EventHandler(this.boardTopLeft_Click);
            // 
            // boardTopRight
            // 
            this.boardTopRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boardTopRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boardTopRight.FlatAppearance.BorderSize = 0;
            this.boardTopRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.boardTopRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.boardTopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boardTopRight.Location = new System.Drawing.Point(315, 163);
            this.boardTopRight.Name = "boardTopRight";
            this.boardTopRight.Size = new System.Drawing.Size(60, 60);
            this.boardTopRight.TabIndex = 6;
            this.boardTopRight.UseVisualStyleBackColor = false;
            this.boardTopRight.Click += new System.EventHandler(this.boardTopRight_Click);
            // 
            // boardBottomLeft
            // 
            this.boardBottomLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boardBottomLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boardBottomLeft.FlatAppearance.BorderSize = 0;
            this.boardBottomLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.boardBottomLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.boardBottomLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boardBottomLeft.Location = new System.Drawing.Point(181, 297);
            this.boardBottomLeft.Name = "boardBottomLeft";
            this.boardBottomLeft.Size = new System.Drawing.Size(60, 60);
            this.boardBottomLeft.TabIndex = 7;
            this.boardBottomLeft.UseVisualStyleBackColor = false;
            this.boardBottomLeft.Click += new System.EventHandler(this.boardBottomLeft_Click);
            // 
            // boardBottomRight
            // 
            this.boardBottomRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boardBottomRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boardBottomRight.FlatAppearance.BorderSize = 0;
            this.boardBottomRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.boardBottomRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.boardBottomRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boardBottomRight.Location = new System.Drawing.Point(315, 297);
            this.boardBottomRight.Name = "boardBottomRight";
            this.boardBottomRight.Size = new System.Drawing.Size(60, 60);
            this.boardBottomRight.TabIndex = 8;
            this.boardBottomRight.UseVisualStyleBackColor = false;
            this.boardBottomRight.Click += new System.EventHandler(this.boardBottomRight_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Borda 10", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(73, 36);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(109, 31);
            this.Title.TabIndex = 9;
            this.Title.Text = "TicTacToe";
            // 
            // TitlePic
            // 
            this.TitlePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TitlePic.Image = ((System.Drawing.Image)(resources.GetObject("TitlePic.Image")));
            this.TitlePic.Location = new System.Drawing.Point(25, 31);
            this.TitlePic.Name = "TitlePic";
            this.TitlePic.Size = new System.Drawing.Size(42, 42);
            this.TitlePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitlePic.TabIndex = 10;
            this.TitlePic.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.resetButton.buttonColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.resetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.hovering = false;
            this.resetButton.Location = new System.Drawing.Point(288, 379);
            this.resetButton.Name = "resetButton";
            this.resetButton.onHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.resetButton.onHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.resetButton.Size = new System.Drawing.Size(87, 37);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.textColor = System.Drawing.Color.White;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.scoreLabel.Location = new System.Drawing.Point(181, 375);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(87, 44);
            this.scoreLabel.TabIndex = 12;
            this.scoreLabel.textColor = System.Drawing.Color.White;
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(134, 121);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(293, 15);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Choose a player type!";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // xPlayer
            // 
            this.xPlayer.AutoSize = true;
            this.xPlayer.Location = new System.Drawing.Point(459, 47);
            this.xPlayer.Name = "xPlayer";
            this.xPlayer.Size = new System.Drawing.Size(31, 19);
            this.xPlayer.TabIndex = 14;
            this.xPlayer.TabStop = true;
            this.xPlayer.Text = "x";
            this.xPlayer.UseVisualStyleBackColor = true;
            this.xPlayer.CheckedChanged += new System.EventHandler(this.xPlayer_CheckedChanged);
            // 
            // oPlayer
            // 
            this.oPlayer.AutoSize = true;
            this.oPlayer.Location = new System.Drawing.Point(496, 47);
            this.oPlayer.Name = "oPlayer";
            this.oPlayer.Size = new System.Drawing.Size(32, 19);
            this.oPlayer.TabIndex = 15;
            this.oPlayer.TabStop = true;
            this.oPlayer.Text = "o";
            this.oPlayer.UseVisualStyleBackColor = true;
            this.oPlayer.CheckedChanged += new System.EventHandler(this.oPlayer_CheckedChanged);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(560, 537);
            this.Controls.Add(this.oPlayer);
            this.Controls.Add(this.xPlayer);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.TitlePic);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.boardBottomRight);
            this.Controls.Add(this.boardBottomLeft);
            this.Controls.Add(this.boardTopRight);
            this.Controls.Add(this.boardTopLeft);
            this.Controls.Add(this.boardBottom);
            this.Controls.Add(this.boardTop);
            this.Controls.Add(this.boardLeft);
            this.Controls.Add(this.boardRight);
            this.Controls.Add(this.boardCenter);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Board";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TitlePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button boardCenter;
        private Button boardRight;
        private Button boardLeft;
        private Button boardTop;
        private Button boardBottom;
        private Button boardTopLeft;
        private Button boardTopRight;
        private Button boardBottomLeft;
        private Button boardBottomRight;
        private Label Title;
        private PictureBox TitlePic;
        private RButton resetButton;
        private RLabel scoreLabel;
        private Label titleLabel;
        private RadioButton xPlayer;
        private RadioButton oPlayer;
    }
}