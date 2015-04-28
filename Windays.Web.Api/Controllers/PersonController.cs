using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Windays.Web.Api.Data;
using Windays.Web.Api.Infrastructure.Filters;
using Windays.Web.Api.Infrastructure.Results;

namespace Windays.Web.Api.Controllers
{
    public class PeopleController : ApiController
    {
        private readonly IPersonRepository _repository;

        public PeopleController(IPersonRepository repository)
        {
            this._repository = repository;
        }
                
        [CacheFilter(15)]
        public IHttpActionResult Get()
        {
            var people = _repository.GetPeople(null, null);
            return new ModelWithEtagResponse(people, this.Request);
        }

        [CacheFilter(15)]
        public IHttpActionResult Get(Guid id)
        {
            var person = _repository.GetPerson(id);
            return Ok();
            //return new ModelWithEtagResponse(person, this.Request);
        }

        [ValidateFilter]
        public HttpResponseMessage Post(Person person)
        {
            _repository.CreatePerson(person);
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        public HttpResponseMessage Delete(Guid id)
        {
            _repository.DeletePerson(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
