using laba_10.Interfaces;
using laba_10.Models;
using Shared.Models;

namespace laba_10.Services
{
  public class ManagerService : IManager
  {
    readonly DatabaseContext _dbContext;

    public ManagerService(DatabaseContext dbContext)
    {
      _dbContext = dbContext;
    }

    public Manager GetManagerData(int id)
    {
      try
      {
        Manager? manager = _dbContext.Managers.Find(id);
        if (manager == null) 
        {
          throw new ArgumentNullException();
        }

        return manager;
      }
      catch
      {
        throw new NotImplementedException();
      }
    }

    public List<Manager> GetManagerDetails()
    {
      try
      {
        return _dbContext.Managers.ToList();
      }
      catch
      {
        throw new NotImplementedException();
      }
    }
  }
}
