using IntegradorEDI2024.Entidades;
using IntegradorEDI2024.Entidades.Enum;

namespace IntegradorEDI2024.Servicios.Interfaces
{
    public interface ISportsService
    {
        List<Sport> GetList();
        void Save(Sport sport);
        void Delete(Sport sport);
        bool Exist(Sport sport);
        bool Related(Sport sport);
        Sport? GetSportById(int SportId);
        int GetQuantity();
        List<Sport> GetPaginatedList(int page, int itemsPerPage,Orden orden);
    }
}
