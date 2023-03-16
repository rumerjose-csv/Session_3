using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_3.DataModels;
using System.Net;

namespace Session_3.Tests.TestData
{
    public class GeneratePets
    {
        public static PetModel testPet()
        {
            List<Tag> tags = new List<Tag>();
            tags.Add(new Tag()
            {
                Id = 10,
                Name = "TAG Heuer"
            });

            PetModel petModel = new PetModel()
            {
                Id = 20,

                Category = new Category()
                {
                    Id = 10,
                    Name = "Hunter"
                },

                Name = "Hound",
                PhotoUrls = new List<string> { "" },
                Tags = tags,
                Status = "Ready"
            };

            return petModel;
        
        }
    }
}
