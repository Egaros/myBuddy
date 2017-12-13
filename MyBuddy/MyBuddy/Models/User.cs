using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuddy
{
   public class User : BaseModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Image { get; set; }

        public string Password { get; set; }

        public string lastSeen { get; set; }

        public override string ToString()
        {
            return string.Format("[Person: ID={0}, FirstName={1}]", ID, Name);
        }
    }
}
