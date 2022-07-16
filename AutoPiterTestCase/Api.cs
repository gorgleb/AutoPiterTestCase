using DataAccess.Data;

namespace AutPiterTestCase;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        //All api endpoint mapping
        app.MapGet("/Excellents", SelectTheExcellents);
        app.MapGet("/Average", SelectAverageStudents);
        app.MapGet("/ClassList", SelectClassListOrderedByStudentsAchievement);

    }

   
    //SelectTheExcellents возвращает список учеников, которые учатся только на 4 и 5
    private static async Task<IResult> SelectTheExcellents(ISchoolData data)
       
    {
        try
        {
            return Results.Ok(await data.SelectTheExcellents());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    //SelectAverageStudents - возвращает список учеников, которые имеют средний балл > 3.5 и < 4.5
    private static async Task<IResult> SelectAverageStudents(ISchoolData data)
    {
        try
        {
            return Results.Ok(await data.SelectAverageStudents());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    //SelectClassListOrderedByStudentsAchievement - Возвращает список имен классов,
    //отсортированных в порядке убывания среднего бала учеников
    private static async Task<IResult> SelectClassListOrderedByStudentsAchievement(ISchoolData data)
    {
        try
        {
            return Results.Ok(await data.SelectClassListOrderedByStudentsAchievement());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
