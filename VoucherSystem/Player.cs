using System;
using System.Collections.Generic;
using System.Text;

namespace VoucherSystem
{
    class Player : PlayerManager
    {
        public int Id { get; set; }
        public string TaxpayerNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
