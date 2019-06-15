using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessStats.DTOs
{
    public class InitialRecord
    {
        public int Rating { get; set; }
        public int Win { get; set; }
        public int Loss { get; set; }
        public int Draw { get; set; }

        public InitialRecord(int rating, int win, int loss, int draw)
        {
            Rating = rating;
            Win = win;
            Loss = loss;
            Draw = draw;
        }
        
    }
}
