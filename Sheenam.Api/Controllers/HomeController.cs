﻿//================================================
//Copyright (c) Calition of Good-Hearted Engineers
//Free To Use To Find Comfort and Peace
//================================================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Sheenam.Api.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() => 
           Ok("Hello Garry, the princess is in another castle");
    }
}
