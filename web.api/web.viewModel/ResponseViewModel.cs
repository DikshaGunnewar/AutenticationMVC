using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web.viewModel
{
    public class ResponseViewModel
    {
        public long Id { get; set; }

        /// <summary>
        /// sets a value Indicating whether this instance is success.
        /// <value>
        /// True/False.
        /// </value>
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Sets a Message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Sets the Content.
        /// </summary>
        public string Content { get; set; }
    }
}
