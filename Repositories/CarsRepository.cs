using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using afternoonChallenge040622.Models;
using Dapper;

namespace afternoonChallenge040622.Repositories
{
  public class CarsRepository
  {

    private readonly IDbConnection _db;

    public CarsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal List<Car> GetAll()
    {
      string sql = "SELECT * FROM cars;";
      return _db.Query<Car>(sql).ToList();
    }

    internal Car GetById(int id)
    {
      string sql = "SELECT * FROM cars WHERE id = @id";
      return _db.QueryFirstOrDefault<Car>(sql, new { id });
    }

    internal Car Create(Car carData)
    {
      string sql = @"
      INSERT INTO cars
      (name, color, year)
      VALUES
      (@Name, @Color, @Year);
      SELECT LAST_INSERT_ID();";

      int id = _db.ExecuteScalar<int>(sql, carData);
      carData.Id = id;
      return carData;
    }

    internal void EditCar(Car original)
    {
      string sql = @"
      UPDATE cars
      SET
        name = @Name,
        color = @Color,
        year = @Year
        WHERE id = @Id;
      ";
      _db.Execute(sql, original);
    }

    internal void Remove(int id)
    {
      string sql = "DELETE FROM cars WHERE id = @id LIMIT 1;";
      _db.Execute(sql, new { id });
    }
  }
}