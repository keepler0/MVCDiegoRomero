using IntegradorEDI2024.Datos;
using IntegradorEDI2024.Datos.Interfaces;
using IntegradorEDI2024.Entidades;
using IntegradorEDI2024.Entidades.Enum;
using IntegradorEDI2024.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorEDI2024.Servicios.Services
{
    public class SportsService : ISportsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISportsRepository _repository;

        public SportsService(IUnitOfWork unitOfWork, ISportsRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public void Delete(Sport sport)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Delete(sport);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool Exist(Sport sport)
        {
            try
            {
                return _repository.Exist(sport);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Sport> GetList()
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

        public List<Sport> GetPaginatedList(int page, int itemsPerPage,Orden orden)
        {
            try
            {
                return _repository.GetPaginatedList(page,itemsPerPage,orden);
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

        public Sport? GetSportById(int SportId)
        {
            try
            {
                return _repository.GetSportById(SportId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Related(Sport sport)
        {
            try
            {
                return _repository.Related(sport);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save(Sport sport)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (sport.SportId==0)
                {
                    _repository.Add(sport);
                }
                else
                {
                    _repository.Edit(sport);
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
