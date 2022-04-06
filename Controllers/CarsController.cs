using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using afternoonChallenge040622.Models;
using afternoonChallenge040622.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace afternoonChallenge040622.Controllers
{
  [Route("api/[controller]")]
  public class CarsController : Controller
  {
    private readonly CarsService _carsService;

    public CarsController(CarsService carsService)
    {
      _carsService = carsService;
    }


    [HttpGet]
    public ActionResult<List<Car>> Get()
    {
      try
      {
        List<Car> cars = _carsService.GetAll();
        return Ok(cars);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Car> GetById(int id)
    {
      try
      {
        Car car = _carsService.GetById(id);
        return Ok(car);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car carData)
    {
      try
      {
        Car car = _carsService.Create(carData);
        return Created($"api/cars/{car.Id}", car);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]

    public ActionResult<Car> EditCar(int id, [FromBody] Car carData)
    {
      try
      {
        carData.Id = id;
        Car car = _carsService.EditCar(carData);
        return Ok(carData);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<Car> Remove(int id)
    {
      try
      {
        _carsService.Remove(id);
        return Ok("Deletey Completey");
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}