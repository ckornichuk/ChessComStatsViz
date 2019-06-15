using ChessStats.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessStats.DTOs
{
    public class RatingsCallResult
    {
        public RatingsResponse Data { get; }
        public bool IsSuccess { get; }

        public RatingsCallResult(RatingsResponse data, bool isSuccess)
        {
            Data = data;
            IsSuccess = isSuccess;
        }
    }
}
