using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace ShieldsIOUnityVersion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnityVersionShieldController : ControllerBase
    {
        [HttpGet("getUnityVersion")]
        public ActionResult<UnityVershionShield> Get(string token, string gitOwner, string gitRepos, string pathToProjectVersion)
        {
            var url = $"https://api.github.com/repos/{gitOwner}/{gitRepos}/contents/{pathToProjectVersion}"; //"https://api.github.com/repos/Lizer-flesh/LazerMachine/contents/ProjectSettings/ProjectVersion.txt"
            
            var request = WebRequest.Create(url);
            request.Headers.Add("User-Agent", "Liza");
            request.Headers.Add("Authorization", $"token {token}");

            var response = request.GetResponse();

            string responseFromServer;
            using (var dataStream = response.GetResponseStream())
            {
                var reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
            }

            response.Close();

            var asURLobj = JsonSerializer.Deserialize<asURL>(responseFromServer);
            var base64srting = asURLobj.content;


            var twostr = Encoding.UTF8.GetString(Convert.FromBase64String(base64srting));
            var str = twostr.Split('\n');

            var version = str[0];
            var onlyversionnn = version.Split(' ');
            var onlyversion = onlyversionnn[1];


            var shield = new UnityVershionShield();

            shield.sсhemaVersion = 1;
            shield.label = "Unity Version";
            shield.message = onlyversion;
            shield.color = "blue";

            return new JsonResult(shield);
        }
    }
}