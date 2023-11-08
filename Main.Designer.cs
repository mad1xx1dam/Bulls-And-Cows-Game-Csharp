namespace BullsAndCows
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.newGameButton = new System.Windows.Forms.Button();
            this.gameInfoButton = new System.Windows.Forms.Button();
            this.surrenderButton = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.adviceButton = new System.Windows.Forms.Button();
            this.authorButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.soundButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.Color.Transparent;
            this.newGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newGameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGameButton.ForeColor = System.Drawing.SystemColors.Control;
            this.newGameButton.Location = new System.Drawing.Point(0, 0);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(160, 50);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "НОВАЯ ИГРА";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // gameInfoButton
            // 
            this.gameInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.gameInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gameInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameInfoButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameInfoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.gameInfoButton.Location = new System.Drawing.Point(320, 0);
            this.gameInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.gameInfoButton.Name = "gameInfoButton";
            this.gameInfoButton.Size = new System.Drawing.Size(160, 50);
            this.gameInfoButton.TabIndex = 1;
            this.gameInfoButton.Text = "СМЫСЛ ИГРЫ";
            this.gameInfoButton.UseVisualStyleBackColor = false;
            this.gameInfoButton.Click += new System.EventHandler(this.gameInfoButton_Click);
            // 
            // surrenderButton
            // 
            this.surrenderButton.BackColor = System.Drawing.Color.Transparent;
            this.surrenderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.surrenderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.surrenderButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surrenderButton.ForeColor = System.Drawing.SystemColors.Control;
            this.surrenderButton.Location = new System.Drawing.Point(160, 0);
            this.surrenderButton.Margin = new System.Windows.Forms.Padding(2);
            this.surrenderButton.Name = "surrenderButton";
            this.surrenderButton.Size = new System.Drawing.Size(160, 50);
            this.surrenderButton.TabIndex = 2;
            this.surrenderButton.Text = "СДАТЬСЯ";
            this.surrenderButton.UseVisualStyleBackColor = false;
            this.surrenderButton.Click += new System.EventHandler(this.surrenderButton_Click);
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.Color.Navy;
            this.inputText.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputText.ForeColor = System.Drawing.SystemColors.Control;
            this.inputText.Location = new System.Drawing.Point(244, 144);
            this.inputText.Margin = new System.Windows.Forms.Padding(2);
            this.inputText.MaxLength = 4;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(160, 34);
            this.inputText.TabIndex = 3;
            this.inputText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputText_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(239, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ваша попытка:";
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.RoyalBlue;
            this.outputText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputText.ForeColor = System.Drawing.SystemColors.Control;
            this.outputText.Location = new System.Drawing.Point(188, 225);
            this.outputText.Margin = new System.Windows.Forms.Padding(2);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(427, 300);
            this.outputText.TabIndex = 6;
            this.outputText.Text = "";
            // 
            // adviceButton
            // 
            this.adviceButton.BackColor = System.Drawing.Color.Transparent;
            this.adviceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adviceButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adviceButton.ForeColor = System.Drawing.SystemColors.Control;
            this.adviceButton.Location = new System.Drawing.Point(480, 0);
            this.adviceButton.Margin = new System.Windows.Forms.Padding(2);
            this.adviceButton.Name = "adviceButton";
            this.adviceButton.Size = new System.Drawing.Size(160, 50);
            this.adviceButton.TabIndex = 8;
            this.adviceButton.Text = "СПРАВКА";
            this.adviceButton.UseVisualStyleBackColor = false;
            this.adviceButton.Click += new System.EventHandler(this.adviceButton_Click);
            // 
            // authorButton
            // 
            this.authorButton.BackColor = System.Drawing.Color.Transparent;
            this.authorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.authorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorButton.ForeColor = System.Drawing.SystemColors.Control;
            this.authorButton.Location = new System.Drawing.Point(640, 0);
            this.authorButton.Margin = new System.Windows.Forms.Padding(2);
            this.authorButton.Name = "authorButton";
            this.authorButton.Size = new System.Drawing.Size(160, 50);
            this.authorButton.TabIndex = 9;
            this.authorButton.Text = "АВТОР";
            this.authorButton.UseVisualStyleBackColor = false;
            this.authorButton.Click += new System.EventHandler(this.authorButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(639, 206);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // inputButton
            // 
            this.inputButton.BackColor = System.Drawing.Color.Transparent;
            this.inputButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputButton.ForeColor = System.Drawing.SystemColors.Control;
            this.inputButton.Image = ((System.Drawing.Image)(resources.GetObject("inputButton.Image")));
            this.inputButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inputButton.Location = new System.Drawing.Point(435, 141);
            this.inputButton.Margin = new System.Windows.Forms.Padding(2);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(135, 41);
            this.inputButton.TabIndex = 5;
            this.inputButton.Text = "Угадать";
            this.inputButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inputButton.UseVisualStyleBackColor = false;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // soundButton
            // 
            this.soundButton.AutoSize = true;
            this.soundButton.BackColor = System.Drawing.Color.Transparent;
            this.soundButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soundButton.BackgroundImage")));
            this.soundButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.soundButton.FlatAppearance.BorderSize = 0;
            this.soundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.soundButton.Location = new System.Drawing.Point(714, 450);
            this.soundButton.Name = "soundButton";
            this.soundButton.Size = new System.Drawing.Size(75, 75);
            this.soundButton.TabIndex = 12;
            this.soundButton.UseMnemonic = false;
            this.soundButton.UseVisualStyleBackColor = false;
            this.soundButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.soundButton_MouseClick);
            this.soundButton.MouseEnter += new System.EventHandler(this.soundButton_MouseEnter);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 553);
            this.Controls.Add(this.soundButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.authorButton);
            this.Controls.Add(this.adviceButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.surrenderButton);
            this.Controls.Add(this.gameInfoButton);
            this.Controls.Add(this.newGameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Быки и коровы";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button gameInfoButton;
        private System.Windows.Forms.Button surrenderButton;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.Button adviceButton;
        private System.Windows.Forms.Button authorButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button soundButton;
    }
}

