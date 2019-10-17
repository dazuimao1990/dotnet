using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sample.RabbitMQ.MySql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //return new string[] { "ok"};
            string MYSQL_HOST = Environment.GetEnvironmentVariable("MYSQL_HOST");
            string MYSQL_PORT = Environment.GetEnvironmentVariable("MYSQL_PORT");
            string MYSQL_USER = Environment.GetEnvironmentVariable("MYSQL_USER");
            string MYSQL_PASSWORD = Environment.GetEnvironmentVariable("MYSQL_PASSWORD");
            string MYSQL_DATABASE = Environment.GetEnvironmentVariable("MYSQL_DATABASE");
            return new string[] { MYSQL_HOST, MYSQL_PORT, MYSQL_USER, MYSQL_PASSWORD, MYSQL_DATABASE };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        /// <summary>
        /// 获取Mysql连接信息
        /// </summary>
        /// <returns></returns>
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> MysqlDemo()
        //{
        //   // ViewData["Title"] = title;
        //    string MYSQL_HOST = Environment.GetEnvironmentVariable("MYSQL_HOST");
        //    string MYSQL_PORT = Environment.GetEnvironmentVariable("MYSQL_PORT");
        //    string MYSQL_USER = Environment.GetEnvironmentVariable("MYSQL_USER");
        //    string MYSQL_PASSWORD = Environment.GetEnvironmentVariable("MYSQL_PASSWORD");
        //    string MYSQL_DATABASE = Environment.GetEnvironmentVariable("MYSQL_DATABASE");
        //    return new string[] { MYSQL_HOST, MYSQL_PORT, MYSQL_USER , MYSQL_PASSWORD, MYSQL_DATABASE };
        //}
    }
}
