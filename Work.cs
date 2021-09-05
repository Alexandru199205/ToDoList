using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Work : UserControl
    {
        public Work()
        {
            InitializeComponent();
        }

        int pos = 10;
        public void Additem(string text)
        {
            ToDoItem item = new ToDoItem(text);
            panel1.Controls.Add(item);
            item.Top = pos;
            pos = (item.Height + item.Top + 10);

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string taskName = text.Text;
            Additem(taskName);
        }
    }
}
