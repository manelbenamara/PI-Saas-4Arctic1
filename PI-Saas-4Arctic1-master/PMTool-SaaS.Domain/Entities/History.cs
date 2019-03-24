﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMTool_SaaS.Domain.Entities
{
    public class History
    {
        public int HistoryId { get; set; }
        public String Description { get; set; }


        public int? TaskId { get; set; }
        [ForeignKey("TaskId")]


        public virtual Task task { get; set; }
    }
}
