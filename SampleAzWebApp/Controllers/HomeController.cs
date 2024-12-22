using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SampleAzWebApp.Models;
using System.Data.SqlClient;

namespace SampleAzWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public List<Users> UsersList = new List<Users>();
    private IConfiguration _configuration;
    public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        string connectionString = _configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING")!;
        var sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();

        var sqlcommand = new SqlCommand(
            "SELECT UserId, UserName, Designation, Location FROM Users;",sqlConnection);
        using (SqlDataReader sqlDatareader = sqlcommand.ExecuteReader())
        {
            while (sqlDatareader.Read())
            {
                UsersList.Add(new Users() {UserId= Int32.Parse(sqlDatareader["UserId"].ToString()),
                    UserName=sqlDatareader["UserName"].ToString(),
                    Designation=(sqlDatareader["Designation"].ToString()),
                    Location=(sqlDatareader["Location"].ToString())
                });
            }
        }
        var viewModel = new UsersViewModel { Users = UsersList };
        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}