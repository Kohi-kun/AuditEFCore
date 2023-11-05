namespace AuditEFCore.Helpers
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }
        public string GetCurrentUsername()
        {
            return httpContextAccessor.HttpContext.User.Identity.Name;
        }
    }
}
