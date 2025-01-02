using ASP.NETCoreRealTimeChatWithSignalR.Data;
using ASP.NETCoreRealTimeChatWithSignalR.Helpers;
using ASP.NETCoreRealTimeChatWithSignalR.Interface;
using ASP.NETCoreRealTimeChatWithSignalR.ViewModels.MessagesViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCoreRealTimeChatWithSignalR.Controllers
{
    public class MessagesController : Controller
    {
        private readonly IMessageService _messageService;

        public MessagesController(  IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _messageService.GetUsers();
            return View(users);
        }

        public async Task<IActionResult> Chat(string selectedUserId)
        {
            var chatViewModel = await _messageService.GetMessages(selectedUserId);
            return View(chatViewModel);
        }

    }
}
