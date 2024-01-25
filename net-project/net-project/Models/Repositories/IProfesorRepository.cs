namespace net_project.Models.Repositories
{
    public interface IProfesorRepository
    {
        Task<IEnumerable<Profesor>> GetAllProfesorsAsync();
        Task<Profesor> GetProfesorAsync(string nume);
        Task<Profesor> PostAsync(Profesor profesor);
    }
}
