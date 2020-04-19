namespace KF2_banlist_editor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.serverList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.banBox = new System.Windows.Forms.ListBox();
            this.serverBtn = new System.Windows.Forms.Button();
            this.banBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.serverLabel = new System.Windows.Forms.Label();
            this.userLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(13, 13);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(16, 12);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "password";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(15, 29);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(150, 21);
            this.idTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passwordTextBox.Location = new System.Drawing.Point(171, 29);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(150, 21);
            this.passwordTextBox.TabIndex = 3;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(327, 29);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // serverList
            // 
            this.serverList.FormattingEnabled = true;
            this.serverList.ItemHeight = 12;
            this.serverList.Location = new System.Drawing.Point(15, 78);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(230, 400);
            this.serverList.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Server List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ban List";
            // 
            // banBox
            // 
            this.banBox.FormattingEnabled = true;
            this.banBox.ItemHeight = 12;
            this.banBox.Location = new System.Drawing.Point(254, 78);
            this.banBox.Name = "banBox";
            this.banBox.Size = new System.Drawing.Size(230, 400);
            this.banBox.TabIndex = 8;
            // 
            // serverBtn
            // 
            this.serverBtn.Location = new System.Drawing.Point(15, 485);
            this.serverBtn.Name = "serverBtn";
            this.serverBtn.Size = new System.Drawing.Size(230, 23);
            this.serverBtn.TabIndex = 9;
            this.serverBtn.Text = "add list";
            this.serverBtn.UseVisualStyleBackColor = true;
            this.serverBtn.Click += new System.EventHandler(this.serverBtn_Click);
            // 
            // banBtn
            // 
            this.banBtn.Location = new System.Drawing.Point(254, 485);
            this.banBtn.Name = "banBtn";
            this.banBtn.Size = new System.Drawing.Size(230, 23);
            this.banBtn.TabIndex = 10;
            this.banBtn.Text = "add list";
            this.banBtn.UseVisualStyleBackColor = true;
            this.banBtn.Click += new System.EventHandler(this.banBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 514);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(469, 23);
            this.progressBar.TabIndex = 11;
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(15, 545);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(35, 12);
            this.serverLabel.TabIndex = 12;
            this.serverLabel.Text = "None";
            // 
            // userLable
            // 
            this.userLable.AutoSize = true;
            this.userLable.Location = new System.Drawing.Point(383, 545);
            this.userLable.Name = "userLable";
            this.userLable.Size = new System.Drawing.Size(101, 12);
            this.userLable.TabIndex = 13;
            this.userLable.Text = "0000000000000000";
            this.userLable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 566);
            this.Controls.Add(this.userLable);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.banBtn);
            this.Controls.Add(this.serverBtn);
            this.Controls.Add(this.banBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverList);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "KF2 List Ban ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ListBox serverList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox banBox;
        private System.Windows.Forms.Button serverBtn;
        private System.Windows.Forms.Button banBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label userLable;
    }
}

