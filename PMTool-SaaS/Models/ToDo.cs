using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMTool_SaaS.Models
{
    public class ToDo
    {

        public enum Etat { encours , terminer }
        public int Id{ get; set; }
        public String Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateBegin { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateEnd { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DeadLine { get; set; }
        public Etat Status { get; set; }
        public bool IsDone { get; set; }
        public virtual ApplicationUser User { get; set; }



    }
}