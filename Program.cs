using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace EFTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new Context();


            for (int i = 0; i < 100; i++)
            {
                db.Dates.Add(new DateHolder { Date = DateTime.Now });
            }

            db.SaveChanges();
        }
    }
}
