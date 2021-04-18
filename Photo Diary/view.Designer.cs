
namespace mim_c_hash_new
{
    partial class view
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
            this.pic = new System.Windows.Forms.PictureBox();
            this.t = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(36, 93);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(249, 233);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(32, 21);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(45, 19);
            this.t.TabIndex = 1;
            this.t.Text = "label1";
            this.t.Click += new System.EventHandler(this.t_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(35, 54);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(42, 17);
            this.date.TabIndex = 2;
            this.date.Text = "label2";
            // 
            // data
            // 
            this.data.BackColor = System.Drawing.Color.LavenderBlush;
            this.data.Location = new System.Drawing.Point(308, 21);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(397, 417);
            this.data.TabIndex = 3;
            this.data.Text = "";
            this.data.TextChanged += new System.EventHandler(this.data_TextChanged);
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.data);
            this.Controls.Add(this.date);
            this.Controls.Add(this.t);
            this.Controls.Add(this.pic);
            this.Name = "view";
            this.Size = new System.Drawing.Size(718, 462);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.RichTextBox data;
    }
}
