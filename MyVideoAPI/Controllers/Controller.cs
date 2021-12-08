using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyVideoAPI.Models;

namespace MyVideoAPI.Controllers
{
    [Route("api/v1/[controller]")]  
    [ApiController]  
    public class videosController : ControllerBase  
    {  
        private MyVideoApiContext myDbContext;  
  
        public videosController(MyVideoApiContext context)  
        {  
            myDbContext = context;  
        }  
  
        [HttpGet]  
        public IList<VideoModel> Get()  
        {  
            return (this.myDbContext.MyVideos.ToList());  
        }  
    }  
}