using Ahorcado.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Web.Pages
{
    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string PalabraAAdivinar;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            PartidaAhorcado partida = new PartidaAhorcado("Ahorcado");
            HttpContext.Session.SetString("PalabraAAdivinar", partida.PalabraAAdivinar);
            HttpContext.Session.SetObjectAsJson("Partida", partida);
        }

        public void OnPost()
        {
             
        }

    }     


 
}
