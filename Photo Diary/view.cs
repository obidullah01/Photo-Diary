using System;
using System.Windows.Forms;

namespace mim_c_hash_new
{
    public partial class view : UserControl
    {
        public view(Story one)
        {
            InitializeComponent();
            t.Text = one.title;
            date.Text = one.date.ToShortDateString();
            pic.ImageLocation = one.picturePath;
            data.Text = one.story;
            Console.WriteLine(one.story);
        }

        private void t_Click(object sender, EventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void data_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
