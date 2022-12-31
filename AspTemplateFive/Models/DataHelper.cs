using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspTemplateFive.Controllers
{
    public class DataHelper
    {
        public static async Task InitData(ApplicationDbContext applicationDbContext)
        {
            var totalPerson = await applicationDbContext.Persons.CountAsync();
            if (totalPerson == 0)
            {
                var persons = Enumerable.Range(1, 100)
                    .Select(x => new Person()
                    {
                        Name = "Person " + x,
                        Age = x,
                    }).ToList();
                await applicationDbContext.Persons.AddRangeAsync(persons);
            }
            
            var totalStudents = await applicationDbContext.Students.CountAsync();
            if (totalStudents == 0)
            {
                var students = Enumerable.Range(1, 100)
                    .Select(x => new Student()
                    {
                        StudentName = "Student " + x,
                        Status = "status " + x,
                        Age = x,
                    }).ToList();
                await applicationDbContext.Students.AddRangeAsync(students);
            }

            await applicationDbContext.SaveChangesAsync();
        }

    


    }
}