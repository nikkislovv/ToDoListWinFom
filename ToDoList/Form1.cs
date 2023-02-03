using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.ViewModels;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        ToDoTaskViewModel toDoTaskViewModel = new ToDoTaskViewModel();
        public Form1()
        {
            InitializeComponent();
            ListBoxTasks.DataSource = toDoTaskViewModel.ToDoTasks;
            //ListBoxTasks.DataBindings.Add(new Binding("DataSource", toDoTaskViewModel, "ToDoTasks", false, DataSourceUpdateMode.OnPropertyChanged));
            ListBoxTasks.DisplayMember = "FullInfo";
            ListBoxTasks.ValueMember = "Id";
            ListBoxTasks.DataBindings.Add(new Binding("SelectedValue", toDoTaskViewModel, "SelectedId", false, DataSourceUpdateMode.OnPropertyChanged));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TaskCreation taskCreation = new TaskCreation(toDoTaskViewModel);

            taskCreation.Show();
        }

        private void btnRemoving_Click(object sender, EventArgs e)
        {
            if (ListBoxTasks.SelectedValue != null)
            {
                toDoTaskViewModel.Remove();
                var a = ListBoxTasks.Items;
                //ListBoxTasks.SelectedValue = null;
            }

        }
    }
}
