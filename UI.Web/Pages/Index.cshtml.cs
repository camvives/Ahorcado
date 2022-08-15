using Ahorcado.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;




namespace UI.Web.Pages
{

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        //public JuegoAhorcado juegoAhorcado;

        [BindProperty]
        public string LetraIngresada { get; set; }

        [BindProperty]
        public string Jugador { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string url = Microsoft.AspNetCore.Http.Extensions.UriHelper.GetDisplayUrl(Request);
            if (url == "https://tpagiles2022test.azurewebsites.net/")
            {
                JuegoAhorcado.Inicializar("AGILES");
            }
            else
            {
                JuegoAhorcado.Inicializar();
            }

        }

        public void OnPostLetra()
        {
            PartidaAhorcado partida = JuegoAhorcado.GetPartidaActual;
            if (partida.Intentos > 0)
            {
                if (partida.Estado == PartidaAhorcado.Estados.Jugando)
                {
                    partida.RealizarIntento(LetraIngresada);
                }
                else if (partida.Estado == PartidaAhorcado.Estados.Ganada)
                {
                    partida.RegistrarJugador(Jugador);
                    Response.Redirect("/");
                }
            }
            else
            {
                Response.Redirect("/");
            }
        }

        public void OnPostPalabra()
        {
            PartidaAhorcado partida = JuegoAhorcado.GetPartidaActual;
            if (partida.Intentos > 0)
            {
                if (partida.Estado == PartidaAhorcado.Estados.Jugando)
                {
                    partida.IntentarPalabra(LetraIngresada);
                }
                else if (partida.Estado == PartidaAhorcado.Estados.Ganada)
                {
                    partida.RegistrarJugador(Jugador);
                    Response.Redirect("/");
                }
            }
            else
            {
                Response.Redirect("/");
            }
        }
    }
}
