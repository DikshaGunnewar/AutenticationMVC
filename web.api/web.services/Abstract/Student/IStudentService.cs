using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web.viewModel.Student;

namespace web.services.Abstract.Student
{
    public interface IStudentService
    {
        /// <summary>
        /// GEt the student By identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        StudentViewModel GetStudentById(long id);

        /// <summary>
        /// Get All Students.
        /// </summary>
        /// <returns></returns>
        List<StudentViewModel> GetAllStudentsWithoutParam();

        /// <summary>
        /// Create the Student.
        /// </summary>
        /// <param name="addStudentModel"></param>
        /// <returns></returns>
        int AddStudent(StudentViewModel addStudentModel);

        /// <summary>
        /// Update the student Details.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateStudentModel"></param>
        /// <returns></returns>
        int updateStudent(long id, StudentViewModel updateStudentModel);

        /// <summary>
        /// Delete the student by identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteStudent(long id);
    }
}
