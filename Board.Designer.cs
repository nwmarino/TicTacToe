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
            this.Title = new System.Windows.Forms.Label();
            this.TitlePic = new System.Windows.Forms.PictureBox();
            this.resetButton = new TicTacToe.RButton();
            this.scoreLabel = new TicTacToe.RLabel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.xPlayer = new System.Windows.Forms.RadioButton();
            this.oPlayer = new System.Windows.Forms.RadioButton();
            this.tlTile = new TicTacToe.Tile();
            this.tTile = new TicTacToe.Tile();
            this.trTile = new TicTacToe.Tile();
            this.lTile = new TicTacToe.Tile();
            this.cTile = new TicTacToe.Tile();
            this.rTile = new TicTacToe.Tile();
            this.blTile = new TicTacToe.Tile();
            this.bTile = new TicTacToe.Tile();
            this.brTile = new TicTacToe.Tile();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePic)).BeginInit();
            this.SuspendLayout();
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
            this.scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
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
            // tlTile
            // 
            this.tlTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tlTile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlTile.FlatAppearance.BorderSize = 0;
            this.tlTile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tlTile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tlTile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlTile.Location = new System.Drawing.Point(181, 172);
            this.tlTile.Name = "tlTile";
            this.tlTile.Size = new System.Drawing.Size(60, 60);
            this.tlTile.TabIndex = 16;
            this.tlTile.type = '0';
            this.tlTile.UseVisualStyleBackColor = false;
            this.tlTile.Click += new System.EventHandler(this.tlTile_Click);
            // 
            // tTile
            // 
            this.tTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tTile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tTile.FlatAppearance.BorderSize = 0;
            this.tTile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tTile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tTile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tTile.Location = new System.Drawing.Point(247, 172);
            this.tTile.Name = "tTile";
            this.tTile.Size = new System.Drawing.Size(60, 60);
            this.tTile.TabIndex = 17;
            this.tTile.type = '0';
            this.tTile.UseVisualStyleBackColor = false;
            this.tTile.Click += new System.EventHandler(this.tTile_Click);
            // 
            // trTile
            // 
            this.trTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trTile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trTile.FlatAppearance.BorderSize = 0;
            this.trTile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.trTile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.trTile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trTile.Location = new System.Drawing.Point(313, 172);
            this.trTile.Name = "trTile";
            this.trTile.Size = new System.Drawing.Size(60, 60);
            this.trTile.TabIndex = 18;
            this.trTile.type = '0';
            this.trTile.UseVisualStyleBackColor = false;
            this.trTile.Click += new System.EventHandler(this.trTile_Click);
            // 
            // lTile
            // 
            this.lTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lTile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lTile.FlatAppearance.BorderSize = 0;
            this.lTile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lTile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lTile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lTile.Location = new System.Drawing.Point(181, 238);
            this.lTile.Name = "lTile";
            this.lTile.Size = new System.Drawing.Size(60, 60);
            this.lTile.TabIndex = 19;
            this.lTile.type = '0';
            this.lTile.UseVisualStyleBackColor = false;
            this.lTile.Click += new System.EventHandler(this.lTile_Click);
            // 
            // cTile
            // 
            this.cTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cTile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cTile.FlatAppearance.BorderSize = 0;
            this.cTile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cTile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cTile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cTile.Location = new System.Drawing.Point(247, 238);
            this.cTile.Name = "cTile";
            this.cTile.Size = new System.Drawing.Size(60, 60);
            this.cTile.TabIndex = 20;
            this.cTile.type = '0';
            this.cTile.UseVisualStyleBackColor = false;
            this.cTile.Click += new System.EventHandler(this.cTile_Click);
            // 
            // rTile
            // 
            this.rTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rTile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rTile.FlatAppearance.BorderSize = 0;
            this.rTile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rTile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rTile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rTile.Location = new System.Drawing.Point(313, 238);
            this.rTile.Name = "rTile";
            this.rTile.Size = new System.Drawing.Size(60, 60);
            this.rTile.TabIndex = 21;
            this.rTile.type = '0';
            this.rTile.UseVisualStyleBackColor = false;
            this.rTile.Click += new System.EventHandler(this.rTile_Click);
            // 
            // blTile
            // 
            this.blTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.blTile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blTile.FlatAppearance.BorderSize = 0;
            this.blTile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.blTile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.blTile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blTile.Location = new System.Drawing.Point(181, 304);
            this.blTile.Name = "blTile";
            this.blTile.Size = new System.Drawing.Size(60, 60);
            this.blTile.TabIndex = 22;
            this.blTile.type = '0';
            this.blTile.UseVisualStyleBackColor = false;
            this.blTile.Click += new System.EventHandler(this.blTile_Click);
            // 
            // bTile
            // 
            this.bTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bTile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bTile.FlatAppearance.BorderSize = 0;
            this.bTile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bTile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bTile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTile.Location = new System.Drawing.Point(247, 304);
            this.bTile.Name = "bTile";
            this.bTile.Size = new System.Drawing.Size(60, 60);
            this.bTile.TabIndex = 23;
            this.bTile.type = '0';
            this.bTile.UseVisualStyleBackColor = false;
            this.bTile.Click += new System.EventHandler(this.bTile_Click);
            // 
            // brTile
            // 
            this.brTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brTile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brTile.FlatAppearance.BorderSize = 0;
            this.brTile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.brTile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.brTile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brTile.Location = new System.Drawing.Point(313, 304);
            this.brTile.Name = "brTile";
            this.brTile.Size = new System.Drawing.Size(60, 60);
            this.brTile.TabIndex = 24;
            this.brTile.type = '0';
            this.brTile.UseVisualStyleBackColor = false;
            this.brTile.Click += new System.EventHandler(this.brTile_Click);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(560, 537);
            this.Controls.Add(this.brTile);
            this.Controls.Add(this.bTile);
            this.Controls.Add(this.blTile);
            this.Controls.Add(this.rTile);
            this.Controls.Add(this.cTile);
            this.Controls.Add(this.lTile);
            this.Controls.Add(this.trTile);
            this.Controls.Add(this.tTile);
            this.Controls.Add(this.tlTile);
            this.Controls.Add(this.oPlayer);
            this.Controls.Add(this.xPlayer);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.TitlePic);
            this.Controls.Add(this.Title);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Board";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TitlePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Title;
        private PictureBox TitlePic;
        private RButton resetButton;
        private RLabel scoreLabel;
        private Label titleLabel;
        private RadioButton xPlayer;
        private RadioButton oPlayer;
        private Tile tlTile;
        private Tile tTile;
        private Tile trTile;
        private Tile lTile;
        private Tile cTile;
        private Tile rTile;
        private Tile blTile;
        private Tile bTile;
        private Tile brTile;
    }
}