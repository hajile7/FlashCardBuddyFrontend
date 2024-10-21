using FlashCardBuddyFrontend.Models;

namespace FlashCardBuddyFrontend.Services {
    public class UserService {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UserDTO>> GetAllUserAsync() 
        {
            var response = await _httpClient.GetFromJsonAsync<List<UserDTO>>($"/api/User");
            return response ?? new List<UserDTO>();
        }

        public async Task<List<Flashcard>> GetAllFlashcardsAsync() 
        {
            var response = await _httpClient.GetFromJsonAsync<List<Flashcard>>($"/api/FlashCard/All?userId=1");
            return response ?? new List<Flashcard>();
        }
    }
}