using IntegradorEDI2024.Entidades;
using IntegradorEDI2024.Entidades.Enum;

namespace IntegradorEDI2024.Datos.Interfaces
{
    public interface ISportsRepository
    {
        List<Sport> GetList();
        void Add(Sport sport);
        void Edit(Sport sport);
        void Delete(Sport sport);
        bool Exist(Sport sport);
        bool Related(Sport sport);
        Sport? GetSportById(int sportId);
        int GetQuantity();
        List<Sport> GetPaginatedList(int page, int itemsPerPage,Orden orden);
    }
}
