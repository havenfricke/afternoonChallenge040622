using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using afternoonChallenge040622.Models;
using afternoonChallenge040622.Repositories;

namespace afternoonChallenge040622.Services
{
  public class CarsService
  {

    private readonly CarsRepository _carsRepo;

    public CarsService(CarsRepository carsRepo)
    {
      _carsRepo = carsRepo;
    }


    internal List<Car> GetAll()
    {
      return _carsRepo.GetAll();
    }

    internal Car GetById(int id)
    {
      Car found = _carsRepo.GetById(id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal Car Create(Car carData)
    {
      return _carsRepo.Create(carData);
    }

    internal Car EditCar(Car carData)
    {
      Car original = GetById(carData.Id);
      original.Name = carData.Name ?? original.Name;
      original.Color = carData.Color ?? original.Color;
      original.Year = carData.Year ?? original.Year;
      _carsRepo.EditCar(original);
      return original;
    }

    internal void Remove(int id)
    {
      GetById(id);
      _carsRepo.Remove(id);
    }
  }
}