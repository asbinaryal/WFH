using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Data.Entities;
using Works.Repository.Infrastructure;

namespace Works.Service
{
    public  class EmployeeServices : IEmployeeServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeServices(IUnitOfWork unitOfWork  ) 
        {
            _unitOfWork = unitOfWork;
        }
        //public async void Add(Employee employee)
        //{
            
        //}

        public async void Add(Employee emp)
        {
           // await _unitOfWork.Employee.Add(employee);
            //_unitOfWork.CompleteAsync();
           
            
            try
            { 
            var data = new Employee()
            {
                Id = emp.Id,
                FullName= emp.FullName,
                CreatedBy= emp.CreatedBy,
                CreatedOn= emp.CreatedOn,
                UpdatedBy= emp.UpdatedBy,
                UpdatedOn= emp.UpdatedOn,

            };
                  _unitOfWork.Employee.Add(data);
            }
            catch(Exception ex)
            {

            }


        }
    }
}
