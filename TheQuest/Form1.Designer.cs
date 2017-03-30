namespace TheQuest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbMove = new System.Windows.Forms.GroupBox();
            this.gbAttack = new System.Windows.Forms.GroupBox();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnAttackRight = new System.Windows.Forms.Button();
            this.btnAttackLeft = new System.Windows.Forms.Button();
            this.btnAttackDown = new System.Windows.Forms.Button();
            this.btnAttackUp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.lblBat = new System.Windows.Forms.Label();
            this.lblBatHP = new System.Windows.Forms.Label();
            this.lblGhost = new System.Windows.Forms.Label();
            this.lblGhostHP = new System.Windows.Forms.Label();
            this.lblGhoul = new System.Windows.Forms.Label();
            this.lblGhoulHP = new System.Windows.Forms.Label();
            this.pbxPlayer = new System.Windows.Forms.PictureBox();
            this.pbxBat = new System.Windows.Forms.PictureBox();
            this.pbxGhost = new System.Windows.Forms.PictureBox();
            this.pbxGhoul = new System.Windows.Forms.PictureBox();
            this.pbxPotionRed = new System.Windows.Forms.PictureBox();
            this.pbxPotionBlue = new System.Windows.Forms.PictureBox();
            this.pbxSword = new System.Windows.Forms.PictureBox();
            this.pbxBow = new System.Windows.Forms.PictureBox();
            this.pbxMace = new System.Windows.Forms.PictureBox();
            this.pbxShield = new System.Windows.Forms.PictureBox();
            this.pbxQuiver = new System.Windows.Forms.PictureBox();
            this.pbxAxe = new System.Windows.Forms.PictureBox();
            this.gbMove.SuspendLayout();
            this.gbAttack.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGhoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPotionRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPotionBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQuiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAxe)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMove
            // 
            this.gbMove.BackColor = System.Drawing.Color.Transparent;
            this.gbMove.Controls.Add(this.btnMoveRight);
            this.gbMove.Controls.Add(this.btnMoveLeft);
            this.gbMove.Controls.Add(this.btnMoveDown);
            this.gbMove.Controls.Add(this.btnMoveUp);
            this.gbMove.Location = new System.Drawing.Point(596, 466);
            this.gbMove.Name = "gbMove";
            this.gbMove.Size = new System.Drawing.Size(105, 100);
            this.gbMove.TabIndex = 0;
            this.gbMove.TabStop = false;
            this.gbMove.Text = "Move";
            // 
            // gbAttack
            // 
            this.gbAttack.BackColor = System.Drawing.Color.Transparent;
            this.gbAttack.Controls.Add(this.btnAttackRight);
            this.gbAttack.Controls.Add(this.btnAttackLeft);
            this.gbAttack.Controls.Add(this.btnAttackUp);
            this.gbAttack.Controls.Add(this.btnAttackDown);
            this.gbAttack.Location = new System.Drawing.Point(706, 466);
            this.gbAttack.Name = "gbAttack";
            this.gbAttack.Size = new System.Drawing.Size(105, 100);
            this.gbAttack.TabIndex = 1;
            this.gbAttack.TabStop = false;
            this.gbAttack.Text = "Attack";
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(38, 24);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(28, 28);
            this.btnMoveUp.TabIndex = 0;
            this.btnMoveUp.Text = "W";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(38, 61);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(28, 28);
            this.btnMoveDown.TabIndex = 1;
            this.btnMoveDown.Text = "S";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(7, 42);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(28, 28);
            this.btnMoveLeft.TabIndex = 2;
            this.btnMoveLeft.Text = "A";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(69, 42);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(28, 28);
            this.btnMoveRight.TabIndex = 3;
            this.btnMoveRight.Text = "D";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnAttackRight
            // 
            this.btnAttackRight.Location = new System.Drawing.Point(71, 42);
            this.btnAttackRight.Name = "btnAttackRight";
            this.btnAttackRight.Size = new System.Drawing.Size(28, 28);
            this.btnAttackRight.TabIndex = 7;
            this.btnAttackRight.Text = "→";
            this.btnAttackRight.UseVisualStyleBackColor = true;
            this.btnAttackRight.Click += new System.EventHandler(this.btnAttackRight_Click);
            // 
            // btnAttackLeft
            // 
            this.btnAttackLeft.Location = new System.Drawing.Point(6, 42);
            this.btnAttackLeft.Name = "btnAttackLeft";
            this.btnAttackLeft.Size = new System.Drawing.Size(28, 28);
            this.btnAttackLeft.TabIndex = 6;
            this.btnAttackLeft.Text = "←";
            this.btnAttackLeft.UseVisualStyleBackColor = true;
            this.btnAttackLeft.Click += new System.EventHandler(this.btnAttackLeft_Click);
            // 
            // btnAttackDown
            // 
            this.btnAttackDown.Location = new System.Drawing.Point(39, 61);
            this.btnAttackDown.Name = "btnAttackDown";
            this.btnAttackDown.Size = new System.Drawing.Size(28, 28);
            this.btnAttackDown.TabIndex = 5;
            this.btnAttackDown.Text = "↓";
            this.btnAttackDown.UseVisualStyleBackColor = true;
            this.btnAttackDown.Click += new System.EventHandler(this.btnAttackDown_Click);
            // 
            // btnAttackUp
            // 
            this.btnAttackUp.Location = new System.Drawing.Point(39, 24);
            this.btnAttackUp.Name = "btnAttackUp";
            this.btnAttackUp.Size = new System.Drawing.Size(28, 28);
            this.btnAttackUp.TabIndex = 4;
            this.btnAttackUp.Text = "↑";
            this.btnAttackUp.UseVisualStyleBackColor = true;
            this.btnAttackUp.Click += new System.EventHandler(this.btnAttackUp_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblGhoulHP, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGhoul, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGhostHP, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGhost, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBatHP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayerHP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayer, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(667, 373);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(100, 74);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(3, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Player";
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.Location = new System.Drawing.Point(53, 0);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerHP.TabIndex = 1;
            this.lblPlayerHP.Text = "label2";
            // 
            // lblBat
            // 
            this.lblBat.AutoSize = true;
            this.lblBat.Location = new System.Drawing.Point(3, 18);
            this.lblBat.Name = "lblBat";
            this.lblBat.Size = new System.Drawing.Size(23, 13);
            this.lblBat.TabIndex = 2;
            this.lblBat.Text = "Bat";
            // 
            // lblBatHP
            // 
            this.lblBatHP.AutoSize = true;
            this.lblBatHP.Location = new System.Drawing.Point(53, 18);
            this.lblBatHP.Name = "lblBatHP";
            this.lblBatHP.Size = new System.Drawing.Size(35, 13);
            this.lblBatHP.TabIndex = 3;
            this.lblBatHP.Text = "label4";
            // 
            // lblGhost
            // 
            this.lblGhost.AutoSize = true;
            this.lblGhost.Location = new System.Drawing.Point(3, 36);
            this.lblGhost.Name = "lblGhost";
            this.lblGhost.Size = new System.Drawing.Size(35, 13);
            this.lblGhost.TabIndex = 4;
            this.lblGhost.Text = "Ghost";
            // 
            // lblGhostHP
            // 
            this.lblGhostHP.AutoSize = true;
            this.lblGhostHP.Location = new System.Drawing.Point(53, 36);
            this.lblGhostHP.Name = "lblGhostHP";
            this.lblGhostHP.Size = new System.Drawing.Size(35, 13);
            this.lblGhostHP.TabIndex = 5;
            this.lblGhostHP.Text = "label6";
            // 
            // lblGhoul
            // 
            this.lblGhoul.AutoSize = true;
            this.lblGhoul.Location = new System.Drawing.Point(3, 54);
            this.lblGhoul.Name = "lblGhoul";
            this.lblGhoul.Size = new System.Drawing.Size(35, 13);
            this.lblGhoul.TabIndex = 6;
            this.lblGhoul.Text = "Ghoul";
            // 
            // lblGhoulHP
            // 
            this.lblGhoulHP.AutoSize = true;
            this.lblGhoulHP.Location = new System.Drawing.Point(53, 54);
            this.lblGhoulHP.Name = "lblGhoulHP";
            this.lblGhoulHP.Size = new System.Drawing.Size(35, 13);
            this.lblGhoulHP.TabIndex = 7;
            this.lblGhoulHP.Text = "label8";
            // 
            // pbxPlayer
            // 
            this.pbxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbxPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbxPlayer.Image")));
            this.pbxPlayer.Location = new System.Drawing.Point(113, 86);
            this.pbxPlayer.Name = "pbxPlayer";
            this.pbxPlayer.Size = new System.Drawing.Size(50, 50);
            this.pbxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxPlayer.TabIndex = 3;
            this.pbxPlayer.TabStop = false;
            // 
            // pbxBat
            // 
            this.pbxBat.BackColor = System.Drawing.Color.Transparent;
            this.pbxBat.Image = ((System.Drawing.Image)(resources.GetObject("pbxBat.Image")));
            this.pbxBat.Location = new System.Drawing.Point(170, 86);
            this.pbxBat.Name = "pbxBat";
            this.pbxBat.Size = new System.Drawing.Size(50, 50);
            this.pbxBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxBat.TabIndex = 4;
            this.pbxBat.TabStop = false;
            // 
            // pbxGhost
            // 
            this.pbxGhost.BackColor = System.Drawing.Color.Transparent;
            this.pbxGhost.Image = ((System.Drawing.Image)(resources.GetObject("pbxGhost.Image")));
            this.pbxGhost.Location = new System.Drawing.Point(227, 86);
            this.pbxGhost.Name = "pbxGhost";
            this.pbxGhost.Size = new System.Drawing.Size(50, 50);
            this.pbxGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxGhost.TabIndex = 5;
            this.pbxGhost.TabStop = false;
            // 
            // pbxGhoul
            // 
            this.pbxGhoul.BackColor = System.Drawing.Color.Transparent;
            this.pbxGhoul.Image = ((System.Drawing.Image)(resources.GetObject("pbxGhoul.Image")));
            this.pbxGhoul.Location = new System.Drawing.Point(284, 86);
            this.pbxGhoul.Name = "pbxGhoul";
            this.pbxGhoul.Size = new System.Drawing.Size(50, 50);
            this.pbxGhoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxGhoul.TabIndex = 6;
            this.pbxGhoul.TabStop = false;
            // 
            // pbxPotionRed
            // 
            this.pbxPotionRed.BackColor = System.Drawing.Color.Transparent;
            this.pbxPotionRed.Image = ((System.Drawing.Image)(resources.GetObject("pbxPotionRed.Image")));
            this.pbxPotionRed.Location = new System.Drawing.Point(341, 86);
            this.pbxPotionRed.Name = "pbxPotionRed";
            this.pbxPotionRed.Size = new System.Drawing.Size(50, 50);
            this.pbxPotionRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxPotionRed.TabIndex = 7;
            this.pbxPotionRed.TabStop = false;
            // 
            // pbxPotionBlue
            // 
            this.pbxPotionBlue.BackColor = System.Drawing.Color.Transparent;
            this.pbxPotionBlue.Image = ((System.Drawing.Image)(resources.GetObject("pbxPotionBlue.Image")));
            this.pbxPotionBlue.Location = new System.Drawing.Point(397, 86);
            this.pbxPotionBlue.Name = "pbxPotionBlue";
            this.pbxPotionBlue.Size = new System.Drawing.Size(50, 50);
            this.pbxPotionBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxPotionBlue.TabIndex = 8;
            this.pbxPotionBlue.TabStop = false;
            // 
            // pbxSword
            // 
            this.pbxSword.BackColor = System.Drawing.Color.Transparent;
            this.pbxSword.Image = ((System.Drawing.Image)(resources.GetObject("pbxSword.Image")));
            this.pbxSword.Location = new System.Drawing.Point(454, 86);
            this.pbxSword.Name = "pbxSword";
            this.pbxSword.Size = new System.Drawing.Size(50, 50);
            this.pbxSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxSword.TabIndex = 9;
            this.pbxSword.TabStop = false;
            // 
            // pbxBow
            // 
            this.pbxBow.BackColor = System.Drawing.Color.Transparent;
            this.pbxBow.Image = ((System.Drawing.Image)(resources.GetObject("pbxBow.Image")));
            this.pbxBow.Location = new System.Drawing.Point(511, 86);
            this.pbxBow.Name = "pbxBow";
            this.pbxBow.Size = new System.Drawing.Size(50, 50);
            this.pbxBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxBow.TabIndex = 10;
            this.pbxBow.TabStop = false;
            // 
            // pbxMace
            // 
            this.pbxMace.BackColor = System.Drawing.Color.Transparent;
            this.pbxMace.Image = ((System.Drawing.Image)(resources.GetObject("pbxMace.Image")));
            this.pbxMace.Location = new System.Drawing.Point(568, 86);
            this.pbxMace.Name = "pbxMace";
            this.pbxMace.Size = new System.Drawing.Size(50, 50);
            this.pbxMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxMace.TabIndex = 11;
            this.pbxMace.TabStop = false;
            // 
            // pbxShield
            // 
            this.pbxShield.BackColor = System.Drawing.Color.Transparent;
            this.pbxShield.Image = ((System.Drawing.Image)(resources.GetObject("pbxShield.Image")));
            this.pbxShield.Location = new System.Drawing.Point(625, 86);
            this.pbxShield.Name = "pbxShield";
            this.pbxShield.Size = new System.Drawing.Size(50, 50);
            this.pbxShield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxShield.TabIndex = 12;
            this.pbxShield.TabStop = false;
            // 
            // pbxQuiver
            // 
            this.pbxQuiver.BackColor = System.Drawing.Color.Transparent;
            this.pbxQuiver.Image = ((System.Drawing.Image)(resources.GetObject("pbxQuiver.Image")));
            this.pbxQuiver.Location = new System.Drawing.Point(681, 86);
            this.pbxQuiver.Name = "pbxQuiver";
            this.pbxQuiver.Size = new System.Drawing.Size(50, 50);
            this.pbxQuiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxQuiver.TabIndex = 13;
            this.pbxQuiver.TabStop = false;
            // 
            // pbxAxe
            // 
            this.pbxAxe.BackColor = System.Drawing.Color.Transparent;
            this.pbxAxe.Image = ((System.Drawing.Image)(resources.GetObject("pbxAxe.Image")));
            this.pbxAxe.Location = new System.Drawing.Point(738, 86);
            this.pbxAxe.Name = "pbxAxe";
            this.pbxAxe.Size = new System.Drawing.Size(50, 50);
            this.pbxAxe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAxe.TabIndex = 14;
            this.pbxAxe.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pbxAxe);
            this.Controls.Add(this.pbxQuiver);
            this.Controls.Add(this.pbxShield);
            this.Controls.Add(this.pbxMace);
            this.Controls.Add(this.pbxBow);
            this.Controls.Add(this.pbxSword);
            this.Controls.Add(this.pbxPotionBlue);
            this.Controls.Add(this.pbxPotionRed);
            this.Controls.Add(this.pbxGhoul);
            this.Controls.Add(this.pbxGhost);
            this.Controls.Add(this.pbxBat);
            this.Controls.Add(this.pbxPlayer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbAttack);
            this.Controls.Add(this.gbMove);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The Quest";
            this.gbMove.ResumeLayout(false);
            this.gbAttack.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGhoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPotionRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPotionBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQuiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAxe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMove;
        private System.Windows.Forms.GroupBox gbAttack;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnAttackRight;
        private System.Windows.Forms.Button btnAttackLeft;
        private System.Windows.Forms.Button btnAttackUp;
        private System.Windows.Forms.Button btnAttackDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblGhoulHP;
        private System.Windows.Forms.Label lblGhoul;
        private System.Windows.Forms.Label lblGhostHP;
        private System.Windows.Forms.Label lblGhost;
        private System.Windows.Forms.Label lblBatHP;
        private System.Windows.Forms.Label lblBat;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.PictureBox pbxPlayer;
        private System.Windows.Forms.PictureBox pbxBat;
        private System.Windows.Forms.PictureBox pbxGhost;
        private System.Windows.Forms.PictureBox pbxGhoul;
        private System.Windows.Forms.PictureBox pbxPotionRed;
        private System.Windows.Forms.PictureBox pbxPotionBlue;
        private System.Windows.Forms.PictureBox pbxSword;
        private System.Windows.Forms.PictureBox pbxBow;
        private System.Windows.Forms.PictureBox pbxMace;
        private System.Windows.Forms.PictureBox pbxShield;
        private System.Windows.Forms.PictureBox pbxQuiver;
        private System.Windows.Forms.PictureBox pbxAxe;
    }
}

