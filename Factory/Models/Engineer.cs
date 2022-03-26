using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.MachineEngineerEntity = new HashSet<MachineEngineer>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }
    public string Details {get; set;}

    public virtual ICollection<MachineEngineer> MachineEngineerEntity { get;}
  }
}