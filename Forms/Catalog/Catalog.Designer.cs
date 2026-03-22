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
            this.picture = new System.Windows.Forms.PictureBox();
            this.greet_label = new System.Windows.Forms.Label();
            this.roleName_label = new System.Windows.Forms.Label();
            this.itemList = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            resources.ApplyResources(this.picture, "picture");
            this.picture.Name = "picture";
            this.picture.TabStop = false;
            // 
            // greet_label
            // 
            resources.ApplyResources(this.greet_label, "greet_label");
            this.greet_label.Name = "greet_label";
            // 
            // roleName_label
            // 
            resources.ApplyResources(this.roleName_label, "roleName_label");
            this.roleName_label.Name = "roleName_label";
            // 
            // itemList
            // 
            resources.ApplyResources(this.itemList, "itemList");
            this.itemList.Name = "itemList";
            this.itemList.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Catalog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.roleName_label);
            this.Controls.Add(this.greet_label);
            this.Controls.Add(this.picture);
            this.Name = "Catalog";
            this.Load += new System.EventHandler(this.Catalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox picture;
        private Label greet_label;
        private Label rolleName_label;
        private FlowLayoutPanel itemList;
        private Label roleName_label;
        private Button button1;
    }
}