using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Board.Models
{
    public class ToDo
    {
        // Уникальное айди каждого итема
        public int Id { get; set; }
        // Описание итема
        public string Description { get; set; }
        //Сделан итем True/false
        public bool progress { get; set; }   
        //Витруальный метод для прикрепления к итему
        public virtual ApplicationUser User { get; set; }
    
        
        

    }
}