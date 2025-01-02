using ASP.NETCoreRealTimeChatWithSignalR.Models;

namespace ASP.NETCoreRealTimeChatWithSignalR.Helpers
{
    public interface ICurrentUserService
    {
        string UserId { get; }
        Task<AppUser> GetUser();
    }
}
