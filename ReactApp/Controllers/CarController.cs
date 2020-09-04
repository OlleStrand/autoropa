using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReactApp.Services;

namespace ReactApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private DatabaseService _databaseService;
        private DataAccessService DataAccessService { get; set; }

        public CarController(ILogger<CarController> logger, DatabaseService databaseService)
        {
            _logger = logger;
            _databaseService = databaseService;
            DataAccessService = new DataAccessService(databaseService);
        }
    }
}
