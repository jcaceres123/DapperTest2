using DapperTest.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DapperTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DapperTestController : ControllerBase
    {
        private readonly IDapperTestRepository _dapperRepository;
        public DapperTestController(IOptions<ConnectionConfig> connectionConfig)
        {
            var connection = connectionConfig.Value;
            string connectionString = connection.DapperConnection;
            _dapperRepository = new DapperTestRepository(connectionString);
        }

        [HttpGet]
        public string Get()
        {
            return "Hello World";

        }
    }
}