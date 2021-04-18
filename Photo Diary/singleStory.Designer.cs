
namespace mim_c_hash_new
{
    partial class singleStory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(singleStory));
            this.sPicture = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // sPicture
            // 
            this.sPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sPicture.Image = ((System.Drawing.Image)(resources.GetObject("sPicture.Image")));
            this.sPicture.Location = new System.Drawing.Point(30, 9);
            this.sPicture.Name = "sPicture";
            this.sPicture.Size = new System.Drawing.Size(137, 124);
            this.sPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sPicture.TabIndex = 0;
            this.sPicture.TabStop = false;
            this.sPicture.Click += new System.EventHandler(this.sPicture_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(179, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(50, 13);
            this.title.TabIndex = 1;
            this.title.Text = "Story title";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(180, 57);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(28, 13);
            this.date.TabIndex = 2;
            this.date.Text = "date";
            // 
            // singleStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.date);
            this.Controls.Add(this.title);
            this.Controls.Add(this.sPicture);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "singleStory";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(858, 145);
            this.Load += new System.EventHandler(this.singleStory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sPicture;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label date;
    }
}
