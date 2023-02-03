using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Entities
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string Header { get; set; } = "";
        public string Descriprion { get; set; } = "";
        public string FullInfo
        {
            get
            {
                return "Id: " + Id + " " + "Header: " + Header + " " + "Description: "+Descriprion;
            }
        }
    }
}
