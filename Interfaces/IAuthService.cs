using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicAppointmentsApi.DTOS;
using ClinicAppointmentsApi.Models;

namespace ClinicAppointmentsApi.Interfaces
{
    // Interface for the authentication service that defines methods for user registration and login.
    public interface IAuthService
    {
        // Asynchronously registers a new user and returns the result of the operation.
        Task<AuthResult> RegisterAsync(UserRegisterDTO newUserDto);

        // Asynchronously logs in an user using their credentials and returns the result of the operation.
        Task<AuthResult> LoginAsync(LoginDTO request);
    }
}