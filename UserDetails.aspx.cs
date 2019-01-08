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
    public partial class UserDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<User> GetProduct([QueryString("UserID")] int? userID)
        {
            var _db = new SystemKnowledgeWebForms.Models.UserContext();
            IQueryable<User> query = _db.Users;
            if (userID.HasValue && userID > 0)
            {
                query = query.Where(p => p.UserID == userID);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}