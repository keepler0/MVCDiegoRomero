﻿using IntegradorEDI2024.Datos;
using IntegradorEDI2024.Datos.Interfaces;
using IntegradorEDI2024.Entidades;
using IntegradorEDI2024.Entidades.Enum;
using IntegradorEDI2024.Servicios.Interfaces;

namespace IntegradorEDI2024.Servicios.Services
{
    public class BrandsService : IBrandsService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IBrandsRepository _repository;
        public BrandsService(IBrandsRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public void Delete(Brand brand)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Delete(brand);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool Exist(Brand brand)
        {
            try
            {
                return _repository.Exist(brand);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Brand? GetBrandById(int BrandId)
        {
            try
            {
                return _repository.GetBrandById(BrandId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Brand? GetBrandByName(string BrandName)
        {
            try
            {
                return _repository.GetBrandByName(BrandName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Brand> GetList()
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

        public bool Related(Brand brand)
        {
            try
            {
                return _repository.Related(brand);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Save(Brand brand)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (brand.BrandId==0)
                {
                    _repository.Add(brand);
                }
                else
                {
                    _repository.Edit(brand);
                }
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
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

        public List<Brand> GetPaginatedList(int page, int itemsPerPage,Orden orden)
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
    }
}