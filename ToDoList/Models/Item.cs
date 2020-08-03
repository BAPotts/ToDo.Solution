using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
    public class Item
    {
        public Item()
        {
            this.Categories = new HashSet<CategoryItem>();
            Done = false;
        }

        public int ItemId { get; set; }
        public string Description { get; set; }

        public bool Done {get; set;}

        public DateTime DueDate {get; set; }

        public string DueDateInfo {get { return DueDate.ToString("MM/dd/yyyy");}}

        public ICollection<CategoryItem> Categories { get;}
    }
}