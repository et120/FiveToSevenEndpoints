using FiveToSevenEndpoints.Services.ReverseItNum;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSevenEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItNumController : ControllerBase
{
    private readonly IReverseNumService _reverseNumService;

    public ReverseItNumController(IReverseNumService reverseNumService)
    {
        _reverseNumService = reverseNumService;
    }

    [HttpGet]
    [Route("ReverseItNum/Enteranumberonly{userNum}")]
    public string ReverseItNumOnly(string userNum)
    {
        return _reverseNumService.ReverseItNumOnly(userNum);
    }
}
