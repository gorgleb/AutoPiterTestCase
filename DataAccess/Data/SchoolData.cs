using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Data;
namespace DataAccess.Data;

public class SchoolData : ISchoolData
{
    private readonly ISqlDataAccess _db;
    public SchoolData(ISqlDataAccess db)
    {
        _db = db;
    }

    //Вызываем сохраненные процедуры, которые вернут нам соответствующие списки
    public Task<IEnumerable<Student>> SelectTheExcellents() => _db.LoadData<Student, dynamic>("dbo.spStudents_SelectTheExcellents", new { });

    public Task<IEnumerable<Student>> SelectAverageStudents() => _db.LoadData<Student, dynamic>("dbo.spStudents_SelectAverageStudents", new { });
    
    public Task<IEnumerable<Class>> SelectClassListOrderedByStudentsAchievement() => _db.LoadData<Class, dynamic>("dbo.spStudents_SelectClassListOrderedByStudentsAchievement", new { });


}
