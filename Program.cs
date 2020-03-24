using Newtonsoft.Json;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace P4_LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            var api =new Website( "https://api.collegefootballdata.com/");
            var teams = api.DownloadAsync("/teams/fbs").Result.Content;
            var teamsCollection = JsonConvert.DeserializeObject<TeamsCollection>(teams);
            var coaches = api.DownloadAsync($"/coaches?team=Akron").Result.Content; 

            Console.WriteLine(teamsCollection.Teams.Count); 

        }
    }
}
