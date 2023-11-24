using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIDemo.Controllers
{
    public class ValuesController : ApiController
    {
        string[] arr = new string[3] { "Sourav", "Gourav", "" };
       
        // GET api/values
        public IEnumerable<string> Get()//ShowAll
        {
            return arr;
        }

        // GET api/values/5
        public string Get(int id)
        {
            string v = null;
            if (id==0)
            {
                v = "Sourav";
            }
            else
            {
                v = "Gourav";
            }
            return v;
        }

        // POST api/values
        public void Post([FromBody] string value)//Insert
        {
            arr[2]=value;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
            string v = null;
            if (id == 0)
            {
                v = value;
            }
            else
            {
                v = value;
            }
            

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            if (id == 0)
            {
                arr[id] = null;
            }
            else
            {
                arr[id] = null;
            }
            
        }
    }
}
