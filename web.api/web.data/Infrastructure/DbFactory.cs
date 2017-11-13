using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web.data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private StudentDbContext studentDbContext;


        /// <summary>
        /// Initalizes this instance.
        /// </summary>
        /// <returns></returns>
        public StudentDbContext Init()
        {
            return studentDbContext ?? (studentDbContext = new StudentDbContext());
        }

        protected override void DisposeCore()
        {
            studentDbContext?.Dispose();
        }
    }
}
