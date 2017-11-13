using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web.entities.Model;

namespace web.data
{
   public class StudentDbContext:DbContext
    { 
    
        public StudentDbContext():base ("StudentDbContext")
        {

        }
    public virtual int Commit()
    {
        return base.SaveChanges();
    }
     
    //Diksha
    public DbSet<Student> Students { get; set; }
}
}
