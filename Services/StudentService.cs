using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Branches_Practice.Services
{
    public class StudentService : IStudentService
    {
        List<string> studentList = ["Jacob the nuh uh", "Student 2", "Student 3"];
        public List<string> StudentGetAll()
        {
            return studentList;
        }
    }
}