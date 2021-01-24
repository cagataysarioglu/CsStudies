using System;
using System.Collections.Generic;
using System.Text;

namespace VoucherSystem
{
    class PlayerManager : IPlayerService
    {
        public void Update()
        {
            Console.WriteLine("Oyuncu güncellemesi yapıldı.");
        }

        public void Delete()
        {
            Console.WriteLine("Oyuncu kaydı silindi.");
        }

        public void Register()
        {
            Console.WriteLine("Oyuncu kaydı yapıldı.");
        }
    }
}
