using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SystemKnowledgeWebForms.Models
{
    public class AreaOfKnowledge
    {

            [ScaffoldColumn(false)]
            public int AreaOfKnowledgeID { get; set; }

            [StringLength(100), Display(Name = "Name")]
            public string AreaOfKnowledgeName { get; set; }

            [StringLength(100), Display(Name = "ProductDescription")]
            public string Description { get; set; }

            public int? UserID { get; set; }

    }
}