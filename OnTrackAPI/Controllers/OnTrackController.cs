using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using OnTrackAPI.Models;
using OnTrackAPI.Data;

/* 
 * A very simple to create API. One question though:  is it ok to access 
 * directly the database from controller without using a unit of work or a 
 * data transfer object?
 * Hi, ideally you could create a data-access-layer and a CRUD-interface for 
 * accessing data but if you want to keep it easy for simple usage you can 
 * access the db directly from controller
*/
namespace OnTrackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnTrackController : ControllerBase
    {
        private readonly ApiContext _context;

        public OnTrackController(ApiContext context)
        {
            _context = context;
        }
    }
}
