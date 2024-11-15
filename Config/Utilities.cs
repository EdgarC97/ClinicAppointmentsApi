using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ClinicAppointmentsApi.Models;
using Microsoft.IdentityModel.Tokens;

namespace ClinicAppointmentsApi.Config
{
    public class Utilities
    {
        /// <summary>
        /// Encrypts a string using the SHA256 algorithm.
        /// </summary>
        /// <param name="input">The string to be encrypted.</param>
        /// <returns>The hexadecimal representation of the encrypted string.</returns>
        public string EncryptSHA256(string input)
        {
            // Create an instance of the SHA256 algorithm
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Compute the hash of the input string
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Use a StringBuilder to construct the hexadecimal representation
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    // Append each byte as a two-digit hexadecimal string
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        /// <summary>
        /// Generates a JWT token for a given user.
        /// </summary>
        /// <param name="user">The user for whom the token is generated.</param>
        /// <returns>A signed JWT token as a string.</returns>
        public string GenerateJwtToken(User user)
        {
            // Define the claims to be included in the token
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
        };

            // Retrieve JWT configuration values from environment variables
            var jwtKey = Environment.GetEnvironmentVariable("JWT_KEY");
            var jwtIssuer = Environment.GetEnvironmentVariable("JWT_ISSUER");
            var jwtAudience = Environment.GetEnvironmentVariable("JWT_AUDIENCE");
            var jwtExpiresIn = Environment.GetEnvironmentVariable("JWT_EXPIRES_IN");

            // Validate that necessary environment variables are set
            if (string.IsNullOrEmpty(jwtKey) || string.IsNullOrEmpty(jwtIssuer) || string.IsNullOrEmpty(jwtAudience))
            {
                throw new InvalidOperationException("JWT configuration values are missing.");
            }

            // Create a symmetric security key using the JWT key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Create the JWT token
            var token = new JwtSecurityToken(
                issuer: jwtIssuer,
                audience: jwtAudience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(jwtExpiresIn)),
                signingCredentials: credentials
            );

            // Return the serialized token as a string
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}