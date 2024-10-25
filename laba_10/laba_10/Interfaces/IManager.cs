using Shared.Models;

namespace laba_10.Interfaces
{
  public interface IManager
  {
    public Manager GetManagerData(int id);
    public List<Manager> GetManagerDetails();
  }
}
