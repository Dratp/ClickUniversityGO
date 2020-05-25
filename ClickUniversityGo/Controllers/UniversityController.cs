﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClickUniversityGo.Models;
using ClickUniversityGo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ClickUniversityGo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversityController : ControllerBase
    {

        IConfiguration ConfigRoot;
        private DAL dal;

        public UniversityController(IConfiguration config)
        {
            ConfigRoot = config;
            dal = new DAL(ConfigRoot.GetConnectionString("DefaultConnection"));
        }

        // GET: api/University
        [HttpGet]
        public IEnumerable<University> Get()
        {
            return dal.GetAllUniversities();
        }

        // GET: api/University/5
        [HttpGet("{id}")]
        public University Get(int id)
        {
            return dal.GetUniversityByID(id);
        }

        [HttpGet("act/{id}")]
        public IEnumerable<University> GetACT(int id)
        {
            return dal.GetUniversityByMaxACT(id);
        }

        //// POST: api/University
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/University/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
