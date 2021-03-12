using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public int ClientId {get; set;}
    public string Name {get; set;}
    public string Expertise {get; set;}
    public virtual ICollection<Client> Clients {get; set;}
  }
}