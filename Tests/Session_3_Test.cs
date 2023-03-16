using Microsoft.VisualStudio.TestTools.UnitTesting;
using Session_3.Helpers;
using Session_3.Resources;
using Session_3.DataModels;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using Session_3.Tests.TestData;

namespace Session_3.Tests
{
    [TestClass]
    public class Session_3_Test : RestSharpTest
    {
        private static List<PetModel> petCleanUpList = new List<PetModel>();

        [TestInitialize]
        public async Task TestInitialize()
        {
            petDetails = await PetHelper.AddNewPet(restClient);
        }

        [TestMethod]
        public async Task GetPet()
        {
            var restRequest = new RestRequest(EndPoints.GetPetById(petDetails.Id));
            petCleanUpList.Add(petDetails);

            var restResponse = await restClient.ExecuteGetAsync<PetModel>(restRequest);

            Assert.AreEqual(HttpStatusCode.OK, restResponse.StatusCode, "Status code not 200");
            Assert.AreEqual(petDetails.Name, restResponse.Data.Name, "Pet Name not matched.");
            Assert.AreEqual(petDetails.Category.Id, restResponse.Data.Category.Id, "Category not match.");
            Assert.AreEqual(petDetails.PhotoUrls[0], restResponse.Data.PhotoUrls[0], "PhotoUrls not match.");
            Assert.AreEqual(petDetails.Tags[0].Name, restResponse.Data.Tags[0].Name, "Tags not match.");
            Assert.AreEqual(petDetails.Status, restResponse.Data.Status, "Status not match.");
        }

        [TestCleanup]
        public async Task TestCleanUp()
        {
            foreach (var data in petCleanUpList)
            {
                var deletePetRequest = new RestRequest(EndPoints.GetPetById(data.Id));
                var deletePetResponse = await restClient.DeleteAsync(deletePetRequest);
            }
        }
    }
}
