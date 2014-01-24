namespace imStudio.Game.EsurientSnake
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.palMap = new System.Windows.Forms.Panel();
            this.btnIniMap = new System.Windows.Forms.Button();
            this.btnIniSnake = new System.Windows.Forms.Button();
            this.btnStartMove = new System.Windows.Forms.Button();
            this.tmSpeed = new System.Windows.Forms.Timer(this.components);
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnSpeedPlus = new System.Windows.Forms.Button();
            this.btnSpeedMinus = new System.Windows.Forms.Button();
            this.btnBonus = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // palMap
            // 
            this.palMap.Dock = System.Windows.Forms.DockStyle.Left;
            this.palMap.Location = new System.Drawing.Point(10, 10);
            this.palMap.Name = "palMap";
            this.palMap.Size = new System.Drawing.Size(400, 390);
            this.palMap.TabIndex = 0;
            // 
            // btnIniMap
            // 
            this.btnIniMap.Location = new System.Drawing.Point(430, 12);
            this.btnIniMap.Name = "btnIniMap";
            this.btnIniMap.Size = new System.Drawing.Size(95, 23);
            this.btnIniMap.TabIndex = 1;
            this.btnIniMap.Text = "初始化地图";
            this.btnIniMap.UseVisualStyleBackColor = true;
            this.btnIniMap.Click += new System.EventHandler(this.btnIniMap_Click);
            // 
            // btnIniSnake
            // 
            this.btnIniSnake.Location = new System.Drawing.Point(430, 41);
            this.btnIniSnake.Name = "btnIniSnake";
            this.btnIniSnake.Size = new System.Drawing.Size(95, 23);
            this.btnIniSnake.TabIndex = 2;
            this.btnIniSnake.Text = "初始化蛇形";
            this.btnIniSnake.UseVisualStyleBackColor = true;
            this.btnIniSnake.Click += new System.EventHandler(this.btnIniSnake_Click);
            // 
            // btnStartMove
            // 
            this.btnStartMove.Location = new System.Drawing.Point(430, 70);
            this.btnStartMove.Name = "btnStartMove";
            this.btnStartMove.Size = new System.Drawing.Size(95, 23);
            this.btnStartMove.TabIndex = 3;
            this.btnStartMove.Text = "开始游戏";
            this.btnStartMove.UseVisualStyleBackColor = true;
            this.btnStartMove.Click += new System.EventHandler(this.btnStartMove_Click);
            // 
            // tmSpeed
            // 
            this.tmSpeed.Interval = 1000;
            this.tmSpeed.Tick += new System.EventHandler(this.tmSpeed_Tick);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(463, 335);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(30, 30);
            this.btnUp.TabIndex = 4;
            this.btnUp.TabStop = false;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(463, 368);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(30, 30);
            this.btnDown.TabIndex = 5;
            this.btnDown.TabStop = false;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(430, 368);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(30, 30);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.TabStop = false;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(495, 368);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(30, 30);
            this.btnRight.TabIndex = 7;
            this.btnRight.TabStop = false;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnSpeedPlus
            // 
            this.btnSpeedPlus.Location = new System.Drawing.Point(430, 157);
            this.btnSpeedPlus.Name = "btnSpeedPlus";
            this.btnSpeedPlus.Size = new System.Drawing.Size(47, 30);
            this.btnSpeedPlus.TabIndex = 8;
            this.btnSpeedPlus.TabStop = false;
            this.btnSpeedPlus.Text = "加速";
            this.btnSpeedPlus.UseVisualStyleBackColor = true;
            this.btnSpeedPlus.Click += new System.EventHandler(this.btnSpeedPlus_Click);
            // 
            // btnSpeedMinus
            // 
            this.btnSpeedMinus.Location = new System.Drawing.Point(478, 157);
            this.btnSpeedMinus.Name = "btnSpeedMinus";
            this.btnSpeedMinus.Size = new System.Drawing.Size(47, 30);
            this.btnSpeedMinus.TabIndex = 9;
            this.btnSpeedMinus.TabStop = false;
            this.btnSpeedMinus.Text = "减速";
            this.btnSpeedMinus.UseVisualStyleBackColor = true;
            this.btnSpeedMinus.Click += new System.EventHandler(this.btnSpeedMinus_Click);
            // 
            // btnBonus
            // 
            this.btnBonus.Location = new System.Drawing.Point(430, 99);
            this.btnBonus.Name = "btnBonus";
            this.btnBonus.Size = new System.Drawing.Size(95, 23);
            this.btnBonus.TabIndex = 10;
            this.btnBonus.Tag = "0";
            this.btnBonus.Text = "开启奖励永存";
            this.btnBonus.UseVisualStyleBackColor = true;
            this.btnBonus.Click += new System.EventHandler(this.btnBonus_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(430, 128);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Tag = "0";
            this.btnBack.Text = "开启倒车功能";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 410);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBonus);
            this.Controls.Add(this.btnSpeedMinus);
            this.Controls.Add(this.btnSpeedPlus);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnStartMove);
            this.Controls.Add(this.btnIniSnake);
            this.Controls.Add(this.btnIniMap);
            this.Controls.Add(this.palMap);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "贪吃蛇";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palMap;
        private System.Windows.Forms.Button btnIniMap;
        private System.Windows.Forms.Button btnIniSnake;
        private System.Windows.Forms.Button btnStartMove;
        private System.Windows.Forms.Timer tmSpeed;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnSpeedPlus;
        private System.Windows.Forms.Button btnSpeedMinus;
        private System.Windows.Forms.Button btnBonus;
        private System.Windows.Forms.Button btnBack;
    }
}

