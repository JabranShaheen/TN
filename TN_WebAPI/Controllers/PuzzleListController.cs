﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TN_WebAPI.Controllers
{
    public class PuzzleListController : ApiController
    {
        // GET: api/PuzzleList
        public IEnumerable<string> Get()
        {


            return new string[] { "value1", "value2" };
        }

        // GET: api/PuzzleList/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PuzzleList
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PuzzleList/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PuzzleList/5
        public void Delete(int id)
        {
        }
    }
}
