using ChooseFreeGame.Logic.Entities.Enums;
using ChooseFreeGame.Logic.Entities.Exceptions;
using ChooseFreeGame.Logic.Entities.External;
using ChooseFreeGame.Logic.Entities.Internal;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;

namespace ChooseFreeGame.Logic.Services
{
    public class ClientService : IClientService
    {

        private readonly IHelperService _helperService;
        public ClientService(
            IHelperService helperService
            )
        {
            _helperService = helperService;
        }

        public List<GameBasic> GetAllGames(RandomGameArgs args)
        {
            var url = new UriBuilder(Constants.API_URL);
            url.Path += "games";

            var platform = _helperService.GetEnumDescription(args.Platform);
            url.Query += $"platform={platform}";

            if (args.Category is not Category.ALL)
            {
                var category = _helperService.GetEnumDescription(args.Category);
                url.Query += $"&category={category}";
            }

            var client = new RestClient();
            var request = new RestRequest(url.Uri, Method.Get);

            var res = client.Execute(request);
            if (res?.StatusCode is not HttpStatusCode.OK)
                throw new CommunicationException($"Failed to communicate with the FreeToGame API! (StatusCode: {res?.StatusCode}, Content: {res?.Content})");

            return JsonConvert.DeserializeObject<List<GameBasic>>(res.Content);
        }

        public GameExtended GetGameDetails(int gameId)
        {
            var url = new UriBuilder(Constants.API_URL);
            url.Path += "game";
            url.Query += $"id={gameId}";

            var client = new RestClient();
            var request = new RestRequest(url.Uri, Method.Get);

            var res = client.Execute(request);
            if (res?.StatusCode is not HttpStatusCode.OK)
                throw new CommunicationException($"Failed to communicate with the FreeToGame API! (StatusCode: {res?.StatusCode}, Content: {res?.Content})");

            return JsonConvert.DeserializeObject<GameExtended>(res.Content);
        }
    }
}