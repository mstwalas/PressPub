namespace ProductionUI.Classes.UI_Logic
{
    internal class FormLoginLogic
    {
        public bool LoginChecker(string username, string password)
        {
            var user = GlobalData.UnitOfWork.Users.SingleOrDefault(u =>
                u.UserName == username && u.UserPassword == password);
            if (user != null)
            {
                GlobalData.LoginUser = user;
                return true;
            }

            return false;
        }
    }
}