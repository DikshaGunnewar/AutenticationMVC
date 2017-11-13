﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web.data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;


        /// <summary>
        /// Perform application-defined tasks associated with freeing, releasing or resetting unmanaged resourses.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Disposable"/> class.
        /// </summary>
        ~Disposable()
        {
            Dispose(false);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();

                isDisposed = true;
            }
        }

        //Overrides this to dispose custom objects
        protected virtual void DisposeCore()
        {

        }
    }
}

