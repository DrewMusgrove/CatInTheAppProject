using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace CatInTheApp
{

    public partial class Default : System.Web.UI.Page
    {
        public String imageURL = "";

        public String childFriendly = "0";
        public String childFriendlyURL = "";

        public String energyLevel = "0";
        public String energyLevelURL = "";

        public String vocalisation = "0";
        public String vocalisationURL = "";

        public String intelligence = "0";
        public String intelligenceURL = "";



        public void button1Clicked(object sender, EventArgs args)
        {
            if (CatBreeds.Text == "")
            {

            }
            else
            {
                Cat Cat = new Cat(CatBreeds.Text);
                CatDesc.Text = Cat.desc;
                CatName.Text = Cat.name;
                CatImage.ImageUrl = Cat.image;
                imageURL = Cat.image;
                lifeSpan.Text = Cat.life_span;
                origin.Text = Cat.origin;
                temperament.Text = Cat.temperament;
                wikiLink.NavigateUrl = Cat.wikipedia_url;
                wikiLink.Text = Cat.wikipedia_url;

                childFriendly = Cat.childFriendly;
                childFriendlyControl.Mode = LiteralMode.Encode;
                childFriendlyControl.Mode = LiteralMode.PassThrough;
                childFriendlyControl.Mode = LiteralMode.Transform;
                childFriendlyURL = "\"" + childFriendly + "\"";
                childFriendlyControl.Text = @"<div class=""star-ratings-css"" title=" + childFriendlyURL + "></div>";

                energyLevel = Cat.energy_level;
                energyLevelControl.Mode = LiteralMode.Encode;
                energyLevelControl.Mode = LiteralMode.PassThrough;
                energyLevelControl.Mode = LiteralMode.Transform;
                energyLevelURL = "\"" + energyLevel + "\"";
                energyLevelControl.Text = @"<div class=""star-ratings-css"" title=" + energyLevelURL + "></div>";

                intelligence = Cat.intelligence;
                intelligenceControl.Mode = LiteralMode.Encode;
                intelligenceControl.Mode = LiteralMode.PassThrough;
                intelligenceControl.Mode = LiteralMode.Transform;
                intelligenceURL = "\"" + intelligence + "\"";
                intelligenceControl.Text = @"<div class=""star-ratings-css"" title=" + intelligenceURL + "></div>";

                vocalisation = Cat.vocalisation;
                vocalisationControl.Mode = LiteralMode.Encode;
                vocalisationControl.Mode = LiteralMode.PassThrough;
                vocalisationControl.Mode = LiteralMode.Transform;
                vocalisationURL = "\"" + vocalisation + "\"";
                vocalisationControl.Text = @"<div class=""star-ratings-css"" title=" + vocalisationURL + "></div>";

            }





        }

        void Page_Load()
        {
            if (CatBreeds.Items.Count == 0)
            {
                var client = new RestClient("https://api.thecatapi.com/v1/breeds");
                var requestCat = new RestRequest(Method.GET);
                requestCat.AddHeader("x-api-key", " d1d53190-ad1c-42fe-9769-ca860d446402");
                IRestResponse responseCat = client.Execute(requestCat);
                var textReader = new StringReader(responseCat.Content);

                var jArray = JArray.Parse(responseCat.Content);
                List<ListItem> items = new List<ListItem>();
                String ID = "";
                String Name = "";
                items.Add(new ListItem("Select Breed", ""));
                foreach (var item in jArray)
                {

                    var ItemString = item;

                    dynamic cat = ItemString;

                    ID = cat.id;
                    Name = cat.name;
                    items.Add(new ListItem(Name, ID));



                }
                CatBreeds.Items.AddRange(items.ToArray());
            }
        }
    }

}
