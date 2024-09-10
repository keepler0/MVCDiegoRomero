using IntegradorEDI2024.Entidades;
using IntegradorEDI2024.Entidades.Enum;

namespace IntegradorEDI2024.Datos.Interfaces
{
    public interface IGenresRepository
    {
        List<Genre> GetList();
        void Add(Genre genre);
        void Update(Genre genre);
        void Delete(Genre genre);
        bool Exist(Genre genre);
        bool Related(Genre genre);
        Genre? GetGenreById(int GenreId);
        Genre? GetGenreByName(string GenreName);
        int GetQuantity();
        List<Genre> GetPaginatedList(int page, int itemsPerPage,Orden orden);
    }
}
