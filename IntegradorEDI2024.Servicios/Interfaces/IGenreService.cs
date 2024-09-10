using IntegradorEDI2024.Entidades;
using IntegradorEDI2024.Entidades.Enum;

namespace IntegradorEDI2024.Servicios.Interfaces
{
    public interface IGenreService
    {
        void Save(Genre genre);
        void Delete(Genre genre);
        List<Genre> GetList();
        bool Exist(Genre genre);
        bool Related(Genre genre);
        Genre? GetGenreById(int GenreId);
        Genre? GetGenreByName(string GenreName);
        List<Genre> GetPaginatedList(int page, int itemsPerPage,Orden orden);
        int GetQuantity();
    }
}
