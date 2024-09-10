using IntegradorEDI2024.Entidades;
using IntegradorEDI2024.Entidades.Enum;

namespace IntegradorEDI2024.Datos.Interfaces
{
    public interface IColorsRepository
    {
        List<Color> GetList();
        void Add(Color color);
        void Delete(Color color);
        void Edit(Color color);
        bool Related(Color color);
        bool Exist(Color color);
        Color GetColorById(int colorId);
        int GetQuantity();
        List<Color> GetPaginatedList(int page, int itemsPerPage,Orden orden);
    }
}
