using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
  public class Manager
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Project> Projects { get; set; }
  }
}
