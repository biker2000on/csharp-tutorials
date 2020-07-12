using System;
using System.ComponentModel.DataAnnotations;

namespace webApp.Models
{
  public class Movie
  {
    public int ID { get; set; }
    public string Title { get; set; }

    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
    public string Genre { get; set; }
    public decimal Price { get; set; }
  }
}