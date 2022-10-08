namespace BankApp.Lib
{
    public class Operation
    {
        public User CurrentUser { get; set; }

        public bool CanBeCancelEFT(User user)
        {
            if (user.IsAdmin) return true;

            if (CurrentUser == user) return true;

            return false;
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}