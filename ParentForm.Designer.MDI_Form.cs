namespace MDI_Form
{
    partial class ParentForm
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
            this.mnu_MainItems = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nopeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneForYouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nothingToSeeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_MainItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_MainItems
            // 
            this.mnu_MainItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnu_MainItems.Location = new System.Drawing.Point(0, 0);
            this.mnu_MainItems.Name = "mnu_MainItems";
            this.mnu_MainItems.Size = new System.Drawing.Size(761, 24);
            this.mnu_MainItems.TabIndex = 1;
            this.mnu_MainItems.Text = "Menu Bar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nopeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneForYouToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // nopeToolStripMenuItem
            // 
            this.nopeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nothingToSeeHereToolStripMenuItem});
            this.nopeToolStripMenuItem.Name = "nopeToolStripMenuItem";
            this.nopeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nopeToolStripMenuItem.Text = "Nope";
            // 
            // noneForYouToolStripMenuItem
            // 
            this.noneForYouToolStripMenuItem.Name = "noneForYouToolStripMenuItem";
            this.noneForYouToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noneForYouToolStripMenuItem.Text = "None for you!";
            // 
            // nothingToSeeHereToolStripMenuItem
            // 
            this.nothingToSeeHereToolStripMenuItem.Name = "nothingToSeeHereToolStripMenuItem";
            this.nothingToSeeHereToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.nothingToSeeHereToolStripMenuItem.Text = "Nothing to see here";
            this.nothingToSeeHereToolStripMenuItem.Click += new System.EventHandler(this.nothingToSeeHereToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 446);
            this.Controls.Add(this.mnu_MainItems);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnu_MainItems;
            this.Name = "ParentForm";
            this.Text = "Parent Container";
            this.mnu_MainItems.ResumeLayout(false);
            this.mnu_MainItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_MainItems;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nopeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nothingToSeeHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneForYouToolStripMenuItem;
    }
}
