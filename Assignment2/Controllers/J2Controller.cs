using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        //GET api/J2/DiceGame/{m}/{n}/

        /// <summary>
        /// Count from {m} to {n} by 1s
        /// </summary>
        /// <returns>
        /// returns the sequence of {m} to {n} as a message counting by 1
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/J2/DiceGame/{6}/{8} -> "There are 5 total ways to get the sum 10"
        /// </example>


        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

        public string DiceGame(int m, int n)
        {
            int count = 0;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if(i + j == 10)
                    {
                        count++;
                    }
                }
            }

            string totalWays = "There are " + count + " ways to get the sum 10.";
            return totalWays;

        }
    }
}
