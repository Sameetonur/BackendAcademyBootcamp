using System.Data.SqlClient;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project08_ProtfolioApp.Areas.Admin.Models;
using Project08_ProtfolioApp.Models;

namespace Project08_ProtfolioApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController : Controller
    {
        // GET: ProjectController
        private readonly string _folderName;
        public ProjectController(IWebHostEnvironment webHostEnvironment)
        {
            _folderName=webHostEnvironment.WebRootPath + "/ui/img/projects";
        }

        public async Task<ActionResult> Index()

        {
            var connectionString = "Server=localhost,1441;Database=PortfolioDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
            var connection = new SqlConnection(connectionString);

            var queryProjects = "select * from Projects";
            var projects = await connection.QueryAsync<Project>(queryProjects);

            return View(projects);
        }

        [HttpGet]
        public async Task<ActionResult> Create()
        {
            AddProjectViewModel model = new AddProjectViewModel()
            {
                CategoryList = await GetCategoryList()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Create(AddProjectViewModel model)
        {
            if (ModelState.IsValid)
            {
                //burada öncelikle resim yükleme işlemi yapılır. İleride göreceğiz
                //Şimdilik yüklendiğini varsayarak ImageUrl'e varsayılan bir resmin url bilgisini atayacağırz..

                //GEÇİCİ OLARAK RESİM YÜKLEME OPERASYONU
                if (model.Image == null)
                {
                    model.CategoryList = await GetCategoryList();
                    return View(model);
                }

                if (model.Image.Length == 0)
                {
                    model.CategoryList = await GetCategoryList();
                    return View(model);
                }

                string[] correctExtensions = [".png", ".jpg", ",jpeg"];
                string fileExtension = Path.GetExtension(model.Image.FileName).ToLower();
                if (!correctExtensions.Contains(fileExtension))
                {
                    model.CategoryList = await GetCategoryList();
                    return View(model);
                }
                string imageFileName = $"{Guid.NewGuid()}{fileExtension}";
                string target=_folderName+"/"+ imageFileName;
                    await using(var stream = new FileStream(target, FileMode.Create))
                    {
                        await stream.CopyToAsync(stream);
                    }

                model.ImageUrl = "http://localhost:5100/ui/img/projects/"+ imageFileName;
                var query = @"
                    INSERT INTO Projects(Name,Description,CategoryId,GithubUrl,IsActive,ImageUrl)
                    VALUES(@Name,@Description,@CategoryId,@GithubUrl,@IsActive,@ImageUrl)
                ";
                var connectionString = "Server=localhost,1441;Database=PortfolioDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
                var connection = new SqlConnection(connectionString);
                await connection.ExecuteAsync(query, model);

                return RedirectToAction("Index");
            }
            model.CategoryList = await GetCategoryList();
            return View(model);

        }

        [NonAction]
        private async Task<List<SelectListItem>> GetCategoryList()
        {
            var connectionString = "Server=localhost,1441;Database=PortfolioDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
            var connection = new SqlConnection(connectionString);

            var queryCategories = "select * from Categories";
            var categories = await connection.QueryAsync<Category>(queryCategories);

            List<SelectListItem> result = [];

            foreach (var Category in categories)
            {
                result.Add(new SelectListItem
                {

                    Text = Category.Name,
                    Value = Category.Id.ToString()
                });
            }
            return result;

        }

    }
}
