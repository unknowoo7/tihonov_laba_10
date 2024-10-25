using Shared.Models;

namespace laba_10.Interfaces
{
  public interface IProject
  {
    public Project GetProjectData(int id);
    public List<Project> GetProjectDetails();
    public void DeleteProject(int id);
  }
}
