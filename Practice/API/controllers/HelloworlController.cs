using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.controllers
{
    [ApiController]

    //http://localhost:8080/api/HelloWorld

    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase

    //http://localhost:8080/api/HelloWorld/weatherforecast

    {
        [HttpGet("weatherforecast")]
        public string WeatherForecast()
        {
            return "hello world";
        }

    //http://localhost:8080/api/HelloWorld/hello?text=cscsd

         [HttpGet("hello")]
        public string WeatherForecast(string text)
        {
            return $"{text}!";
        }
         

         [HttpGet("sum")]
        public string WeatherForecast(int x, int y)
        {
           return $"{x} + {y} = {x + y}!";
        }
    }
}