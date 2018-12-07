using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Mvc;
using HtmlAgilityPack;
using BuscaGoogle.Models;


namespace BuscaGoogle.Controllers
{
    public class ResultadoController : Controller
    {

        [ValidateInput(false)]
        public async Task<ActionResult> Index(string termo)
        {
            ViewBag.Termo = termo;
            return View(await IniciaCrawler(termo));
        }

        private async Task<List<Resultado>> IniciaCrawler(string termo)
        {
            var listaResultado = new List<Resultado>();
            var url = "https://www.google.com.br/search?q=" + termo;
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var documento = new HtmlDocument();
            documento.LoadHtml(html);
            var divs = documento.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "").Equals("g")).ToList();
           
            foreach (var div in divs)
            {
                var resultado = new Resultado();
                try
                {
                    resultado.Titulo = div.Descendants("h3").FirstOrDefault().InnerText;
                    var link = div.Descendants("a").FirstOrDefault().ChildAttributes("href").FirstOrDefault()
                        .Value;
                    // remoção do amp do google para o link se tornar válido
                    link = link.Replace("url?q=https://", "");
                    link = link.Replace("url?q=http://", "");
                    link = link.Substring(0, link.IndexOf("&") + 1);
                    link = link.Replace("&", "");
                    resultado.Link = link;
                    listaResultado.Add(resultado);
                }
                catch (Exception ex)
                {
                    var erro = ex;
                }
                
            }
            return listaResultado;
        }
    }
}