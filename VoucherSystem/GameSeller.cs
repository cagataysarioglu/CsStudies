using System;
using System.Collections.Generic;
using System.Text;

namespace VoucherSystem
{
    class GameSeller : EStateVerification
    {
        public void Check(IPlayerService player)
        {
            Console.WriteLine(player + "bilgileri doğrulandı.");
        }
    }
}
