﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web.data.Infrastructure
{
    public interface IDbFactory:IDisposable
    {
        StudentDbContext Init();
    }
}
