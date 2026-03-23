namespace Demo_Example.Forms
{
    partial class Catalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalog));
            picture = new PictureBox();
            greet_label = new Label();
            roleName_label = new Label();
            itemList = new FlowLayoutPanel();
            button1 = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            resources.ApplyResources(picture, "picture");
            picture.BackColor = Color.White;
            picture.Name = "picture";
            picture.TabStop = false;
            // 
            // greet_label
            // 
            resources.ApplyResources(greet_label, "greet_label");
            greet_label.Name = "greet_label";
            // 
            // roleName_label
            // 
            resources.ApplyResources(roleName_label, "roleName_label");
            roleName_label.Name = "roleName_label";
            // 
            // itemList
            // 
            resources.ApplyResources(itemList, "itemList");
            itemList.Name = "itemList";
            itemList.Paint += flowLayoutPanel1_Paint;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // exitButton
            // 
            resources.ApplyResources(exitButton, "exitButton");
            exitButton.Name = "exitButton";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Catalog
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(exitButton);
            Controls.Add(button1);
            Controls.Add(itemList);
            Controls.Add(roleName_label);
            Controls.Add(greet_label);
            Controls.Add(picture);
            Name = "Catalog";
            Load += Catalog_Load;
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox picture;
        private Label greet_label;
        private Label rolleName_label;
        private FlowLayoutPanel itemList;
        private Label roleName_label;
        private Button button1;
        private Button exitButton;
    }
}