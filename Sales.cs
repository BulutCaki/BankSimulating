using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class Sales
    {
        public void Sale(User user , Discount discount , GameList<string> gameList)
        {
            Console.WriteLine(user.UserName +" adlı kullanıcı " + discount.DiscountPrice + " tutarında indirim ile " + gameList.Length + " adet oyun satın aldı");
            Console.WriteLine("----------------------");
            Console.WriteLine("Satın Alınan Oyunlar:");

            for (int i = 0; i < gameList.Length; i++)
            {
                Console.WriteLine(gameList.Game[i]);
            }
        }
    }
}
