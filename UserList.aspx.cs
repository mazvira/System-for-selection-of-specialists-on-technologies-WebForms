using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using SystemKnowledgeWebForms.Models;

namespace SystemKnowledgeWebForms
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<User> GetProducts([QueryString("id")] int? areaOfKnowledge)
        {
            var _db = new SystemKnowledgeWebForms.Models.UserContext();
            var _db2 = new SystemKnowledgeWebForms.Models.AreaOfKnowledgeContext();
            IQueryable<User> query = _db.Users;
            IQueryable<AreaOfKnowledge> query2 = _db.AreasOfKnowledge;

            if (areaOfKnowledge.HasValue && areaOfKnowledge > 0)
            {
               query2 = query2.Where(k => k.AreaOfKnowledgeID == areaOfKnowledge);
               /* AreaOfKnowledge area = _db.AreasOfKnowledge
                   .Where(u => u.AreaOfKnowledgeID == areaOfKnowledge)
                   .FirstOrDefault();*/
                query = query.Where(p => p.AreasOfKnowledges.Contains(query2.FirstOrDefault()));
            }
            return query;
        }

    }
}