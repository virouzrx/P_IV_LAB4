using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace P4_LAB4
{
    class Website
    {
        public Website(string link)
        {
            _link = new RestClient(link);
        }
        public string Download(string path)
        {
            var request = new RestRequest(path, Method.GET);
            var response = _link.Execute(request);
            return response.Content;
        }
        public Task<IRestResponse> DownloadAsync(string path)
        {
            var request = new RestRequest(path, Method.GET);
            var response = _link.ExecuteAsync(request);
            return response;
        }
        public RestClient _link { get; set; }
    }
}
