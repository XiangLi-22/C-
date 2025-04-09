namespace Shopping.SubFrm
{
    partial class RefundFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnTime = new System.Windows.Forms.RadioButton();
            this.rbtnType = new System.Windows.Forms.RadioButton();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnTime = new System.Windows.Forms.Button();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "按日期添加退款账单:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "按类型提添加退款账单:";
            // 
            // rbtnTime
            // 
            this.rbtnTime.AutoSize = true;
            this.rbtnTime.Checked = true;
            this.rbtnTime.Location = new System.Drawing.Point(73, 55);
            this.rbtnTime.Name = "rbtnTime";
            this.rbtnTime.Size = new System.Drawing.Size(17, 16);
            this.rbtnTime.TabIndex = 2;
            this.rbtnTime.TabStop = true;
            this.rbtnTime.UseVisualStyleBackColor = true;
            // 
            // rbtnType
            // 
            this.rbtnType.AutoSize = true;
            this.rbtnType.Location = new System.Drawing.Point(72, 156);
            this.rbtnType.Name = "rbtnType";
            this.rbtnType.Size = new System.Drawing.Size(17, 16);
            this.rbtnType.TabIndex = 3;
            this.rbtnType.TabStop = true;
            this.rbtnType.UseVisualStyleBackColor = true;
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(73, 91);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(183, 25);
            this.dtpTime.TabIndex = 4;
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(99, 255);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(135, 43);
            this.btnTime.TabIndex = 0;
            this.btnTime.Text = "查询";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "请选择",
            "餐饮",
            "服饰",
            "日用",
            "数码",
            "护肤",
            "住房",
            "交通",
            "娱乐",
            "医疗",
            "通讯",
            "运动",
            "社交",
            "人情",
            "宠物",
            "旅行",
            "彩票",
            "汽车",
            "育儿"});
            this.cbbType.Location = new System.Drawing.Point(73, 192);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(183, 23);
            this.cbbType.TabIndex = 6;
            // 
            // RefundFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 353);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnType);
            this.Controls.Add(this.rbtnTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RefundFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "退款";
            this.Load += new System.EventHandler(this.RefundFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnType;
        private System.Windows.Forms.RadioButton rbtnTime;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
    }
}