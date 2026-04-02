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
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 40F);
            lblAppName.ForeColor = SystemColors.AppWorkspace;
            lblAppName.Location = new Point(110, 81);
            lblAppName.Name = "lblAppName";
            lblAppName.Padding = new Padding(0, 0, 0, 5);
            lblAppName.Size = new Size(165, 77);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(237, 240, 234);
            txtID.Font = new Font("맑은 고딕", 20F);
            txtID.Location = new Point(61, 213);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(271, 50);
            txtID.TabIndex = 1;
            // 
            // txtPW
            // 
            txtPW.BackColor = Color.FromArgb(237, 240, 234);
            txtPW.Font = new Font("맑은 고딕", 20F);
            txtPW.Location = new Point(61, 270);
            txtPW.Multiline = true;
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(271, 50);
            txtPW.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            btnLogin.Location = new Point(120, 400);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 50);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 82, 168);
            ClientSize = new Size(384, 561);
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
    }
}
