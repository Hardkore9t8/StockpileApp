using System;
using Microsoft.AspNetCore.Http;

namespace Stockpile.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message) 
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
        public static int CalculateAge(this DateTime theDateTime)
        {
            var AccountAge = DateTime.Today.Year - theDateTime.Year;
            if(theDateTime.AddYears(AccountAge) > DateTime.Today)
            AccountAge--;
            return AccountAge;
        }
    }
}