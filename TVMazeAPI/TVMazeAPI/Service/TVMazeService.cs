using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TVMazeAPI.Data;
using TVMazeAPI.Model;

namespace TVMazeAPI.Service
{
    public class TVMazeService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly TVMazeAPIContext _context;
        public TVMazeService(IHttpClientFactory httpClientFactory, TVMazeAPIContext context)
        {
            _httpClientFactory = httpClientFactory;
            this._context=context;

        }
        public async Task TVMazeShowsAPIResult()
        {
            var httpClient = _httpClientFactory.CreateClient("TVmazeAPI");
            int startPage = 0;
            while(true)
            {   
            var url_endpoint = $"https://api.tvmaze.com/shows?page={startPage}"; // API call with pagination
            var response = await httpClient.GetAsync(url_endpoint);

                if(!response.IsSuccessStatusCode)
                {
                    break;
                }
               
              var content = await response.Content.ReadAsStringAsync();
                    // Deserialize content into a list of TVMazeShow
              var jsonObject = JsonConvert.DeserializeObject<List<TVMazeShow>>(content);

              var shows = new List<TVMazeShow>();

               foreach (var show in shows)
                {
                        // Fetch cast information for each show
                var castinfo = $"https://api.tvmaze.com/shows/{show.ID}/cast";
                var castresponse = await httpClient.GetAsync(castinfo);

                if (castresponse.IsSuccessStatusCode)
                  {
                    var castContent = await castresponse.Content.ReadAsStringAsync();
                    var castList = JsonConvert.DeserializeObject<List<CastInfo>>(castContent).Select(c => c.Person).ToList();
                    show.Cast = castList;
                    var existingShow=_context.Shows.Include(s=>s.Cast).First(s=>s.ID == show.ID);
                        if (existingShow == null)
                        {
                            _context.Shows.Add(show);
                        }
                        else
                        {
                            // Update existing show information
                            existingShow.Name = show.Name;
                            existingShow.Cast = castList;
                        }


                    }
                }
               await _context.SaveChangesAsync();
                startPage++;
            }
        }


    }
}
