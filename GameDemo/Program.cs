using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Id = 1;
            user1.UserName = "BBlut";
            user1.Password = "202426";
            user1.Email = "buluttcakki@gmail.com";
            user1.TcNumber = "78541232568";
            user1.FirstName = "Bulut";
            user1.LastName = "Çakı";
            user1.Age = 21;

            IVerification verification = new Verification();
            UserManager userManager = new UserManager(verification);
            userManager.Register(user1);

            GameList<string> gameList = new GameList<string>();
            gameList.Add("PayDay2");
            gameList.Add("FİFA21");
            gameList.Add("GTA5");

            Discount discount = new Discount();
            discount.Id = 3;
            discount.DiscountName = "NewUser";
            discount.DiscountPrice = 63;

            Sales sale = new Sales();
            sale.Sale(user1, discount, gameList);

        }
    }
}
