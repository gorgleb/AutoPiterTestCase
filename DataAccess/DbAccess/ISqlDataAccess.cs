using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbAccess;
//Интерфейс для работы с SQl, в текущем контексте работаю только с LoadData,
//но для других задач / расширения программы создал метод SaveData - для сохранения данных
//Он пригодится при изменении записей в БД
public interface ISqlDataAccess
{
    Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parametrs, string connectionId = "Default");
    Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "Default");
}
