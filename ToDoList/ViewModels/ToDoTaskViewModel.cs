using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoList.Commands;
using ToDoList.Entities;

namespace ToDoList.ViewModels
{
    public class ToDoTaskViewModel
    {
        static int id = 0;
        public string Header { get; set; } = "";
        public string Description { get; set; } = "";

        public ToDoTask SelectedPerson { get => ToDoTasks.FirstOrDefault(p => p.Id == SelectedId); }
        public int SelectedId { get; set; }
        //public ICommand AddCommand { get; set; }
        public BindingList<ToDoTask> ToDoTasks { get; }
        public ToDoTaskViewModel()
        {
            ToDoTasks = new BindingList<ToDoTask>
            {
                new ToDoTask {Id=++id, Header="Homework", Descriprion="math,rading......"},
                new ToDoTask {Id=++id, Header="Programming", Descriprion="topic number 5"},
                new ToDoTask {Id=++id, Header="Sport training",Descriprion="20 push-ups"}
            };
        }
        public void Add()
        {
            ToDoTasks.Add(new ToDoTask { Id = ++id, Header = this.Header, Descriprion = this.Description });
            Header = ""; Description = "";
        }
        public void Remove()
        {
            ToDoTasks.Remove(SelectedPerson);
        }
    }
}
