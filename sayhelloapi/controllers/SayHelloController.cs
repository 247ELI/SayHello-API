using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sayhelloapi.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpGet]
        [Route("sayinghello/{username}")]
        public string SayingHello(string username)
        {
            return $"Hello, {username}";
        }
    }
}