﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CoreCodeCamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LunchController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public LunchController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /*
        public IActionResult Index()
        {
            string connectionData = configuration.GetConnectionString("DefaultConnectionString");
            SqlConnection connection = new SqlConnection(connectionData);
            connection.Open();
            SqlCommand AllMenuesCommand = new SqlCommand("SELECT COUNT(Menu.Description)FROM Customer INNER JOIN Menu ON Menu.CustomerId = Customer.id",
                                                         connection);
            int count = (int)AllMenuesCommand.ExecuteScalar();
            
            connection.Close();
        }
        */

        // GET: api/Lunch
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Lunch/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Lunch
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Lunch/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}