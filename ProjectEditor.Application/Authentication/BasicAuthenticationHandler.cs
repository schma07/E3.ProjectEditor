using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ProjectEditor.Common.Services;
using ProjectEditor.Core.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace ProjectEditor.Application.Authentication
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    { 
        private readonly IUserService userService;

    public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options,
                                      ILoggerFactory logger,
                                      UrlEncoder encoder,
                                      ISystemClock clock,
                                      IUserService userService) : base(options, logger, encoder, clock)
    {
        this.userService = userService;
    }

    // HTTP basic Authentication        
    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        if (!Request.Headers.ContainsKey("Authorization"))
        {
            Response.Headers.Add("WWW-Authenticate", "Basic realm\"\"");
            return AuthenticateResult.Fail("Mising Authorization Header!");
        }

        User user;

        try
        {
            var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
            var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
            var credentials = Encoding.UTF8.GetString(credentialBytes).Split(new[] { ':' }, 2); // ByteArrray wird in Unicode String konvertiert
            var username = credentials[0];
            var password = credentials[1];

            user = await this.userService.Authenticate(username, password);

        }
        catch
        {
            return AuthenticateResult.Fail("Invalid Authorization Header!");
        }

        if (user == null)
        {
            return AuthenticateResult.Fail("Invalid Username or Password!"); // Jetzt könnte z.B. die IP aus dem Header in eine Liste gespeichert werden, um z.B. den Login bei der 3. Falscheingabe zu blockieren oder dem Besitzer des Passworts eine Mail zu senden.
        }

        var claims = new[]
        {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName)
            };

        var identity = new ClaimsIdentity(claims, Scheme.Name);
        var principal = new ClaimsPrincipal(identity);
        var ticket = new AuthenticationTicket(principal, Scheme.Name);

        return AuthenticateResult.Success(ticket);

    }
}
}
