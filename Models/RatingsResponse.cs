using System;
using System.Collections.Generic;
using System.Text;

namespace ChessStats.Shared
{
    public class RatingsResponse
    {
        public ChessBullet chess_bullet { get; set; }
        public ChessBlitz chess_blitz { get; set; }
    }
}
