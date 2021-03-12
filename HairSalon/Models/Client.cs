namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId {get; set;}
    public int StylistId {get; set;}
    public virtual Stylist Stylists {get; set;}
    public string Name {get; set; }
    public string HairColor {get; set;}
  }
}