using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cryptotourism.Models
{
    public class Repository
    {
        private List<Experience> MyExperiences = new List<Experience>
        {
            new Experience
            {
                Name = "Best Maramures Experience",
                ShortDescription = "Maramures - Country side",
                LongDescription = "Go through the nice landscapes of Maramures and enjoy the rural life. You will go through," +
                "the quiet and peaceful places of Merry Cemetery, Prislop Pass and Borsana Monastery. Explore life in the," +
                "outskirts of Romania's rural life,",
                Price = 15,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/ZmKFNmF/575f0917-bafb-3e19-bcc2-0f5c3d1d43b9.jpg"
            },

            new Experience
            {
                Name = "Travel through Constanta",
                ShortDescription = "Constanta - Sea side",
                LongDescription = "You will explore Constanta Casino, go through the relax beach of Mamaia and visit the Museum of Natural Sciences, in which a Dolphine Show will await you",
                Price = 20,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/37hXLTG/640px-Cazinoul-din-Constanta-la-rasarit-HDR.jpg"
            },

            new Experience
            {
                Name = "Explore Dunarea and it's beauty",
                ShortDescription = "Dunarea - River side",
                LongDescription = "Explore one of the biggest rivers of Europe through Romania's eyes. You can go fishing, navigating a boat and take one of the famous cabanas alongside the river.",
                Price = 20,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/2jPF0mH/17523339-1302306296491827-7225206237483034002-n.jpg"
            },

            new Experience
            {
                Name = "Brasov & Medieval towns",
                ShortDescription = "Brasov - Mountain side",
                LongDescription = " Explore Brasov town, its landscapes and the medieval towns that go alongside it.You will visit the Black Church, scenic mountains of Tampa and Poiana Brasov skiing & hiking.",
                Price = 25,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/qWWMLxd/Brasov-foto-Ross-Helen.jpg"
            },

            new Experience
            {
                Name = "Valea Cetatii Cave & surroundings",
                ShortDescription = "Rasnov - Mountain side",
                LongDescription = "Go through the dark secrets of Valea Cetatii cave and feel the goosebumps while the local guide is story-telling you the experience of Rasnov most famous cave.Take a closer look at one of the oldest cave in the country.",
                Price = 15,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/xs1mqWt/415-pestera-valea-cetatii-20111121104133.jpg"
            },

            new Experience
            {
                Name = "Rasnov Castle",
                ShortDescription = "Rasnov - Mountain side",
                LongDescription = "Explore the castle that was once the official house of the King of Romania.",
                Price = 25,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/0fqyZzg/Cetatea-Rasnov.jpg"
            },

            new Experience
            {
                Name = "BRAN Castle & surrounding",
                ShortDescription = "BRAN - Mountain side",
                LongDescription = "Explore the BRAN castle, one of the most famous castles in Romania, that brings thousands of tourists curious about the story of Dracula.",
                Price = 15,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/D8bctDK/bran-castel.jpg"
            },

            new Experience
            {
                Name = "Curtea de Arges Monastery",
                ShortDescription = "Curtea de Arges - Hills side",
                LongDescription = " Curtea de Arges Monastery is one of the most famous monasteries in Romania and a must-see attraction if you’re looking to discover centuries-old religious sites.It’s the monumental church and its unique architectural style that make this monastery one of the most representative in Romania, a country that has hundreds of religious monuments of venerable age.",
                Price = 15,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/c1ThCcZ/manastirea-curtea-de-arges-2.jpg"
            },

            new Experience
            {
                Name = "Transfagaran & Transalpina",
                ShortDescription = "Transfagarasan - Road trip",
                LongDescription = "Explore the Transfagarasan road that is one of the most famous roads in Romania, and even in Europe and rest of the world, due to the height at which it was built, beautiful landscapes and many switchbacks.After that, you will travel to Transalpina road, the highest altitude road in Romania.Whichever is more impressive is hard to say, and it’s up to you to decide",
                Price = 15,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/Ntx8vX8/DSC-0147.jpg"
            },

            new Experience
            {
                Name = "Corvin Castle",
                ShortDescription = "Deva - Mountain trip",
                LongDescription = "Explore the most spectacular Gothic-style castle in Romania, Corvin was built by the Anjou family on the site of a former Roman camp.The castle served as a fortress until the mid-14th century when it became the residence of Transylvania's voivode, Iancu de Hunedoara (Ioannes Corvinus in Latin, Hunyadi in Hungarian).Iancu upgraded the fortress transforming it into a stunning Transylvania castle",
                Price = 15,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/44nvMRx/996f8a109e652b85786e524b5773137f.jpg"
            },

            new Experience
            {
                Name = "Sibiu & Medieval Towns",
                ShortDescription = "Sibiu - Mountain trip",
                LongDescription = "Explore the beautiful town of Sibiu and listen to the stories of medieval towns that took place in this wonderful city. The location is full of history, rich in culture and it is officialy recognised as one of the UNESCO Heritage sites.",
                Price = 25,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/9tBGwV6/e99ca8aa-9b92-37c7-8ff7-ee889c18e10d.jpg"
            },

            new Experience
            {
                Name = "Cheile Bicaz & Harghita",
                ShortDescription = "Harghita - Mountain trip",
                LongDescription = "Go through the Cheile Bicaz wonderful landscapes to escape from the city life and live the mountain story of Harghita.",
                Price = 15,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/6PYQ4dd/cheile-bicazului1.jpg"
            },

            new Experience
            {
                Name = "Fishing house & surroundings",
                ShortDescription = "Harghita - Hills trip",
                LongDescription = "Explore the Fishing Cottage, very famous for its delicious food and local experiences around.They organize tours and special experiences for the curious few and discover what true fishing is.",
                Price = 50,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/10GTRqP/h54-0.jpg"
            },

            new Experience
            {
                Name = "Salina Turda & surroundings",
                ShortDescription = "Turda - Mountain trip",
                LongDescription = "Go and explore the Turda Salt Mine in which wonderful stories were written and it is now one of the most famous salt mines from Eastern Europe.",
                Price = 20,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/rybwmV3/6a257228-7cf1-3d53-b77d-288164521183.jpg"
            },

            new Experience
            {
                Name = "Peles Castle Story",
                ShortDescription = "Peles - Mountain trip",
                LongDescription = "Nestled at the foot of the Bucegi Mountains in the picturesque town of Sinaia, Peles Castle is a masterpiece of German new-Renaissance architecture, considered by many one of the most stunning castles in Europe.Explore it with one of our local guide and discover the story behind it.",
                Price = 20,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/59BCd4x/Castelul-Peles-Sinaia.jpg"
            },

            new Experience
            {
                Name = "Targu Jiu & Brancusi experience",
                ShortDescription = "Targu Jiu - City trip",
                LongDescription = "A former Roman settlement, the city of Targu Jiu lies at the foothills of the Carpathian Mountains, on the banks of the river Jiu.Constantin Brancusi, one of the most influential modern sculptors of the 20th century, was born near Targu Jiu, in Hobita.Although he lived and worked for most of his life in Paris, his legacy is also preserved in Romania, in the city of Targu Jiu.",
                Price = 30,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/n1DZJRs/02-targu-jiu.jpg"
            },

            new Experience
            {
                Name = "White mountain Pension & surroundings",
                ShortDescription = "Brasov - Mountain trip",
                LongDescription = "Discover the uncommon pension White Mountain hidden in the mountains of Bucegi. Here you will discover what life in the mountains is, with very nice accomodations, you feel welcomed in this wonderful experience.",
                Price = 10,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/y6X8KwZ/78701993.jpg"
            },

            new Experience
            {
                Name = "Sarmisegetusa story & surroundings",
                ShortDescription = "Sarmisegetusa - Mountain trip",
                LongDescription = "Hidden in the dense forests of the Carpathians, Sarmizegetusa Regia is one of the oldest, most surprising and mysterious historical attractions in Romania.The capital of ancient Dacia more than two millenniums ago, this site was the core of the Dacian defensive system before the Roman conquest from the 2nd century AD",
                Price = 15,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/Jr9KJ0q/Sarmisegetusa-Regia-Zona-sacra-Gradistea-Muntelui-Muntii-Sureanu-Hunedoara-Romania-21.jpg"
            },

            new Experience
            {
                Name = "Colibita House & surroundings",
                ShortDescription = "Colibita House - Mountain trip",
                LongDescription = "Colibita has transformed itself in recent years into a real resort visited both in summer and winter by a considerable number of Romanian and foreign tourists, providing them with plenty of resources to relax their body and mind and enjoy their souls",
                Price = 15,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/XZYgGpD/93559878.jpg"
            },

            new Experience
            {
                Name = "Bucharest Unique experience",
                ShortDescription = "Bucharest - City trip",
                LongDescription = "Being over 550 years old, Bucharest went through a series of continuous changes, representing the central scene of Romania’s political, artistic, university, financial and cultural life. Between both world wars, due to the elegant architecture and the elite living here, the city was nicknamed “The Little Paris.” Explore the wonderful places of Bucharest, rich in history and culture, that will transcend you in a new world.",
                Price = 30,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/F4cwjb9/16-9-54199883-centru-vechi.jpg"
            },

            new Experience
            {
                Name = "Nation's Heroes Mausoleum",
                ShortDescription = "Marasesti - Hills trip",
                LongDescription = "Explore the Nation's Heroes Mausoleum, among the most important monuments in Europe, The First World War Heroes Mausoleum from Marasesti distinguishes itself as well. It is a monument built in the memory of those who fought during The First World War, when, although inferior numerically to the German troops, the Romanian army succeeded in blocking the German attack.",
                Price = 10,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/CJDN7DP/67917-mausoleu-marasesti-8.jpg"
            },

            new Experience
            {
                Name = "Vf Omu & Carpatians Plateau",
                ShortDescription = "Bucegi - Mountain trip",
                LongDescription = "Discover the Omu Peak, the highest altitude of Romania.On the Omu Peak there is a narrow platform which shelters in the center a huge monolithic block of stone, about 10m height.On its shelter, the Omu House was built, the old chalet from our mountains. The chalet is also situated on the highest altitude in Romania.",
                Price = 15,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/GTZpLHb/descoperirea-misterioasa-a-serviciului-secret-american-in-muntii-bucegi-422911.jpg"
            },

            new Experience
            {
                Name = "Alba Iulia Citadel Experience",
                ShortDescription = "Alba Iulia - Citadel trip",
                LongDescription = "Discover the city of Alba Iulia, Alba County is one of the most important urban centers of Romania, a place of monumental historical significance, associated to the Great Union of 1918 and the coronation of the kings Ferdinand I and Mary, the first monarchs of Greater Romania. Its ancient medieval center, the Alba Carolina fortress, encloses between its walls several centuries old attractions laden with history, including Saint Michael’s Cathedral.",
                Price = 15,
                ImageUrl = null,
                ImageThumbnailUrl = "https://i.ibb.co/SmYvTBW/cetatea-alba-carolina1.jpg"
            },
        };

        public List<Experience> Get()
        {
            return MyExperiences;
        }

        public Experience Get(int id)
        {
            return MyExperiences.First(t => t.Id == id);
        }

        public void Add(Experience newExperience)
        {
            MyExperiences.Add(newExperience);
        }

        public void Update(Experience experienceToUpdate)
        {
            MyExperiences.Remove(MyExperiences.First(t => t.Id == experienceToUpdate.Id));
            Add(experienceToUpdate);
        }

        public void Remove(int id)
        {
            MyExperiences.Remove(MyExperiences.First(t => t.Id == id));
        }
    }
}

