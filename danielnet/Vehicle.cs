using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet;
public class Vehicle
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Vehicle_Id { get; set; }
    [ForeignKey("Vehicle_Id")]
    public string Brand { get; set; }
    public string Vin { get; set; }
    public string Color { get; set; }
    public int Year { get; set; }

    [ForeignKey("owner_id")]
    public virtual Owner Owner { get; set; }
    public Vehicle(int vehicle_Id, string brand, string vin, string color, int year, Owner owner)
    {
        Vehicle_Id = vehicle_Id;
        Brand = brand;
        Vin = vin;
        Color = color;
        Year = year;
        Owner = owner;
    }
    private Vehicle(int vehicle_Id, string brand, string vin, string color, int year)
    {
        Vehicle_Id = vehicle_Id;
        Brand = brand;
        Vin = vin;
        Color = color;
        Year = year;
    }
}