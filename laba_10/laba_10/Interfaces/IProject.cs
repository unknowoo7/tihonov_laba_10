using Shared.Models;

namespace laba_10.Interfaces
{
  public interface IProject
  {
    public Project GetProjectData(int id);
    public List<Project> GetProjectDetails();
    public Task<bool> DeleteProject(int id);
    public Task<bool> UpdateProject(Project project);
  }
}
