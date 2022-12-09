using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet;
public class Owner
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Owner_Id { get; set; }
    [ForeignKey("Owner_Id")]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DriverLicense { get; set; }
    public Owner(int owner_Id, string firstName, string lastName, string driverLicense)
    {
        Owner_Id = owner_Id;
        FirstName = firstName;
        LastName = lastName;
        DriverLicense = driverLicense;
    }
}