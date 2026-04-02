namespace LoginScreen
{
    partial class LoginScreen
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
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Georgia", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = SystemColors.AppWorkspace;
            lblAppName.Location = new Point(110, 81);
            lblAppName.Name = "lblAppName";
            lblAppName.Padding = new Padding(0, 0, 0, 5);
            lblAppName.Size = new Size(162, 66);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(237, 240, 234);
            txtID.Font = new Font("맑은 고딕", 20F);
            txtID.ForeColor = SystemColors.ButtonShadow;
            txtID.Location = new Point(61, 213);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(271, 50);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.BackColor = Color.FromArgb(237, 240, 234);
            txtPW.Font = new Font("맑은 고딕", 20F);
            txtPW.ForeColor = SystemColors.AppWorkspace;
            txtPW.Location = new Point(61, 270);
            txtPW.Multiline = true;
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(271, 50);
            txtPW.TabIndex = 3;
            txtPW.Text = "비밀번호";
            txtPW.TextChanged += txtPW_TextChanged;
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            btnLogin.Location = new Point(120, 400);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 50);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.FromArgb(240, 0, 0);
            lblErrorMsg.Location = new Point(61, 323);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(235, 15);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "*아이디 또는 비밀번호가 잘못 되었습니다.";
            lblErrorMsg.Visible = false;
            lblErrorMsg.Click += label1_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 82, 168);
            ClientSize = new Size(384, 561);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "LoginScreen";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
        private Label lblErrorMsg;
    }
}
