using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Модель класса, через нее работает метод по возвращению отсортированного списка студентов
namespace DataAccess.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string Name { get; set; }
        public string ClassRoomTeacher { get; set; }
    }
}
