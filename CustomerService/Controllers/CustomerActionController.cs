using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomerService.Models;
using System.ComponentModel.DataAnnotations;

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
        public HttpResponseMessage Post(List<Customer> cusomer)
        {
            foreach (Customer cust in cusomer)
            {
                var context = new ValidationContext(cust, null, null);
                var result = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(cust, context, result, true);
                if (result.Count == 0) 
                { 
                    cust.CustomerName = cust.CustomerName.ToUpper(); 
                }
                else 
                { 
                    return Request.CreateResponse(HttpStatusCode.InternalServerError,result); 
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK, cusomer);
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
