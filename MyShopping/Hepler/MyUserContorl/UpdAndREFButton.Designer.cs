﻿namespace Shopping.MyUserContorl
{
    partial class UpdAndREFButton
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(3, 3);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(48, 25);
            this.btnUpd.TabIndex = 0;
            this.btnUpd.Text = "编辑";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(52, 3);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(48, 25);
            this.btnRef.TabIndex = 1;
            this.btnRef.Text = "退款";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // DelectButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnUpd);
            this.Name = "DelectButton";
            this.Size = new System.Drawing.Size(103, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnRef;
    }
}
