using System;
using System.Windows.Forms;

namespace mim_c_hash_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Data.hook = this.abcd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abcd.Controls.Clear();
            if (Data.stored.Count < 3)
            {
                this.abcd.Controls.Add(new add_story());
            }
            else
            {
                MessageBox.Show("Maximum 3 Story Canbe Stored!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List list = new List();
            abcd.Controls.Clear();
            abcd.Controls.Add(list);
            if (Data.stored.Count == 0)
            {
                Label tmp = new Label();
                tmp.Text = "No story found !";

                list.getHook().Controls.Add(tmp);
            }
            else
            {
                Story[] all = Data.stored.ToArray();

                foreach (Story i in all)
                {
                    list.getHook().Controls.Add(new singleStory(i));
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
