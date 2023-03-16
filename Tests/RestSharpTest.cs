using Microsoft.VisualStudio.TestTools.UnitTesting;
using Session_3.Helpers;
using Session_3.Resources;
using Session_3.DataModels;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Session_3.Tests
{
    [TestClass]
    public class RestSharpTest
    {
        public RestClient restClient { get; set; }

        public PetModel petDetails { get; set; }

        [TestInitialize]
        public void Initilize()
        {
            restClient = new RestClient();
        }

        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}