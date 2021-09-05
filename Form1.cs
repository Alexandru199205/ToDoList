using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Todolist : Form
    {
        public Todolist()
        {
            InitializeComponent();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }

        private void Workbtn_Click(object sender, EventArgs e)
        {
            work1.BringToFront();
        }

        private void Proj1btn_Click(object sender, EventArgs e)
        {
            project11.BringToFront();
        }

        private void Proj2btn_Click(object sender, EventArgs e)
        {
            project21.BringToFront();
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
