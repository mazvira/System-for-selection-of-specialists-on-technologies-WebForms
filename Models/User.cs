using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SystemKnowledgeWebForms.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public int UserID { get; set; }
        
        [StringLength(100), Display(Name = "Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public string Birthdate { get; set; }
        public string Mobilephone { get; set; }
        public bool isAdmin { get; set; }
        public string ImagePath { get; set; }
        public virtual ICollection<AreaOfKnowledge> AreasOfKnowledges { get; set; }

        public virtual string MyString(ICollection<AreaOfKnowledge> areaOfKnowledges)
        {
            string result = "";
            if (areaOfKnowledges != null)
            {
                foreach (AreaOfKnowledge area in areaOfKnowledges)
                    result =  result + area.AreaOfKnowledgeName + "; ";
            }
            return result;      
        }
    }
}

/*  [Display(Name = "Release Date")]
       [DataType(DataType.Date)]
       [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]*/

//   public virtual AreaOfKnowledge AreaOfKnowledge { get; set; }
