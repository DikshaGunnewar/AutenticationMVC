using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web.data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private StudentDbContext studentDbContext;

        /// <summary>
        /// Intializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="dbFactory"></param>
        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

         /// <summary>
         /// Get the database. 
         /// <value>
         /// The database context.
         /// </value>
         /// </summary> 
        private StudentDbContext StudentDbContext
        {
            get {
                return studentDbContext ?? (studentDbContext = dbFactory.Init());
            }
        }
        /// <summary>
        /// Commits this instance.
        /// </summary>
        public void Commit()
        {
            StudentDbContext.Commit();
        }
    }
}
