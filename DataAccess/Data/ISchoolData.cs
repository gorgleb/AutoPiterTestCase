using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;
public interface ISchoolData
{
   
    Task<IEnumerable<Student>> SelectTheExcellents();
    Task<IEnumerable<Student>> SelectAverageStudents();
    Task<IEnumerable<Class>> SelectClassListOrderedByStudentsAchievement();



}
