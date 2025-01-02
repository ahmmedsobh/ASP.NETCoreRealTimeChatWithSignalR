using ASP.NETCoreRealTimeChatWithSignalR.ViewModels.MessagesViewModels;

namespace ASP.NETCoreRealTimeChatWithSignalR.Interface
{
    public interface IMessageService
    {
        Task<IEnumerable<MessagesUsersListViewModel>> GetUsers();
        Task<ChatViewModel> GetMessages(string selectedUserId);
    }
}
