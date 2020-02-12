using System;
using System.ComponentModel.DataAnnotations;

namespace LuckySpin.Models
{
    public class Spin
    {
        public int A { get; set; }

        public int B { get; set; }

        public int C { get; set; }

        public int Luck { get; set; }

        public Boolean IsWinning { get; set; }
        public long Id { get; set; }
       
    }
}
