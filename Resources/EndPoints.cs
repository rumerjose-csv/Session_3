using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3.Resources
{
    /// <summary>
    /// Class containing all endpoints used in API tests
    /// </summary>

    public class EndPoints
    {
        public static readonly string BaseURL = "https://petstore.swagger.io/v2";

        public static readonly string PetEndpoint = "pet";

        public static string GetPetById(long petID) => $"{BaseURL}/pet/{petID}";

        public static string GetURL(string enpoint) => $"{BaseURL}/pet";

        public static string PostPet() => $"{BaseURL}/pet";

        public static Uri GetURI(string endpoint) => new Uri(GetURL(endpoint));

        public static string DeletePetById(long petIdDel) => $"{BaseURL}/pet/{petIdDel}";
    }
}
