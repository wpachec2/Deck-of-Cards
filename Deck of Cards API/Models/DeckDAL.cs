using System;
using System.Net;
using Newtonsoft.Json;

namespace Deck_of_Cards_API.Models
{
    public class DeckDAL
    {
        public static DeckModel GetDeck(string deckId) //Adjust here for future use
        {
            //Adjust here
            //Setup
            string url = $"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count=5";

            //Request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Adjust here
            //Convert to C#
            DeckModel result = JsonConvert.DeserializeObject<DeckModel>(JSON);
            return result;
        }
    }
}

