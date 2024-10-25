using laba_10.Interfaces;
using laba_10.Models;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace laba_10.Services
{
  public class ProjectService : IProject
  {
    readonly DatabaseContext _dbContext;

    public ProjectService(DatabaseContext dbContext)
    {
      _dbContext = dbContext;
    }

    public void DeleteProject(int id)
    {
      try
      {
        Project? project = _dbContext.Projects.Find(id);
        if (project == null)
        {
          throw new ArgumentNullException();
        }

        _dbContext.Projects.Remove(project);
        _dbContext.SaveChanges();
      }
      catch 
      {
        throw new NotImplementedException();
      }
    }

    public Project GetProjectData(int id)
    {
      try
      {
        Project? project = _dbContext.Projects.Find(id);
        if (project == null)
        {
          throw new ArgumentNullException();
        }

        return project;
      }
      catch
      {
        throw new NotImplementedException();
      }
    }

    public List<Project> GetProjectDetails()
    {
      try
      {
        return _dbContext.Projects.ToList();
      }
      catch
      {
        throw new NotImplementedException();
      }
    }

    public void UpdateProject(Project project)
    {
      try
      {
        _dbContext.Entry(project).State = EntityState.Modified;
        _dbContext.SaveChanges();
      }
      catch
      {
        throw new NotImplementedException();
      }
    }
  }
}
