using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using web.services.Abstract.Student;

namespace web.api.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class StudentsController : ApiController
    {
        private readonly IStudentService _iStudentService;

        /// <summary>
        /// Initializes a new instance of the <see cref="StudentsController"/> class.
        /// </summary>
        /// <param name="iAddStudentService"></param>
        public StudentsController(IStudentService iAddStudentService)
        {
            _iStudentService = iAddStudentService;
        }

       
    }
}
