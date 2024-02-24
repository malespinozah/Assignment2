using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Schema;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        //GET api/J1/Menu/{burger}/{drink}/{side}/{dessert}

        /// <summary>
        /// Receives 4 inputs which have differentes calories and returns the sum of them
        /// Each input has its own index
        /// </summary>
        /// <param name="burger">Index burger choice</param>
        /// <param name="drink">Index drink choice</param>
        /// <param name="side">Index side choice</param>
        /// <param name="dessert">Index dessert choice</param>
        /// <returns>
        /// The sum of each choice from the index
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/J1/Menu/{4}/{4}/{4}/{4} -> "Your total calorie count is 0"
        /// </example>

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]

        public int Menu(int burger, int drink, int side, int dessert)
        {
            //initialization
            int calories = 0;

            //burger
            if (burger == 1)
            {
                calories = 461;
            }
            else if (burger == 2)
            {
                calories = 431;
            }
            else if (burger == 3)
            {
                calories = 420;
            }
            else
            {
                calories = 0;
            }

            //drink
            if (drink == 1)
            {
                calories = calories + 130;
            }
            else if (drink == 2)
            {
                calories = calories + 160;
            }
            else if (drink == 3)
            {
                calories = calories + 118;
            }
            else
            {
                calories = calories + 0;
            }

            //side
            if (side == 1)
            {
                calories = calories + 100;
            }
            else if (side == 2)
            {
                calories = calories + 57;
            }
            else if (side == 3)
            {
                calories = calories + 70;
            }
            else
            {
                calories = calories + 0;
            }


            //dessert
            if (dessert == 1)
            {
                calories = calories + 167;
            }
            else if (dessert == 2)
            {
                calories = calories + 266;
            }
            else if (dessert == 3)
            {
                calories = calories + 75;
            }
            else
            {
                calories = calories + 0;
            }

            return calories;
        }
    }
}
