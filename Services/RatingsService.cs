using ChessStats.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChessStats.Services
{
    public class RatingsService
    {
        private readonly HttpClient _client;

        public RatingsService(HttpClient client)
        {
            _client = client;
        }

        public async Task<RatingsCallResult> GetRatingsByPlayerName(string playerName)
        {
            try
            {
                RatingsResponse ratings = await _client.GetJsonAsync<RatingsResponse>($"https://api.chess.com/pub/player/{playerName}/stats");
                return new RatingsCallResult(ratings, true);
            }
            catch (Exception e)
            {
                return new RatingsCallResult(null, false);
            }
        }
    }
}
