
namespace projectUAS
{
    partial class FormUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtama));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmUser = new System.Windows.Forms.ToolStripDropDownButton();
            this.pendaftaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsFriend = new System.Windows.Forms.ToolStripDropDownButton();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsPost = new System.Windows.Forms.ToolStripButton();
            this.tmsCheck = new System.Windows.Forms.ToolStripDropDownButton();
            this.organizationForm = new System.Windows.Forms.ToolStripMenuItem();
            this.KotaForm = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUser,
            this.tmsFriend,
            this.tmsPost,
            this.tmsCheck});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1117, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmUser
            // 
            this.tsmUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendaftaranToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.tsmUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmUser.Name = "tsmUser";
            this.tsmUser.Size = new System.Drawing.Size(52, 24);
            this.tsmUser.Text = "User";
            // 
            // pendaftaranToolStripMenuItem
            // 
            this.pendaftaranToolStripMenuItem.Name = "pendaftaranToolStripMenuItem";
            this.pendaftaranToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pendaftaranToolStripMenuItem.Text = "Pendaftaran";
            this.pendaftaranToolStripMenuItem.Click += new System.EventHandler(this.Regist_click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.Login_click);
            // 
            // tmsFriend
            // 
            this.tmsFriend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tmsFriend.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.chatToolStripMenuItem});
            this.tmsFriend.Image = ((System.Drawing.Image)(resources.GetObject("tmsFriend.Image")));
            this.tmsFriend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tmsFriend.Name = "tmsFriend";
            this.tmsFriend.Size = new System.Drawing.Size(64, 24);
            this.tmsFriend.Text = "Friend";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.Search_click);
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.chatToolStripMenuItem.Text = "Chat";
            this.chatToolStripMenuItem.Click += new System.EventHandler(this.Chat_click);
            // 
            // tmsPost
            // 
            this.tmsPost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tmsPost.Image = ((System.Drawing.Image)(resources.GetObject("tmsPost.Image")));
            this.tmsPost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tmsPost.Name = "tmsPost";
            this.tmsPost.Size = new System.Drawing.Size(40, 24);
            this.tmsPost.Text = "Post";
            this.tmsPost.Click += new System.EventHandler(this.Post_click);
            // 
            // tmsCheck
            // 
            this.tmsCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tmsCheck.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizationForm,
            this.KotaForm});
            this.tmsCheck.Image = ((System.Drawing.Image)(resources.GetObject("tmsCheck.Image")));
            this.tmsCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tmsCheck.Name = "tmsCheck";
            this.tmsCheck.Size = new System.Drawing.Size(62, 24);
            this.tmsCheck.Text = "Check";
            // 
            // organizationForm
            // 
            this.organizationForm.Name = "organizationForm";
            this.organizationForm.Size = new System.Drawing.Size(224, 26);
            this.organizationForm.Text = "Organisasi";
            this.organizationForm.Click += new System.EventHandler(this.organizationForm_Click);
            // 
            // KotaForm
            // 
            this.KotaForm.Name = "KotaForm";
            this.KotaForm.Size = new System.Drawing.Size(224, 26);
            this.KotaForm.Text = "Kota";
            this.KotaForm.Click += new System.EventHandler(this.KotaForm_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1117, 735);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUtama";
            this.Text = "PamerYuk";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsmUser;
        private System.Windows.Forms.ToolStripMenuItem pendaftaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tmsFriend;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tmsPost;
        private System.Windows.Forms.ToolStripDropDownButton tmsCheck;
        private System.Windows.Forms.ToolStripMenuItem organizationForm;
        private System.Windows.Forms.ToolStripMenuItem KotaForm;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}

