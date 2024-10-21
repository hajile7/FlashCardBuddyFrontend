using FlashCardBuddyFrontend.Models;
using FlashCardBuddyFrontend.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlashCardBuddyFrontend.Namespace
{
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }
        
        public async Task<IActionResult> Users()
        {
            List<UserDTO> users = await _userService.GetAllUserAsync();
            return View(users);
        }

        public async Task<IActionResult> Flashcard()
        {
            List<UserDTO> flashcards = await _userService.GetAllUserAsync();
            return View(flashcards);
        }

    }
}
