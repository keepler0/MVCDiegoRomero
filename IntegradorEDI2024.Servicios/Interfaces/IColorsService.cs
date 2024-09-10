using IntegradorEDI2024.Entidades;
using IntegradorEDI2024.Entidades.Enum;

namespace IntegradorEDI2024.Servicios.Interfaces
{
    public interface IColorsService
    {
        List<Color> GetList();
        void Save(Color color);
        void Delete(Color color);
        bool Related(Color color);
        bool Exist(Color color);
        Color GetColorById(int colorId);
        int GetQuantity();
        List<Color> GetPaginatedList(int page, int itemsPerPage,Orden orden);
    }
}
