using IntegradorEDI2024.Datos.Interfaces;
using IntegradorEDI2024.Entidades;
using IntegradorEDI2024.Entidades.Enum;
using Microsoft.EntityFrameworkCore;

namespace IntegradorEDI2024.Datos.Repositories
{
    public class SportsRepository : ISportsRepository
    {
        private readonly MiDbContext _context;

        public SportsRepository(MiDbContext context)
        {
            _context = context;
        }

        public void Add(Sport sport)
        {
            _context.Sports.Add(sport);
        }

        public void Delete(Sport sport)
        {
            _context.Sports.Remove(sport);
        }

        public void Edit(Sport sport)
        {
            _context.Sports.Update(sport);
        }

        public bool Exist(Sport sport)
        {
            if (sport.SportId == 0)
            {
                return _context.Sports.Any(sp => sp.SportName == sport.SportName);
            }
            return _context.Sports.Any(sp => sp.SportName == sport.SportName && sp.SportId != sport.SportId);
        }

        public List<Sport> GetList()
        {
            return _context.Sports.ToList();
        }

        public List<Sport> GetPaginatedList(int page, int itemsPerPage,Orden orden)
        {
            var list = new List<Sport>();
            switch (orden)
            {
                case Orden.AZ:
                    list = _context.Sports
                                   .AsNoTracking()
                                   .OrderBy(s => s.SportName)
                                   .Skip(page * itemsPerPage)
                                   .Take(itemsPerPage)
                                   .ToList();
                    break;
                case Orden.ZA:
                    list = _context.Sports
                                   .AsNoTracking()
                                   .OrderByDescending(s => s.SportName)
                                   .Skip(page * itemsPerPage)
                                   .Take(itemsPerPage)
                                   .ToList();
                    break;
            }
            return list;
        }

        public int GetQuantity()
        {
            return _context.Sports.Count();
        }

        public Sport? GetSportById(int sportId)
        {
            return _context.Sports.SingleOrDefault(sp => sp.SportId == sportId);
        }

        public bool Related(Sport sport)
        {
            return _context.Shoes.Any(sh => sh.SportId == sport.SportId);
        }
    }
}
