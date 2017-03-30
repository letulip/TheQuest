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
            this.gbMove.SuspendLayout();
            this.gbAttack.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMove
            // 
            this.gbMove.BackColor = System.Drawing.Color.Transparent;
            this.gbMove.Controls.Add(this.btnMoveRight);
            this.gbMove.Controls.Add(this.btnMoveLeft);
            this.gbMove.Controls.Add(this.btnMoveDown);
            this.gbMove.Controls.Add(this.btnMoveUp);
            this.gbMove.Location = new System.Drawing.Point(347, 306);
            this.gbMove.Name = "gbMove";
            this.gbMove.Size = new System.Drawing.Size(95, 71);
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
            this.gbAttack.Location = new System.Drawing.Point(448, 306);
            this.gbAttack.Name = "gbAttack";
            this.gbAttack.Size = new System.Drawing.Size(95, 71);
            this.gbAttack.TabIndex = 1;
            this.gbAttack.TabStop = false;
            this.gbAttack.Text = "Attack";
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(33, 13);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(28, 23);
            this.btnMoveUp.TabIndex = 0;
            this.btnMoveUp.Text = "W";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(33, 42);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(28, 23);
            this.btnMoveDown.TabIndex = 1;
            this.btnMoveDown.Text = "S";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(4, 28);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(28, 23);
            this.btnMoveLeft.TabIndex = 2;
            this.btnMoveLeft.Text = "A";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(62, 28);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(28, 23);
            this.btnMoveRight.TabIndex = 3;
            this.btnMoveRight.Text = "D";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnAttackRight
            // 
            this.btnAttackRight.Location = new System.Drawing.Point(62, 28);
            this.btnAttackRight.Name = "btnAttackRight";
            this.btnAttackRight.Size = new System.Drawing.Size(28, 23);
            this.btnAttackRight.TabIndex = 7;
            this.btnAttackRight.Text = "→";
            this.btnAttackRight.UseVisualStyleBackColor = true;
            this.btnAttackRight.Click += new System.EventHandler(this.btnAttackRight_Click);
            // 
            // btnAttackLeft
            // 
            this.btnAttackLeft.Location = new System.Drawing.Point(4, 28);
            this.btnAttackLeft.Name = "btnAttackLeft";
            this.btnAttackLeft.Size = new System.Drawing.Size(28, 23);
            this.btnAttackLeft.TabIndex = 6;
            this.btnAttackLeft.Text = "←";
            this.btnAttackLeft.UseVisualStyleBackColor = true;
            this.btnAttackLeft.Click += new System.EventHandler(this.btnAttackLeft_Click);
            // 
            // btnAttackDown
            // 
            this.btnAttackDown.Location = new System.Drawing.Point(33, 42);
            this.btnAttackDown.Name = "btnAttackDown";
            this.btnAttackDown.Size = new System.Drawing.Size(28, 23);
            this.btnAttackDown.TabIndex = 5;
            this.btnAttackDown.Text = "↓";
            this.btnAttackDown.UseVisualStyleBackColor = true;
            this.btnAttackDown.Click += new System.EventHandler(this.btnAttackDown_Click);
            // 
            // btnAttackUp
            // 
            this.btnAttackUp.Location = new System.Drawing.Point(33, 13);
            this.btnAttackUp.Name = "btnAttackUp";
            this.btnAttackUp.Size = new System.Drawing.Size(28, 23);
            this.btnAttackUp.TabIndex = 4;
            this.btnAttackUp.Text = "↑";
            this.btnAttackUp.UseVisualStyleBackColor = true;
            this.btnAttackUp.Click += new System.EventHandler(this.btnAttackUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 398);
            this.Controls.Add(this.gbAttack);
            this.Controls.Add(this.gbMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The Quest";
            this.gbMove.ResumeLayout(false);
            this.gbAttack.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

