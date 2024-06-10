using CarsRepositoryApi.Models;
using CarsRepositoryApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarsRepositoryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICar _carrepo;
        public CarController(ICar car)
        {
            _carrepo = car;
        }
        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            var a = _carrepo.GetAllCars();
            if(a == null)
            {
                return NotFound();
            }
            return Ok(a);
        }
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            Car c = _carrepo.GetCarById(id);
            if(c == null)
            {
                return NotFound();

            }
            return Ok(c);
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult Creates(Car car)
        {
            int rs = _carrepo.CreatCar(car);
            if(rs <= 0) {
                return BadRequest("Failed");
            }
            else
                return Ok("Added : "+rs);
        }
        [HttpPost]
        [Route("Edit")]
        public IActionResult Updates(Car car)
        {
            int rs = _carrepo.UpdateCar(car);
            if (rs <= 0)
            {
                return BadRequest("Failed");
            }
            else
                return Ok("Updated : " + rs);
        }

        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            int rs = _carrepo.DeleteCar(id);
            if (rs <= 0)
            {
                return BadRequest("Failed");
            }
            else
                return Ok("Deleted : " + rs);
        }
    }
}
