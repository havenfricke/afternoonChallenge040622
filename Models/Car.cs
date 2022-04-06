using System;
using System.ComponentModel.DataAnnotations;

namespace afternoonChallenge040622.Models
{
  public class Car
  {
    [Required]
    public int Id { get; set; }

    [MinLength(3)]
    public string Name { get; set; }
    [MinLength(3)]
    public string Color { get; set; }
    [Range(1950, 2022)]
    public int? Year { get; set; }

  }
}