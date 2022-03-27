using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Routing;
using System.Web.Http;
using vidly.Models;
using vidly.Dtos;
using AutoMapper;
using System.Data.Entity;
using System;

namespace vidly.Controllers.Api
{
    public class CustomerController : ApiController
    {
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        //Get/Api/Customers
        [HttpGet]
        public IEnumerable<CustomerDto> GetCustomer(string queries = null)
        {
            var customersQuery = _context.Customers.Include(x => x.MemberShipTypes);
            if (queries != null)
                customersQuery = customersQuery.Where(c => c.CustomersName.Contains(queries));

            var customer = customersQuery.ToList().Select(Mapper.Map<Customers, CustomerDto>);
            return customer;

        }
        //Get/Api/Customers/id
        [HttpGet]
        public CustomerDto Details(int id)
        {

            var customer = _context.Customers.Include(x => x.MemberShipTypes).SingleOrDefault(x => x.Id == id);

            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<Customers, CustomerDto>(customer);
        }

        //Post Api/Customer/Customer
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto cutomerdto)
        {
            if (!ModelState.IsValid)
                BadRequest();
            var customer = Mapper.Map<CustomerDto, Customers>(cutomerdto);
            _context.Customers.Add(customer);
            _context.SaveChanges();
            cutomerdto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri + "/" + cutomerdto.Id), cutomerdto);
        }
        [HttpPut]
        public void UpdateCustomer(CustomerDto cutomerdto, int id)
        {

            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var CustomerInDb = _context.Customers.SingleOrDefault(x => x.Id == id);
            if (CustomerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(cutomerdto, CustomerInDb);
            _context.SaveChanges();

        }
        [HttpDelete]
        public void RemoveCustomer(int id)
        {
            var CustomerInDb = _context.Customers.SingleOrDefault(x => x.Id == id);
            if (CustomerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Customers.Remove(CustomerInDb);
            _context.SaveChanges();
        }
    }
}
