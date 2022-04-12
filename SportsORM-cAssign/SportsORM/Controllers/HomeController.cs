using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            // Dictionary<string, List<League>> sportLeagues = new Dictionary<string, List<League>>();

            // List<League> allLeagues = _context.Leagues
            //     .Where(l => l.Name.Contains("Women"))
            //     .ToList();
            // sportLeagues["1"] = allLeagues;
            // // ViewBag.Women_leagues = _context.Leagues
            // //     .Where(l => l.Sport.Contains("Baseball"))
            // //     .ToList();

            // // Console.WriteLine($"Text: {ViewBag.Women_leagues[0]}");
            // // Console.WriteLine($"Text: {FirstLeagues.Name}");
            // Console.WriteLine($"\n\n\n{sportLeagues["1"][0].Name}\n\n\n\n");
            

            return View();
        }
        // #1
        [HttpPost("level_1_1")]


        public IActionResult Level1_1()
        {
            List<League> womanLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Women"))
                .ToList();
            ListOfLeagues listOfwomanLeagues = new ListOfLeagues()
            {
                Leagues = womanLeagues
            };
            Console.WriteLine($"############### 1 ###############\n\n\n");
            
            return PartialView("querys_leagues", listOfwomanLeagues);
        }


        // #2
        [HttpPost("level_1_2")]
        public IActionResult Level1_2()
        {
            List<League> hockeyLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Hockey"))
                .ToList();
            ListOfLeagues listOfhockeyLeagues = new ListOfLeagues()
            {
                Leagues = hockeyLeagues
            };

            Console.WriteLine($"############### 2 ###############\n\n\n");
            return PartialView("querys_leagues", listOfhockeyLeagues);
        }

        // #3
        [HttpPost("level_1_3")]

        public IActionResult Level1_3()
        {
            List<League> noFootballLeagues = _context.Leagues
                .Where(l => !l.Sport.Contains("Football"))
                .ToList();
                
            ListOfLeagues listOfnoFootballLeagues = new ListOfLeagues()
            {
                Leagues = noFootballLeagues
            };

            Console.WriteLine($"############### 3 ###############\n\n\n");
            return PartialView("querys_leagues", listOfnoFootballLeagues);
        }


        // #4
        [HttpPost("level_1_4")]

        public IActionResult Level1_4()
        {
            List<League> ConferencesLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Conference"))
                .ToList();
                
            ListOfLeagues listOfConferencesLeagues = new ListOfLeagues()
            {
                Leagues = ConferencesLeagues
            };

            return PartialView("querys_leagues", listOfConferencesLeagues);
        }

        // #5
        [HttpPost("level_1_5")]

        public IActionResult Level1_5()
        {
            List<League> AtlanticLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Atlantic"))
                .ToList();
                
            ListOfLeagues listOfAtlanticLeagues = new ListOfLeagues()
            {
                Leagues = AtlanticLeagues
            };
            

            return PartialView("querys_leagues", listOfAtlanticLeagues);
        }

        // #6
        [HttpPost("level_1_6")]

        public IActionResult Level1_6()
        {
            List<Team> DallasTeams = _context.Teams
                .Where(l => l.Location.Contains("Dallas"))
                .ToList();
                
            ListOfTeams listOfDallasTeams = new ListOfTeams()
            {
                Teams = DallasTeams
            };
            

            return PartialView("querys_teams", listOfDallasTeams);
        }

        // #7
        [HttpPost("level_1_7")]

        public IActionResult Level1_7()
        {
            List<Team> RaptorsTeams = _context.Teams
                .Where(l => l.TeamName.Contains("Raptors"))
                .ToList();
                
            ListOfTeams listOfRaptorsTeams = new ListOfTeams()
            {
                Teams = RaptorsTeams
            };
            

            return PartialView("querys_teams", listOfRaptorsTeams);
        }

        // #8
        [HttpPost("level_1_8")]

        public IActionResult Level1_8()
        {
            List<Team> CityTeams = _context.Teams
                .Where(l => l.Location.Contains("City"))
                .ToList();
                
            ListOfTeams listOfCityTeams = new ListOfTeams()
            {
                Teams = CityTeams
            };
            

            return PartialView("querys_teams", listOfCityTeams);
        }

        // #9
        [HttpPost("level_1_9")]

        public IActionResult Level1_9()
        {
            List<Team> tTeams = _context.Teams
                .Where(l => l.TeamName.Contains("T"))
                .ToList();
                
            ListOfTeams listOftTeams = new ListOfTeams()
            {
                Teams = tTeams
            };
            
            Console.WriteLine($"Text: {listOftTeams.Teams[0].TeamName}");
            

            return PartialView("querys_teams", listOftTeams);
        }

        // #10
        [HttpPost("level_1_10")]

        public IActionResult Level1_10()
        {
            List<Team> AlphaOrderTeams = _context.Teams
                .OrderBy(l => l.Location)
                .ToList();
                
            ListOfTeams listOfAlphaOrderTeams = new ListOfTeams()
            {
                Teams = AlphaOrderTeams
            };
            
            Console.WriteLine($"Text: {listOfAlphaOrderTeams.Teams[0].TeamName}");
            

            return PartialView("querys_teams", listOfAlphaOrderTeams);
        }

        // #11
        [HttpPost("level_1_11")]

        public IActionResult Level1_11()
        {
            List<Team> TeamOrderDescTeams = _context.Teams
                .OrderByDescending(l => l.TeamName)
                .ToList();
                
            ListOfTeams listOfTeamOrderDescTeams = new ListOfTeams()
            {
                Teams = TeamOrderDescTeams
            };
            

            return PartialView("querys_teams", listOfTeamOrderDescTeams);
        }

        // #12
        [HttpPost("level_1_12")]

        public IActionResult Level1_12()
        {
            List<Player> CooperPlayers = _context.Players
                .Where(l => l.LastName.Contains("Cooper"))
                .ToList();
                
            ListOfPlayers listOfCooperPlayers = new ListOfPlayers()
            {
                Players = CooperPlayers
            };
            
            // Console.WriteLine($"Text: {CooperPlayers.Teams[0].TeamName}");
            

            return PartialView("querys_players", listOfCooperPlayers);
        }

        // #13
        [HttpPost("level_1_13")]

        public IActionResult Level1_13()
        {
            List<Player> JoshuaPlayers = _context.Players
                .Where(l => l.FirstName.Contains("Joshua"))
                .ToList();
                
            ListOfPlayers listOfJoshuaPlayers = new ListOfPlayers()
            {
                Players = JoshuaPlayers
            };
            

            return PartialView("querys_players", listOfJoshuaPlayers);
        }

        // #14
        [HttpPost("level_1_14")]

        public IActionResult Level1_14()
        {
            List<Player> NoJoshuaPlayers = _context.Players
                .Where(l => l.LastName.Contains("Cooper") && !l.FirstName.Contains("Joshua"))
                .ToList();
                
            ListOfPlayers listOfNoJoshuaPlayers = new ListOfPlayers()
            {
                Players = NoJoshuaPlayers
            };
            

            return PartialView("querys_players", listOfNoJoshuaPlayers);
        }

        // #15
        [HttpPost("level_1_15")]

        public IActionResult Level1_15()
        {
            List<Player> AlexOrWattPlayers = _context.Players
                .Where(l => l.FirstName.Contains("Alexander") || l.FirstName.Contains("Wyatt"))
                .ToList();
                
            ListOfPlayers listOfAlexOrWattPlayers = new ListOfPlayers()
            {
                Players = AlexOrWattPlayers
            };
            

            return PartialView("querys_players", listOfAlexOrWattPlayers);
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}