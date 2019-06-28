using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CS321_W5D1_ExerciseLogAPI.ApiModels;
using CS321_W5D1_ExerciseLogAPI.Core.Models;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CS321_W5D1_ExerciseLogAPI.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {

        public AuthController()
        {
        }

        // TODO: POST api/auth/register

        // TODO: POST api/auth/login

    }
}
