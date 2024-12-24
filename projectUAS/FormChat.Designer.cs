
namespace projectUAS
{
    partial class FormChat
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
            this.pnlChat = new System.Windows.Forms.Panel();
            this.dtgChat = new System.Windows.Forms.DataGridView();
            this.btnTutup = new System.Windows.Forms.Button();
            this.cbxNamaOrg = new System.Windows.Forms.ComboBox();
            this.lblOrg = new System.Windows.Forms.Label();
            this.cbxTingkat = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChat)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.Color.LightGray;
            this.pnlChat.Controls.Add(this.dtgChat);
            this.pnlChat.Controls.Add(this.btnTutup);
            this.pnlChat.Controls.Add(this.cbxNamaOrg);
            this.pnlChat.Controls.Add(this.lblOrg);
            this.pnlChat.Controls.Add(this.cbxTingkat);
            this.pnlChat.Location = new System.Drawing.Point(17, 48);
            this.pnlChat.Margin = new System.Windows.Forms.Padding(10);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(725, 673);
            this.pnlChat.TabIndex = 7;
            // 
            // dtgChat
            // 
            this.dtgChat.BackgroundColor = System.Drawing.Color.White;
            this.dtgChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChat.Location = new System.Drawing.Point(15, 63);
            this.dtgChat.Margin = new System.Windows.Forms.Padding(10);
            this.dtgChat.Name = "dtgChat";
            this.dtgChat.RowHeadersWidth = 51;
            this.dtgChat.RowTemplate.Height = 24;
            this.dtgChat.Size = new System.Drawing.Size(691, 507);
            this.dtgChat.TabIndex = 17;
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTutup.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.Location = new System.Drawing.Point(580, 607);
            this.btnTutup.Margin = new System.Windows.Forms.Padding(15);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(126, 51);
            this.btnTutup.TabIndex = 3;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // cbxNamaOrg
            // 
            this.cbxNamaOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNamaOrg.FormattingEnabled = true;
            this.cbxNamaOrg.Location = new System.Drawing.Point(434, 10);
            this.cbxNamaOrg.Margin = new System.Windows.Forms.Padding(10);
            this.cbxNamaOrg.Name = "cbxNamaOrg";
            this.cbxNamaOrg.Size = new System.Drawing.Size(272, 33);
            this.cbxNamaOrg.TabIndex = 16;
            // 
            // lblOrg
            // 
            this.lblOrg.AutoSize = true;
            this.lblOrg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrg.Location = new System.Drawing.Point(10, 13);
            this.lblOrg.Margin = new System.Windows.Forms.Padding(10);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(119, 24);
            this.lblOrg.TabIndex = 15;
            this.lblOrg.Text = "Organisasi:";
            // 
            // cbxTingkat
            // 
            this.cbxTingkat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTingkat.FormattingEnabled = true;
            this.cbxTingkat.Location = new System.Drawing.Point(142, 10);
            this.cbxTingkat.Margin = new System.Windows.Forms.Padding(10);
            this.cbxTingkat.Name = "cbxTingkat";
            this.cbxTingkat.Size = new System.Drawing.Size(272, 33);
            this.cbxTingkat.TabIndex = 13;
            this.cbxTingkat.SelectedIndexChanged += new System.EventHandler(this.cbxTingkat_SelectedIndexChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(72, 32);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Chat";
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1924, 882);
            this.Controls.Add(this.pnlChat);
            this.Controls.Add(this.lblHeader);
            this.Name = "FormChat";
            this.Text = "FormChat";
            this.pnlChat.ResumeLayout(false);
            this.pnlChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.DataGridView dtgChat;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.ComboBox cbxNamaOrg;
        private System.Windows.Forms.Label lblOrg;
        private System.Windows.Forms.ComboBox cbxTingkat;
        private System.Windows.Forms.Label lblHeader;
    }
}