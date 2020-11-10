namespace WindowsFormsApp9
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.InBox = new System.Windows.Forms.TextBox();
            this.OutBox = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.MondaiLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBkake = new System.Windows.Forms.RadioButton();
            this.RBhiku = new System.Windows.Forms.RadioButton();
            this.RBtasu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB30 = new System.Windows.Forms.RadioButton();
            this.RB20 = new System.Windows.Forms.RadioButton();
            this.RB10 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(28, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "答え";
            // 
            // InBox
            // 
            this.InBox.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InBox.Location = new System.Drawing.Point(92, 356);
            this.InBox.Name = "InBox";
            this.InBox.Size = new System.Drawing.Size(100, 29);
            this.InBox.TabIndex = 1;
            this.InBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InBox_KeyPress);
            // 
            // OutBox
            // 
            this.OutBox.BackColor = System.Drawing.Color.White;
            this.OutBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OutBox.Location = new System.Drawing.Point(223, 190);
            this.OutBox.Multiline = true;
            this.OutBox.Name = "OutBox";
            this.OutBox.ReadOnly = true;
            this.OutBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutBox.Size = new System.Drawing.Size(169, 195);
            this.OutBox.TabIndex = 2;
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartBtn.Location = new System.Drawing.Point(32, 190);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(160, 61);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "開始";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // MondaiLbl
            // 
            this.MondaiLbl.BackColor = System.Drawing.Color.White;
            this.MondaiLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MondaiLbl.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MondaiLbl.Location = new System.Drawing.Point(30, 297);
            this.MondaiLbl.Name = "MondaiLbl";
            this.MondaiLbl.Size = new System.Drawing.Size(162, 38);
            this.MondaiLbl.TabIndex = 4;
            this.MondaiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBkake);
            this.groupBox1.Controls.Add(this.RBhiku);
            this.groupBox1.Controls.Add(this.RBtasu);
            this.groupBox1.Location = new System.Drawing.Point(32, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 45);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // RBkake
            // 
            this.RBkake.AutoSize = true;
            this.RBkake.Location = new System.Drawing.Point(170, 18);
            this.RBkake.Name = "RBkake";
            this.RBkake.Size = new System.Drawing.Size(57, 16);
            this.RBkake.TabIndex = 2;
            this.RBkake.Text = "掛け算";
            this.RBkake.UseVisualStyleBackColor = true;
            // 
            // RBhiku
            // 
            this.RBhiku.AutoSize = true;
            this.RBhiku.Location = new System.Drawing.Point(91, 18);
            this.RBhiku.Name = "RBhiku";
            this.RBhiku.Size = new System.Drawing.Size(56, 16);
            this.RBhiku.TabIndex = 1;
            this.RBhiku.Text = "引き算";
            this.RBhiku.UseVisualStyleBackColor = true;
            // 
            // RBtasu
            // 
            this.RBtasu.AutoSize = true;
            this.RBtasu.Checked = true;
            this.RBtasu.Location = new System.Drawing.Point(18, 18);
            this.RBtasu.Name = "RBtasu";
            this.RBtasu.Size = new System.Drawing.Size(56, 16);
            this.RBtasu.TabIndex = 0;
            this.RBtasu.TabStop = true;
            this.RBtasu.Text = "足し算";
            this.RBtasu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB30);
            this.groupBox2.Controls.Add(this.RB20);
            this.groupBox2.Controls.Add(this.RB10);
            this.groupBox2.Location = new System.Drawing.Point(32, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 45);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // RB30
            // 
            this.RB30.AutoSize = true;
            this.RB30.Location = new System.Drawing.Point(170, 18);
            this.RB30.Name = "RB30";
            this.RB30.Size = new System.Drawing.Size(51, 16);
            this.RB30.TabIndex = 4;
            this.RB30.Text = "30 問";
            this.RB30.UseVisualStyleBackColor = true;
            // 
            // RB20
            // 
            this.RB20.AutoSize = true;
            this.RB20.Location = new System.Drawing.Point(91, 18);
            this.RB20.Name = "RB20";
            this.RB20.Size = new System.Drawing.Size(51, 16);
            this.RB20.TabIndex = 3;
            this.RB20.Text = "20 問";
            this.RB20.UseVisualStyleBackColor = true;
            // 
            // RB10
            // 
            this.RB10.AutoSize = true;
            this.RB10.Checked = true;
            this.RB10.Location = new System.Drawing.Point(18, 18);
            this.RB10.Name = "RB10";
            this.RB10.Size = new System.Drawing.Size(51, 16);
            this.RB10.TabIndex = 2;
            this.RB10.TabStop = true;
            this.RB10.Text = "10 問";
            this.RB10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MondaiLbl);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.OutBox);
            this.Controls.Add(this.InBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InBox;
        private System.Windows.Forms.TextBox OutBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label MondaiLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBhiku;
        private System.Windows.Forms.RadioButton RBtasu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB30;
        private System.Windows.Forms.RadioButton RB20;
        private System.Windows.Forms.RadioButton RB10;
        private System.Windows.Forms.RadioButton RBkake;
    }
}

