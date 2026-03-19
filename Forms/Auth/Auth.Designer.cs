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
            this.label1 = new System.Windows.Forms.Label();
            this.butt_login = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // butt_login
            // 
            resources.ApplyResources(this.butt_login, "butt_login");
            this.butt_login.Name = "butt_login";
            this.butt_login.UseVisualStyleBackColor = true;
            this.butt_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginBox
            // 
            resources.ApplyResources(this.LoginBox, "LoginBox");
            this.LoginBox.Name = "LoginBox";
            // 
            // PasswBox
            // 
            resources.ApplyResources(this.PasswBox, "PasswBox");
            this.PasswBox.Name = "PasswBox";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Auth
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PasswBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butt_login);
            this.Controls.Add(this.label1);
            this.Name = "Auth";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button butt_login;
        private Button button2;
        private TextBox LoginBox;
        private TextBox PasswBox;
        private PictureBox pictureBox1;
    }
}