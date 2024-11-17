using ArcadifyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArcadifyWeb.Controllers
{
    public class PagesController : Controller
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        GameModel usuarioM = new GameModel();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Inicio()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> VideoJuegos()
        {
            // Fetch the game data from the external API
            var games = await GetGamesAsync();

            // Pass the games data to the view
            return View(games);
        }

        private async Task<List<GameModel>> GetGamesAsync()
        {
            var response = await _httpClient.GetAsync("https://www.freetogame.com/api/games");
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();

            // Add null coalescing for safety and case-insensitive deserialization
            var games = System.Text.Json.JsonSerializer.Deserialize<List<GameModel>>(jsonString,
                new System.Text.Json.JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true // Handles case-insensitive JSON property names
                });

            return games ?? new List<GameModel>(); // Ensure it never returns null
        }

        public IActionResult Contactenos()
        {
            return View();
        }

        public IActionResult Perfil()
        {
            return View();
        }
    }
}
