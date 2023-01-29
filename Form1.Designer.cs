
namespace Multi_Test
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LstStep = new System.Windows.Forms.ListBox();
            this.BtnPass = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.LblModel = new System.Windows.Forms.Label();
            this.TxtShow = new System.Windows.Forms.TextBox();
            this.BtnRetry = new System.Windows.Forms.Button();
            this.BtnAbort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblStep = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PicShow = new System.Windows.Forms.PictureBox();
            this.BtnSetting = new System.Windows.Forms.Button();
            this.TxtReceived = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).BeginInit();
            this.SuspendLayout();
            // 
            // LstStep
            // 
            this.LstStep.FormattingEnabled = true;
            this.LstStep.ItemHeight = 18;
            this.LstStep.Location = new System.Drawing.Point(30, 137);
            this.LstStep.Name = "LstStep";
            this.LstStep.Size = new System.Drawing.Size(247, 436);
            this.LstStep.TabIndex = 0;
            this.LstStep.SelectedIndexChanged += new System.EventHandler(this.LstStep_SelectedIndexChanged);
            // 
            // BtnPass
            // 
            this.BtnPass.BackColor = System.Drawing.Color.Lime;
            this.BtnPass.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPass.Location = new System.Drawing.Point(277, 597);
            this.BtnPass.Name = "BtnPass";
            this.BtnPass.Size = new System.Drawing.Size(157, 56);
            this.BtnPass.TabIndex = 1;
            this.BtnPass.Text = "Pass";
            this.BtnPass.UseVisualStyleBackColor = false;
            this.BtnPass.Click += new System.EventHandler(this.BtnPass_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(305, 40);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(138, 38);
            this.BtnSelect.TabIndex = 3;
            this.BtnSelect.Text = "选择测试程序";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // LblModel
            // 
            this.LblModel.AutoSize = true;
            this.LblModel.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblModel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblModel.Location = new System.Drawing.Point(466, 46);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(76, 22);
            this.LblModel.TabIndex = 5;
            this.LblModel.Text = "label1";
            // 
            // TxtShow
            // 
            this.TxtShow.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TxtShow.Location = new System.Drawing.Point(305, 137);
            this.TxtShow.Multiline = true;
            this.TxtShow.Name = "TxtShow";
            this.TxtShow.Size = new System.Drawing.Size(592, 73);
            this.TxtShow.TabIndex = 7;
            // 
            // BtnRetry
            // 
            this.BtnRetry.BackColor = System.Drawing.Color.Yellow;
            this.BtnRetry.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRetry.Location = new System.Drawing.Point(510, 597);
            this.BtnRetry.Name = "BtnRetry";
            this.BtnRetry.Size = new System.Drawing.Size(157, 56);
            this.BtnRetry.TabIndex = 10;
            this.BtnRetry.Text = "Retry";
            this.BtnRetry.UseVisualStyleBackColor = false;
            this.BtnRetry.Click += new System.EventHandler(this.BtnRetry_Click);
            // 
            // BtnAbort
            // 
            this.BtnAbort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAbort.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAbort.Location = new System.Drawing.Point(740, 597);
            this.BtnAbort.Name = "BtnAbort";
            this.BtnAbort.Size = new System.Drawing.Size(157, 56);
            this.BtnAbort.TabIndex = 11;
            this.BtnAbort.Text = "Abort";
            this.BtnAbort.UseVisualStyleBackColor = false;
            this.BtnAbort.Click += new System.EventHandler(this.BtnAbort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(37, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Test Items";
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnStart.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnStart.Location = new System.Drawing.Point(41, 597);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(157, 56);
            this.BtnStart.TabIndex = 13;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblStep
            // 
            this.LblStep.AutoSize = true;
            this.LblStep.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblStep.Location = new System.Drawing.Point(313, 104);
            this.LblStep.Name = "LblStep";
            this.LblStep.Size = new System.Drawing.Size(58, 22);
            this.LblStep.TabIndex = 14;
            this.LblStep.Text = "Item";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // PicShow
            // 
            this.PicShow.Location = new System.Drawing.Point(305, 235);
            this.PicShow.Name = "PicShow";
            this.PicShow.Size = new System.Drawing.Size(592, 338);
            this.PicShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicShow.TabIndex = 9;
            this.PicShow.TabStop = false;
            // 
            // BtnSetting
            // 
            this.BtnSetting.BackgroundImage = global::Multi_Test.Properties.Resources.setting;
            this.BtnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSetting.Location = new System.Drawing.Point(835, 18);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(60, 60);
            this.BtnSetting.TabIndex = 8;
            this.BtnSetting.UseVisualStyleBackColor = true;
            this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // TxtReceived
            // 
            this.TxtReceived.Location = new System.Drawing.Point(30, 795);
            this.TxtReceived.Multiline = true;
            this.TxtReceived.Name = "TxtReceived";
            this.TxtReceived.Size = new System.Drawing.Size(865, 74);
            this.TxtReceived.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 672);
            this.Controls.Add(this.TxtReceived);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LblStep);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAbort);
            this.Controls.Add(this.BtnRetry);
            this.Controls.Add(this.PicShow);
            this.Controls.Add(this.BtnSetting);
            this.Controls.Add(this.TxtShow);
            this.Controls.Add(this.LblModel);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnPass);
            this.Controls.Add(this.LstStep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Multi_Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstStep;
        private System.Windows.Forms.Button BtnPass;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Label LblModel;
        private System.Windows.Forms.TextBox TxtShow;
        private System.Windows.Forms.Button BtnSetting;
        private System.Windows.Forms.PictureBox PicShow;
        private System.Windows.Forms.Button BtnRetry;
        private System.Windows.Forms.Button BtnAbort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblStep;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtReceived;
    }
}

