using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicAppointmentsApi.DTOS;
using ClinicAppointmentsApi.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAppointmentsApi.Controllers.v1.AuthControllers
{
    /// <summary>
    /// Controller for authentication-related actions, including user registration and login.
    /// </summary>
    [ApiController]
    [AllowAnonymous]
    [Route("api/v1/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthController"/> class.
        /// </summary>
        /// <param name="authService">The authentication service used to handle authentication logic.</param>
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        /// <summary>
        /// Registers a new user in the system.
        /// </summary>
        /// <param name="newUserDto">The data transfer object containing the new user's information.</param>
        /// <returns>An IActionResult indicating the result of the registration process.</returns>
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterDTO newUserDto)
        {
            // Attempt to register the new User using the authentication service
            var result = await _authService.RegisterAsync(newUserDto);
            if (result.IsSuccess)
            {
                // Return a success response if registration was successful
                return Ok("User registered successfully");
            }

            // Return a bad request response with the error message if registration failed
            return BadRequest(result.Message);
        }

        /// <summary>
        /// Logs an user into the system.
        /// </summary>
        /// <param name="request">The data transfer object containing the login credentials.</param>
        /// <returns>An IActionResult indicating the result of the login process.</returns>
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO request)
        {
            // Attempt to log in the user using the authentication service
            var result = await _authService.LoginAsync(request);
            if (result.IsSuccess)
            {
                // Return a success response with the JWT token if login was successful
                return Ok(new
                {
                    message = "Please, save this token",
                    jwt = result.Token
                });
            }

            // Return an unauthorized response with the error message if login failed
            return Unauthorized(result.Message);
        }
    }
}