using IntegradorEDI2024.Entidades;
using IntegradorEDI2024.Entidades.Enum;

namespace IntegradorEDI2024.Servicios.Interfaces
{
    public interface IBrandsService
    {
        void Save(Brand brand);
        void Delete(Brand brand);
        List<Brand> GetList();
        bool Exist(Brand brand);
        bool Related(Brand brand);
        Brand? GetBrandById(int BandId);
        Brand? GetBrandByName(string BrandName);
        int GetQuantity();
        List<Brand> GetPaginatedList(int page,int itemsPerPage,Orden orden);
    }
}
