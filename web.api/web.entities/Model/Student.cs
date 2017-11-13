using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web.entities.Model
{
    /// <summary>
    /// The AddStudent Class.
    /// </summary>
    /// <seealso cref="IEntityBase"/>
    public class Student:IEntityBase
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
