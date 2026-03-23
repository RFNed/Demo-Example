namespace Demo_Example.Forms
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            label1 = new Label();
            butt_login = new Button();
            button2 = new Button();
            LoginBox = new TextBox();
            PasswBox = new TextBox();
            pictureBox1 = new PictureBox();
            leaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // butt_login
            // 
            resources.ApplyResources(butt_login, "butt_login");
            butt_login.Name = "butt_login";
            butt_login.UseVisualStyleBackColor = true;
            butt_login.Click += button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LoginBox
            // 
            resources.ApplyResources(LoginBox, "LoginBox");
            LoginBox.Name = "LoginBox";
            // 
            // PasswBox
            // 
            resources.ApplyResources(PasswBox, "PasswBox");
            PasswBox.Name = "PasswBox";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // leaveButton
            // 
            resources.ApplyResources(leaveButton, "leaveButton");
            leaveButton.Name = "leaveButton";
            leaveButton.UseVisualStyleBackColor = true;
            leaveButton.Click += leaveButton_Click;
            // 
            // Auth
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(PasswBox);
            Controls.Add(LoginBox);
            Controls.Add(button2);
            Controls.Add(leaveButton);
            Controls.Add(butt_login);
            Controls.Add(label1);
            Name = "Auth";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private Button butt_login;
        private Button button2;
        private TextBox LoginBox;
        private TextBox PasswBox;
        private PictureBox pictureBox1;
        private Button leaveButton;
    }
}