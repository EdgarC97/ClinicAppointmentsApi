using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ClinicAppointmentsApi.Config;
using ClinicAppointmentsApi.Data;
using ClinicAppointmentsApi.DTOS;
using ClinicAppointmentsApi.Interfaces;
using ClinicAppointmentsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicAppointmentsApi.Services
{
    // Service class that implements authentication-related operations for users.
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context; // Database context for accessing user data.
        private readonly Utilities _utilities;   // Utility class for encryption and token generation.

        // Constructor that initializes the AuthService with the required dependencies.
        public AuthService(AppDbContext context, Utilities utilities)
        {
            _context = context;
            _utilities = utilities;
        }

        // Asynchronously registers a new user.
        public async Task<AuthResult> RegisterAsync(UserRegisterDTO newUserDto)
        {
            // Validate the incoming model data.
            var validationResults = ValidateModel(newUserDto);
            if (validationResults.Any())
            {
                return new AuthResult { IsSuccess = false, Message = string.Join(", ", validationResults) };
            }

            // Check if the email already exists in the database.
            if (await _context.Users.AnyAsync(u => u.Email == newUserDto.Email))
            {
                return new AuthResult { IsSuccess = false, Message = "Email already exists" };
            }

            // Create a new User object and encrypt the password.
            var newUser = new User
            {
                Username = newUserDto.UserName,
                Email = newUserDto.Email,
                Password = _utilities.EncryptSHA256(newUserDto.Password)
            };

            // Add the new user to the database and save changes.
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            // Return a successful registration result.
            return new AuthResult { IsSuccess = true };
        }

        // Asynchronously logs in an user.
        public async Task<AuthResult> LoginAsync(LoginDTO request)
        {
            // Validate the incoming model data.
            var validationResults = ValidateModel(request);
            if (validationResults.Any())
            {
                return new AuthResult { IsSuccess = false, Message = string.Join(", ", validationResults) };
            }

            // Retrieve the user based on the provided email.
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user == null)
            {
                return new AuthResult { IsSuccess = false, Message = "Invalid email" };
            }

            // Verify the provided password against the stored password.
            var passwordIsValid = user.Password == _utilities.EncryptSHA256(request.Password);
            if (!passwordIsValid)
            {
                return new AuthResult { IsSuccess = false, Message = "Invalid password" };
            }

            // Generate a JWT token for the logged-in user.
            var token = _utilities.GenerateJwtToken(user);
            return new AuthResult { IsSuccess = true, Token = token };
        }

        // Validates the properties of a given model using data annotations.
        private IEnumerable<string> ValidateModel<T>(T model)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(model);

            // Validate the object and collect any validation errors.
            Validator.TryValidateObject(model, validationContext, validationResults, true);
            return validationResults.Select(v => v.ErrorMessage);
        }
    }
}