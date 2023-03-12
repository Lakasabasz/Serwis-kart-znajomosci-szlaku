using System.Globalization;
using ApiProtocol;
using ApiProtocol.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers;

[ApiController, Route("station")]
public class StationsController : Controller
{
    private ILogger<StationsController> _logger;
    private readonly RailroadMapContext _db;

    public StationsController(ILogger<StationsController> logger, RailroadMapContext db)
    {
        _logger = logger;
        _db = db;
    }
    
    [HttpGet]
    public async Task<AutocompletionListResponse> Index([FromQuery] string q)
    {
        var query = await _db.RailroadPoints
            .Where(x => x.Postname.ToLower().StartsWith(q.ToLower()))
            .Include(x => x.IdcategoryNavigation)
            .Take(20)
            .ToArrayAsync();
        AutocompletionListResponse resp = new()
        {
            Posts = query.Select(x => new Post()
            {
                PostId = x.Postid,
                PostName = x.Postname,
                CategoryName = x.IdcategoryNavigation.Fullname,
                CategoryShortcut = x.IdcategoryNavigation.Discriminant
            }).ToArray()
        };
        return resp;
    }
}