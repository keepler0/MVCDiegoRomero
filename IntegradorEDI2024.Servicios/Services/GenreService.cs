using IntegradorEDI2024.Datos;
using IntegradorEDI2024.Datos.Interfaces;
using IntegradorEDI2024.Entidades;
using IntegradorEDI2024.Entidades.Enum;
using IntegradorEDI2024.Servicios.Interfaces;

namespace IntegradorEDI2024.Servicios.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenresRepository _repository;
        private IUnitOfWork _unitOfWork;

        public GenreService(IGenresRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Delete(Genre genre)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Delete(genre);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool Exist(Genre genre)
        {
            try
            {
                return _repository.Exist(genre);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Genre? GetGenreById(int GenreId)
        {
            try
            {
                return _repository.GetGenreById(GenreId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Genre? GetGenreByName(string GenreName)
        {
            try
            {
                return _repository.GetGenreByName(GenreName);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Genre> GetList()
        {
            try
            {
                return _repository.GetList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Genre> GetPaginatedList(int page, int itemsPerPage,Orden orden)
        {
            try
            {
                return _repository.GetPaginatedList(page, itemsPerPage,orden);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetQuantity()
        {
            try
            {
                return _repository.GetQuantity();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Related(Genre genre)
        {
            try
            {
                return _repository.Related(genre);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save(Genre genre)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (genre.GenreId==0)
                {
                    _repository.Add(genre);
                }
                else
                {
                    _repository.Update(genre);
                }
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }
    }
}
