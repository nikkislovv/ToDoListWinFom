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
    public partial class TaskCreation : Form
    {
        ToDoTaskViewModel taskViewModel;
        public TaskCreation(ToDoTaskViewModel toDoTaskViewModel)
        {
            this.taskViewModel = toDoTaskViewModel;
            InitializeComponent();
            textHeader.DataBindings.Add(new Binding("Text", toDoTaskViewModel, "Header", true, DataSourceUpdateMode.OnPropertyChanged));
            textDescription.DataBindings.Add(new Binding("Text", toDoTaskViewModel, "Description", true, DataSourceUpdateMode.OnPropertyChanged));
            //btnCreating.DataBindings.Add(new Binding("Command", toDoTaskViewModel, "AddCommand", true));//.net 7
        }

        private void btnCreating_Click(object sender, EventArgs e)
        {
            taskViewModel.Add();
            this.Close();
        }
    }
}
