using System;
using System.Collections.Generic;
using System.Text;

namespace VoucherSystem
{
    class Player : IPlayerService
    {
        public void Register()
        {
            Console.WriteLine("Oyuncu kaydedildi.");
        }

        public void Update()
        {
            Console.WriteLine("Oyuncu bilgileri güncellendi.");
        }

        public void Delete()
        {
            Console.WriteLine("Oyuncu verileri silindi.");
        }
    }
}
