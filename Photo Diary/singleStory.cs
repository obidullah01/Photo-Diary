using System;
using System.Windows.Forms;

namespace mim_c_hash_new
{
    public partial class singleStory : UserControl
    {
        Story hold;
        public singleStory(Story tmp)
        {
            InitializeComponent();
            this.title.Text = tmp.title;
            this.sPicture.ImageLocation = tmp.picturePath;
            this.date.Text = tmp.date.ToShortDateString();
            hold = tmp;




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void singleStory_Load(object sender, EventArgs e)
        {

        }

        private void sPicture_Click(object sender, EventArgs e)
        {
            Data.hook.Controls.Clear();
            Data.hook.Controls.Add(new view(hold));
        }
    }
}
