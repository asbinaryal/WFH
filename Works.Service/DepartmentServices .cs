using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Data.Entities;
using Works.Models;
using Works.Repository.Infrastructure;

namespace Works.Service
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;
        public DepartmentServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async   Task Add(DepartmentViewModel dept)
        {
            // await _unitOfWork.Employee.Add(employee);
            //

            var data =  mapper.Map<DepartmentViewModel, Department>(dept);

            await  _unitOfWork.Department.Add(data);
            await _unitOfWork.CompleteAsync();


        }


        //public List<Department> GetAllAsyncs()
        //{
        //    var data = _unitOfWork.Department.GetAllAsyncs();
        //    //  var ret = mapper.Map<Department,Department>(data);
        //    var ret = data.Select(p => new Department()
        //    {

        //        Name = p.Name,
        //        CreatedOn = p.CreatedOn,
        //        UpdatedOn = p.UpdatedOn,
        //        CreatedBy = p.CreatedBy,
        //        UpdatedBy = p.UpdatedBy
        //    });
        //    return ret.ToList();
        //}
        public IEnumerable<DepartmentViewModel> GetAll()
        {
            var data = _unitOfWork.Department.GetAll();
            //  var ret = mapper.Map<Department,Department>(data);
            var ret = data.Select(p => new DepartmentViewModel()
            {

                Name = p.Name
              
            });
            return ret;
            
        }

        public async Task<Department> GetAsync(int id)
        {
            var data = await _unitOfWork.Department.GetAsync(id);
            return new Department()
            {
                Name = data.Name,
                CreatedOn = data.CreatedOn,
                UpdatedOn = data.UpdatedOn,
                CreatedBy = data.CreatedBy,
                UpdatedBy = data.UpdatedBy
            };
            
        }

      
        // await _unitOfWork.Employee.Add(employee);
        //_unitOfWork.CompleteAsync();
        //public async Task<List<Department>> GetAsync(int id)
        //{ 
        //    //  var ret = mapper.Map<List<Department>, List<Department>>(data); in get all
        //  //   ret.ToList(); 
        //    var data= _unitOfWork.Department.GetAsync(id);
        //   mapper.Map<Department, Department>(data);


        //}

    }
}

