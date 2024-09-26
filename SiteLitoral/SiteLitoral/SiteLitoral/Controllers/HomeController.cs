using Microsoft.AspNetCore.Mvc;
using SiteLitoral.Models;
using System.Diagnostics;

namespace SiteLitoral.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Hotel hotelCata = new Hotel();
            hotelCata.nome = "Catalina Hotel";
            hotelCata.cidade = "Ubatuba";
            hotelCata.pathImage = "~/img/Catalina.jpg";
            ViewBag.nomeCata = hotelCata.nome;
            ViewBag.cidadeCata = hotelCata.cidade;
            ViewBag.pathCata = hotelCata.pathImage;

            Hotel hotelDpny = new Hotel();
            hotelDpny.nome = "DPNY Beach Hotel & SPA";
            hotelDpny.cidade = "Ilhabela";
            hotelDpny.pathImage = "~/img/DPNY.jpg";
            ViewBag.nomeD = hotelDpny.nome;
            ViewBag.cidadeD = hotelDpny.cidade;
            ViewBag.pathD = hotelDpny.pathImage;

            Hotel hotelMaui = new Hotel();
            hotelMaui.nome = "Maui Maresias";
            hotelMaui.cidade = "São Sebastião";
            hotelMaui.pathImage = "~/img/Maui.jpg";
            ViewBag.nomeM = hotelMaui.nome;
            ViewBag.cidadeM = hotelMaui.cidade;
            ViewBag.pathM = hotelMaui.pathImage;

            Hotel hotelSirena = new Hotel();
            hotelSirena.nome = "Wyndham Ilhabela Casa di Sirena";
            hotelSirena.cidade = "Ilhabela";
            hotelSirena.pathImage = "~/img/wyndham.jpg";
            ViewBag.nomeW = hotelSirena.nome;
            ViewBag.cidadeW = hotelSirena.cidade;
            ViewBag.pathW = hotelSirena.pathImage;

            Restaurante restBen = new Restaurante();
            restBen.nome = "Ben's Bar & Comidaria";
            restBen.cidade = "Ilhabela";
            restBen.pathImage = "~/img/Ben's Bar &  Comidaria.jpg";
            ViewBag.nomeBen = restBen.nome;
            ViewBag.cidadeBen = restBen.cidade;
            ViewBag.pathBen = restBen.pathImage;

            Restaurante restA = new Restaurante();
            restA.nome = "Alcide's Restaurante";
            restA.cidade = "Guarujá";
            restA.pathImage = "~/img/Alcide's Restaurante.jpg";
            ViewBag.nomeA = restA.nome;
            ViewBag.cidadeA = restA.cidade;
            ViewBag.pathA = restA.pathImage;

            Restaurante restC = new Restaurante();
            restC.nome = "Costazul Seafood";
            restC.cidade = "Santos";
            restC.pathImage = "~/img/COSTAZUL.jpg";
            ViewBag.nomeC = restC.nome;
            ViewBag.cidadeC = restC.cidade;
            ViewBag.pathC = restC.pathImage;

            Restaurante restJ = new Restaurante();
            restJ.nome = "Jirêh Bar e Cozinha Prática.jpg";
            restJ.cidade = "São Pedro";
            restJ.pathImage = "~/img/Jirêh Bar e Cozinha Prática.jpg";
            ViewBag.nomeJ = restJ.nome;
            ViewBag.cidadeJ = restJ.cidade;
            ViewBag.pathJ = restJ.pathImage;

            OQueFazer fazPele = new OQueFazer();
            fazPele.nome = "Tour Privativo do Pelé: o Rei do Futebol";
            fazPele.cidade = "Santos";
            fazPele.pathImage = "~/img/RoteiroPelé.jpg";
            ViewBag.nomeP = fazPele.nome;
            ViewBag.cidadeP = fazPele.cidade;
            ViewBag.pathP = fazPele.pathImage;

            OQueFazer fazMergulho = new OQueFazer();
            fazMergulho.nome = "Batismo de Mergulho";
            fazMergulho.cidade = "Ilhabela";
            fazMergulho.pathImage = "~/img/MergulhoIlhaBela.png";
            ViewBag.nomeB = fazMergulho.nome;
            ViewBag.cidadeB = fazMergulho.cidade;
            ViewBag.pathB = fazMergulho.pathImage;

            OQueFazer fazPauba = new OQueFazer();
            fazPauba.nome = "Rapel em Paúba";
            fazPauba.cidade = "São Sebastião";
            fazPauba.pathImage = "~/img/RapelPauba.png";
            ViewBag.nomeR = fazPauba.nome;
            ViewBag.cidadeR = fazPauba.cidade;
            ViewBag.pathR = fazPauba.pathImage;

            OQueFazer fazTour = new OQueFazer();
            fazTour.nome = "O Melhor de Santos - 6 horas - City Tour Privado";
            fazTour.cidade = "Santos";
            fazTour.pathImage = "~/img/CityTour.jpg";
            ViewBag.nomeT = fazTour.nome;
            ViewBag.cidadeT = fazTour.cidade;
            ViewBag.pathT = fazTour.pathImage;

            return View();
        }
        public IActionResult Index1()
        {
            return View();
        }
        public IActionResult Restaurantes()
        {
            Restaurante restBen = new Restaurante();
            restBen.nome = "Ben's Bar & Comidaria";
            restBen.cidade = "Ilhabela";
            restBen.pathImage = "~/img/Ben's Bar &  Comidaria.jpg";
            ViewBag.nomeBen = restBen.nome;
            ViewBag.cidadeBen = restBen.cidade;
            ViewBag.pathBen = restBen.pathImage;

            Restaurante restA = new Restaurante();
            restA.nome = "Alcide's Restaurante";
            restA.cidade = "Guarujá";
            restA.pathImage = "~/img/Alcide's Restaurante.jpg";
            ViewBag.nomeA = restA.nome;
            ViewBag.cidadeA = restA.cidade;
            ViewBag.pathA = restA.pathImage;

            Restaurante restC = new Restaurante();
            restC.nome = "Costazul Seafood";
            restC.cidade = "Santos";
            restC.pathImage = "~/img/COSTAZUL.jpg";
            ViewBag.nomeC = restC.nome;
            ViewBag.cidadeC = restC.cidade;
            ViewBag.pathC = restC.pathImage;

            Restaurante restJ = new Restaurante();
            restJ.nome = "Jirêh Bar e Cozinha Prática.jpg";
            restJ.cidade = "São Pedro";
            restJ.pathImage = "~/img/Jirêh Bar e Cozinha Prática.jpg";
            ViewBag.nomeJ = restJ.nome;
            ViewBag.cidadeJ = restJ.cidade;
            ViewBag.pathJ = restJ.pathImage;

            Restaurante restAl = new Restaurante();
            restAl.nome = "Almada Bar";
            restAl.cidade = "Ubatuba";
            restAl.pathImage = "~/img/AlmadaBarMelhor.png";
            ViewBag.nomeAl = restAl.nome;
            ViewBag.cidadeAl = restAl.cidade;
            ViewBag.pathAl = restAl.pathImage;

            Restaurante restQ = new Restaurante();
            restQ.nome = "Quintal da Vila";
            restQ.cidade = "Ubatuba";
            restQ.pathImage = "~/img/QuintalVilaMelhor.png";
            ViewBag.nomeQ = restQ.nome;
            ViewBag.cidadeQ = restQ.cidade;
            ViewBag.pathQ = restQ.pathImage;

            Restaurante restPorfino = new Restaurante();
            restPorfino.nome = "Portofino";
            restPorfino.cidade = "Ilhabela";
            restPorfino.pathImage = "~/img/PortofinoMelhor.png";
            ViewBag.nomePo = restPorfino.nome;
            ViewBag.cidadePo = restPorfino.cidade;
            ViewBag.pathPo = restPorfino.pathImage;

            Restaurante restCapitano = new Restaurante();
            restCapitano.nome = "Restaurante Capitano";
            restCapitano.cidade = "Ilhabela";
            restCapitano.pathImage = "~/img/RestauranteCapitanoMelhor.png";
            ViewBag.nomeCap = restCapitano.nome;
            ViewBag.cidadeCap = restCapitano.cidade;
            ViewBag.pathCap = restCapitano.pathImage;

            Restaurante restLes = new Restaurante();
            restLes.nome = "Les Épices";
            restLes.cidade = "Guarujá";
            restLes.pathImage = "~/img/LesEpicesMelhor.png";
            ViewBag.nomeLes = restLes.nome;
            ViewBag.cidadeLes = restLes.cidade;
            ViewBag.pathLes = restLes.pathImage;

            return View();
        }
        public IActionResult Catalina()
        {
            Hotel pagHotel = new Hotel();
            pagHotel.nome = "Catalina Hotel";
            pagHotel.cidade = "Ubatuba";
            pagHotel.pathImage = "~/img/Catalina.jpg";
            pagHotel.endereco = "R. Fernando Cirilo Junior 31 Enseada Ubatuba, Enseada, Ubatuba, Estado de São Paulo 11686-824 Brasil";
            pagHotel.telefone = "(12) 3042-0767";
            pagHotel.contaInstaCata = "catalina.hotel";
            ViewBag.nomeCata = pagHotel.nome;
            ViewBag.cidadeCata = pagHotel.cidade;
            ViewBag.pathCata = pagHotel.pathImage;
            ViewBag.endereco = pagHotel.endereco;
            ViewBag.telefone = pagHotel.telefone;
            ViewBag.contaInstaCata = pagHotel.contaInstaCata;

            return View();
        }
        public IActionResult CostaAzul()
        {
            Restaurante restCostAzul = new Restaurante();
            restCostAzul.nome = "Costazul Seafood";
            restCostAzul.cidade = "Santos";
            restCostAzul.pathImage = "~/img/COSTAZUL.jpg";
            restCostAzul.endereco = "Av. Senador Pinheiro Machado, 763, Santos, Estado de São Paulo Brasil";
            restCostAzul.telefone = "+55 13 996969390";
            restCostAzul.contaInsta = "costazulseafood.santos";
            ViewBag.nomeCosta = restCostAzul.nome;
            ViewBag.cidadeCosta = restCostAzul.cidade;
            ViewBag.pathCosta = restCostAzul.pathImage;
            ViewBag.enderecoCosta = restCostAzul.endereco;
            ViewBag.telefoneCosta = restCostAzul.telefone;
            ViewBag.contaInsta = restCostAzul.contaInsta;

            return View();
        }
        public IActionResult TourPele()
        {
            OQueFazer fazPele = new OQueFazer();
            fazPele.nome = "Tour Privativo do Pelé: o Rei do Futebol";
            fazPele.cidade = "Santos";
            fazPele.pathImage = "~/img/RoteiroPelé.jpg";
            fazPele.telefone = "13997719825";
            ViewBag.nomeP = fazPele.nome;
            ViewBag.cidadeP = fazPele.cidade;
            ViewBag.pathP = fazPele.pathImage;
            ViewBag.telefone = fazPele.telefone;

            return View();
        }
        public IActionResult RedirectToCatalina()
        {
            return Redirect("https://www.instagram.com/catalina.hotel/");
        }
        public IActionResult RedirectToCostaAzul()
        {
            return Redirect("https://www.instagram.com/costazulseafood.santos/");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
