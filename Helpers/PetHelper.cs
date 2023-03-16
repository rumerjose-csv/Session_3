using Microsoft.VisualStudio.TestTools.UnitTesting;
using Session_3.Helpers;
using Session_3.Resources;
using Session_3.DataModels;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using Session_3.Tests.TestData;

namespace Session_3.Helpers
{
    public class PetHelper
    {
        /// <summary>
        /// Send POST request to add new user
        /// </summary>
        ///

        public static async Task<PetModel> AddNewPet(RestClient client)
        {
            var newPetData = GeneratePets.testPet();
            var postRestRequest = new RestRequest(EndPoints.PostPet());

            postRestRequest.AddJsonBody(newPetData);
            var postRestResponse = await client.ExecutePostAsync<PetModel>(postRestRequest);

            var createdPetData = newPetData;
            return createdPetData;
        }
    }
}
