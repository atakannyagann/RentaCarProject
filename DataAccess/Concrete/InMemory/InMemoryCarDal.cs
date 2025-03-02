﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=100,Description="used vehicle" },
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2007,DailyPrice=200,Description="unused vehicle" },
                new Car{Id=3,BrandId=3,ColorId=2,ModelYear=2008,DailyPrice=300,Description="used vehicle" }

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

       

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList(); 
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToBeUpdated = _cars.FirstOrDefault(c => c.Id == car.Id);
            carToBeUpdated.Id = car.Id;
            carToBeUpdated.BrandId = car.BrandId;
            carToBeUpdated.ColorId = car.ColorId;
            carToBeUpdated.ModelYear = car.ModelYear;
            carToBeUpdated.DailyPrice = car.DailyPrice;
            carToBeUpdated.Description = car.Description;
        }
    }
}
