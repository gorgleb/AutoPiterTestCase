using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;
//Объявляем модель студента, через нее работают методы которые возвращают списки студентов
public class Student
{
    public int SudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Patronymic { get; set; }

    public string ClassId { get; set; }

}
