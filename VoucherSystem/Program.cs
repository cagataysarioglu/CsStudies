using System;
using System.Collections.Generic;

namespace VoucherSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = new Player
            {
                Id = 3,
                Name = "Çağatay",
                Surname = "Sarıoğlu",
                TaxpayerNo = "743918",
            };

            GameSeller gameSeller = new GameSeller();
            EStateVerification verifier = new EStateVerification();

            if (verifier.GiveInfo(playerOne) == playerOne.TaxpayerNo)
            {
                IPlayerService playerManager = new PlayerManager();
                playerManager.Register();
            }
        }
    }
}
