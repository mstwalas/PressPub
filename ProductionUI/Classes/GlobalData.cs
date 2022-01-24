using ProductionLogic.Core.Domain;
using ProductionLogic.Persistence;

namespace ProductionUI.Classes
{
    public static class GlobalData
    {
         public static string ConnectionString = "Data Source=DESKTOP-JT4CQQM;Initial Catalog=ProductionDB;Integrated Security=True";
         //public static string ConnectionString = "Server=.;Database=ProductionDB;Trusted_Connection=True;";
         //public static string ConnectionString = "Server=COMP-05;Database=ProductionDB;Trusted_Connection=True;";

        // public static string ConnectionString = "Server=COMP-05;Database=ProductionDB;User Id=sa;Password=123;";

        public static UnitOfWork UnitOfWork = new UnitOfWork(new ProductionContext(ConnectionString));

        public static User LoginUser = UnitOfWork.Users.GetUserWithAllData(2);
    }
}