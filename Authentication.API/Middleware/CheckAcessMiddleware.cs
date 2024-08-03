using Authenticaion.Application.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Authentication.API.Middleware
{
    public class CheckAcessMiddleware
    {
        // Lưu middlewware tiếp theo trong Pipeline
        private readonly RequestDelegate _next;
        public CheckAcessMiddleware(RequestDelegate next) => _next = next;
        public async Task Invoke(HttpContext httpContext, IApplicationDbContext dbContext)
        {
            
            if (!httpContext.Request.Path.Value.Contains("userinfolog") && (dbContext is null))
            {
                var token = await httpContext.GetTokenAsync("access_token");

                var handler = new JwtSecurityTokenHandler();
                var jwtSecurityToken = handler.ReadJwtToken(token);
                var accountCode = jwtSecurityToken.Claims.First(claim => claim.Type == ClaimTypes.NameIdentifier).Value;

                var path = httpContext.Request.Path;
                var module = path.ToString().Split("/")[1];
                var action = path.ToString().Split("/")[2];
                var userInfoActions = await dbContext.UserInfoActions
                    .Where(x => x.ModuleCode == module).ToListAsync();
                List<UserInfoActionDto> actions = new List<UserInfoActionDto>();
                userInfoActions.ForEach(userInfoAction =>
                {
                    string actionMapping = string.Empty;
                    switch (action)
                    {
                        case "create":
                            actionMapping = "addNewItem";
                            break;
                        case "list":
                            actionMapping = "read";
                            break;
                        case "search":
                            actionMapping = "read";
                            break;
                        case "update":
                            actionMapping = "edit";
                            break;
                        case "delete":
                            actionMapping = "delete";
                            break;
                        case "print":
                            actionMapping = "print";
                            break;
                        case "download":
                            actionMapping = "download";
                            break;
                        default:
                            actionMapping = "all";
                            break;


                    }

                    actions.Add(new UserInfoActionDto(
                        userInfoAction.UserInfoId.Value, userInfoAction.Id.Value,
                        userInfoAction.ActionCode, userInfoAction.ModuleCode, actionMapping));

                });

                if (actions.Where(x => x.ActionCode == x.Name || x.Name == "all").FirstOrDefault() is not null)
                {
                    await _next(httpContext);
                }
                else
                {
                    httpContext.Response.StatusCode = StatusCodes.Status403Forbidden;
                }

            }
            else
            {
                await _next(httpContext);
            }        
        }
    }
}
