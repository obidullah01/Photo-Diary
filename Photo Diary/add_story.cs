using System;
using System.Windows.Forms;

namespace mim_c_hash_new
{
    public partial class add_story : UserControl
    {
        public add_story()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All jpg files(*.jpg)|*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picture.ImageLocation = open.FileName;
            }

        }

        private void save_Click(object sender, EventArgs e)
        {


            String title = this.title.Text;
            String story = this.body.Text;
            DateTime date = this.date.Value;
            Story one = new Story(title, story, date, picture.ImageLocation);
            Data.stored.Add(one);
            MessageBox.Show("Story Created Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Data.hook.Controls.Clear();






        }
    }
}
