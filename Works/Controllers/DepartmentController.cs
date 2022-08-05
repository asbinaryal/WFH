using Microsoft.AspNetCore.Mvc;
using Works.Controllers.Base;
using Works.Data.Entities;
using Works.Models;

namespace Works.Controllers
{
    public class DepartmentController : BaseController
    {
        private readonly ILogger<DepartmentController> logger;
        private readonly IConfiguration configure;
        private readonly HttpClient httpClient;

        public DepartmentController(ILogger<DepartmentController> logger, IConfiguration configure, HttpClient httpClient)//http client send request to web api
            : base(configure, httpClient)
        {
            this.logger = logger;
            this.configure = configure;
            this.httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            //var a = await GetAsync(Helper.DepartmentIndex,   /*stringqueryhere*/);
            //call api controller here
            //var q = new Department()
            //{
            //   Name=q.Name,         
            //};
            var a = await GetAsync<IEnumerable<DepartmentViewModel>>(Helper.DepartmentGetAll);
            DepartmentViewModel model = new DepartmentViewModel();
            model.Department = a;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DepartmentViewModel model)
        {

            var create = await PostAsync<DepartmentViewModel>(model , Helper.DepartmentEndPoint);

            return RedirectToAction("Index");
        }
        //public async Task<IActionResult> Indexes(Department department)
        //{

        //    var data = await GetAsync<Department>(Helper.DepartmentIndex,"query string here" );
        //    return View();
        //}

        //public async Task<IActionResult> AddDept(DepartmentViewModel department)
        //{

        //    var message = await PostAsync(department, Helper.DepartmentEndPoint);
        //    return View();

        //}
    }
}
