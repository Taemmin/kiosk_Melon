namespace Project
{
    partial class LoginForm
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
            label1 = new System.Windows.Forms.Label();
            ID = new System.Windows.Forms.TextBox();
            Password = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(304, 92);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 32);
            label1.TabIndex = 0;
            label1.Text = "로그인하세요";
            // 
            // ID
            // 
            ID.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ID.Location = new System.Drawing.Point(263, 165);
            ID.Multiline = true;
            ID.Name = "ID";
            ID.Size = new System.Drawing.Size(241, 45);
            ID.TabIndex = 1;
            ID.Text = "아이디";
            // 
            // Password
            // 
            Password.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Password.Location = new System.Drawing.Point(263, 239);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new System.Drawing.Size(241, 45);
            Password.TabIndex = 2;
            Password.Text = "비밀번호";
            // 
            // btnLogin
            // 
            btnLogin.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogin.Location = new System.Drawing.Point(330, 319);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(109, 56);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(Password);
            Controls.Add(ID);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button btnLogin;
    }
}