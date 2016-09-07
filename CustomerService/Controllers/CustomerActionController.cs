using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomerService.Models;

namespace CustomerService.Controllers
{
    public class CustomerActionController : ApiController
    {
        // GET: api/CustomerAction
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CustomerAction/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CustomerAction
        public List<Customer> Post(List<Customer> cusomer)
        {
            foreach (Customer cust in cusomer)
            {
               cust.CustomerName= cust.CustomerName.ToUpper();
            }
            return cusomer;
        }

        // PUT: api/CustomerAction/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CustomerAction/5
        public void Delete(int id)
        {
        }
    }
}
