
namespace mim_c_hash_new
{
    partial class List
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
        public System.Windows.Forms.FlowLayoutPanel getHook()
        {
            return list2;
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.list2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here Is The List of All Saved Stories";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // list2
            // 
            this.list2.AutoScroll = true;
            this.list2.AutoSize = true;
            this.list2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.list2.Location = new System.Drawing.Point(32, 47);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(714, 451);
            this.list2.TabIndex = 1;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.list2);
            this.Controls.Add(this.label1);
            this.Name = "List";
            this.Size = new System.Drawing.Size(762, 501);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel list2;
    }
}
