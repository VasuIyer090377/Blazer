using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using MyShop.Api.Models;

namespace MyShop.Api.Controllers
{
    [Route("api/adverts")]
    [ApiController]
    public class AdvertisementController : ControllerBase
    {
        private readonly MyshopContext _context;
        public AdvertisementController(MyshopContext context)
        {
            _context = context;
        }

        [HttpPost("add")]
        public ActionResult Add(Advertisement model)
        {
           var savedEntity = _context.Advertisement.Add(model);
            _context.SaveChanges();
            var whereToFindMe = Url.RouteUrl("Get", new {id=savedEntity.Entity.Id}, Request.Scheme);
            return new CreatedResult(whereToFindMe, savedEntity.Entity);
        }

        [HttpGet("{id}", Name="Get")]
        public ActionResult<Advertisement> Get(int id)
        {
            var entity = _context.Find<Advertisement>(id);
            return entity;
        }



    }
}