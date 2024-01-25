using Microsoft.EntityFrameworkCore;
using net_project.Data;

namespace net_project.Models.Repositories
{
    public class ProfesorRepository : IProfesorRepository
    {
        private readonly TemplateContext _templateContext;
        public ProfesorRepository(TemplateContext templateContext)
        {
            _templateContext = templateContext;
        }
        async Task<IEnumerable<Profesor>> IProfesorRepository.GetAllProfesorsAsync()
        {
            return await _templateContext.Profesori.ToListAsync();
        }

        async Task<Profesor> IProfesorRepository.GetProfesorAsync(string nume)
        {
            return await _templateContext.Profesori.FirstOrDefaultAsync(p => p.Nume == nume);
        }

        async Task<Profesor> IProfesorRepository.PostAsync(Profesor profesor)
        {
            _templateContext.Add(profesor);
            await _templateContext.SaveChangesAsync();
            return profesor;
        }
    }
}
