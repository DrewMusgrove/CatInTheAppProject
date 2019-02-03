using System;
using System.IO;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace CatInTheApp
{
    public class Cat
    {
       


            public string name { get; }
            public string desc { get; }
            public string image { get; }
            public string childFriendly { get; }
            public string life_span { get; }
            public string origin { get; }
            public string temperament { get; }
            public string wikipedia_url { get; }
            public string energy_level { get; }
            public string vocalisation { get; }
            public string intelligence { get; }


            public Cat(string id)
            {

                var client = new RestClient("https://api.thecatapi.com/v1/breeds?id=abys");
                var requestCat = new RestRequest(Method.GET);
                requestCat.AddHeader("x-api-key", " d1d53190-ad1c-42fe-9769-ca860d446402");
                IRestResponse responseCat = client.Execute(requestCat);
                var textReader = new StringReader(responseCat.Content);

                var jArray = JArray.Parse(responseCat.Content);

                foreach (var item in jArray)
                {

                    var ItemString = item;

                    dynamic cat = ItemString;

                    if (cat.id == id)
                    {
                        this.name = cat.name;
                        this.desc = cat.description;
                        this.childFriendly = cat.child_friendly;
                        this.energy_level = cat.energy_level;
                        this.life_span = cat.life_span;
                        this.origin = cat.origin;
                        this.temperament = cat.temperament;
                        this.wikipedia_url = cat.wikipedia_url;
                        this.vocalisation = cat.vocalisation;
                        this.intelligence = cat.intelligence;
                    }
                }

                // Get image
                var clientCatJpg = new RestClient("https://api.thecatapi.com/v1/images/search?breed_id=" + id);
                var requestCatJpg = new RestRequest(Method.GET);
                requestCatJpg.AddHeader("x-api-key", " d1d53190-ad1c-42fe-9769-ca860d446402");
                IRestResponse responseCatJpg = clientCatJpg.Execute(requestCatJpg);
                var textReaderJpg = new StringReader(responseCatJpg.Content);

                var jArraJpg = JArray.Parse(responseCatJpg.Content);

                foreach (var itemJpg in jArraJpg)
                {

                    var ItemStringJpg = itemJpg;

                    dynamic catJpg = ItemStringJpg;

                    this.image = catJpg.url;

                }


            }
        }
    }

