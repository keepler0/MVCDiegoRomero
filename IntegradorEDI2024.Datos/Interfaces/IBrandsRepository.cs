using IntegradorEDI2024.Entidades;
using IntegradorEDI2024.Entidades.Enum;

namespace IntegradorEDI2024.Datos.Interfaces
{
    public interface IBrandsRepository
    {
        void Add(Brand brand);
        void Edit(Brand brand);
        void Delete(Brand brand);
        List<Brand> GetList();
        bool Exist(Brand brand);
        bool Related(Brand brand);
        Brand? GetBrandById(int BandId);
        Brand? GetBrandByName(string BrandName);
        void SaveChanges();
        int GetQuantity();
        List<Brand> GetPaginatedList(int page, int itemsPerPage,Orden orden);
    }
}
