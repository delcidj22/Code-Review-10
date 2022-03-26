using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.MachineEngineerEntity = new HashSet<MachineEngineer>();
    }

    public int MachineId { get; set; }
    public string Name { get; set; }
    public string Details {get; set;}
    public virtual ICollection<MachineEngineer> MachineEngineerEntity{ get; set; }
  }
}