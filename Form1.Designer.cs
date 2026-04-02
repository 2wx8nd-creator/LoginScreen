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
            Loginlbl = new Label();
            IDtbox = new TextBox();
            PWxtbox = new TextBox();
            logInbtn = new Button();
            SuspendLayout();
            // 
            // Loginlbl
            // 
            Loginlbl.AutoSize = true;
            Loginlbl.Font = new Font("맑은 고딕", 32F);
            Loginlbl.Location = new Point(120, 61);
            Loginlbl.Name = "Loginlbl";
            Loginlbl.Size = new Size(134, 59);
            Loginlbl.TabIndex = 0;
            Loginlbl.Text = "Login";
            // 
            // IDtbox
            // 
            IDtbox.Location = new Point(95, 180);
            IDtbox.Multiline = true;
            IDtbox.Name = "IDtbox";
            IDtbox.Size = new Size(200, 50);
            IDtbox.TabIndex = 1;
            // 
            // PWxtbox
            // 
            PWxtbox.Location = new Point(95, 236);
            PWxtbox.Multiline = true;
            PWxtbox.Name = "PWxtbox";
            PWxtbox.Size = new Size(200, 50);
            PWxtbox.TabIndex = 2;
            // 
            // logInbtn
            // 
            logInbtn.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            logInbtn.Location = new Point(120, 319);
            logInbtn.Name = "logInbtn";
            logInbtn.Size = new Size(150, 50);
            logInbtn.TabIndex = 3;
            logInbtn.Text = "로그인";
            logInbtn.UseVisualStyleBackColor = true;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(logInbtn);
            Controls.Add(PWxtbox);
            Controls.Add(IDtbox);
            Controls.Add(Loginlbl);
            Name = "LoginScreen";
            Text = "LoginScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Loginlbl;
        private TextBox IDtbox;
        private TextBox PWxtbox;
        private Button logInbtn;
    }
}
