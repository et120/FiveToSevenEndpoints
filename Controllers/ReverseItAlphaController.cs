using FiveToSevenEndpoints.Services.ReverseItAlpha;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSevenEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItAlphaController : ControllerBase
{
    private readonly IReverseItAlpha _reverseItAlpha;

    public ReverseItAlphaController(IReverseItAlpha reverseItAlpha)
    {
        _reverseItAlpha = reverseItAlpha;
    }

    [HttpGet]
    [Route("ReverseIt/Entersequenceoflettersandornumbers{userInput}")]
    public string ReverseIt(string userInput)
    {
        return _reverseItAlpha.ReverseIt(userInput);
    }
}
