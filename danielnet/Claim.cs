using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet;
public class Claim
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Claim_Id { get; set; }
    [ForeignKey("Claim_Id")]
    public string Description { get; set; }
    public string Status { get; set; }
    public DateTime Date { get; set; }

    [ForeignKey("vehicle_id")]
    public virtual Vehicle Vehicle { get; set; }
    public Claim(int claim_Id, string description, string status, DateTime date, Vehicle vehicle)
    {
        Claim_Id = claim_Id;
        Description = description;
        Status = status;
        Date = date;
        Vehicle = vehicle;
    }

    private Claim(int claim_Id, string description, string status, DateTime date)
    {
        Claim_Id = claim_Id;
        Description = description;
        Status = status;
        Date = date;
    }
}