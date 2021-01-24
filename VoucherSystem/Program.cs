using System;

namespace VoucherSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSeller gameSeller = new GameSeller
            {
                Id = 40, TaxpayerNo = "3758906", BirthYear = 1990, Name = "Sencer", Surname = "Kapganoğlu"
            };

            Player playerOne = new Player();
            playerOne.Register();
            playerOne.Update();
        }
    }

    class SalesManager
    {
        static void Sell(IPlayerService player)
        {
            Console.WriteLine(player + "için satış yapıldı.");
        }
    }
}
