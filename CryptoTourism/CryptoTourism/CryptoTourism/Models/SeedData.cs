using Cryptotourism.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cryptotourism.Models
{
    public class SeedData
    {

        public static void EnsurePopulatedExperience(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if(!context.Experiences.Any())
            {
                context.Experiences.AddRange(
                     new Experience
                     {
                         //Id = 1,
                         Name = "Best Maramures Experience",
                         ShortDescription = "Maramures - City side",
                         TripDescription = "Visiting the local sheepfold is a one day activity, spending your Saturday or Sunday with me , the shepherds and the their sheep." +
                         "The sheepfold has around 350 sheep, 10 cows, 2 donkeys, 2 horses ( you can ride the horses ) and 2 shepherds . It is located on the Ocna Hill, offering amazing views over 6 villages : Ocna Sugatag , Hoteni, Harnicesti, Sat Sugatag, Manastirea and Giulesti." +
                         "We start our experience by meeting in Breb at 10:00 AM , where we begin our journey, by a horse pulled cart . The ride is about 1 hour so dress according to the weather. During the ride I will tell small historical stories and information about the locals and their villages.",
                         LongDescription = "Go through the nice landscapes of Maramures and enjoy the rural life. You will go through," +
                        "the quiet and peaceful places of Merry Cemetery, Prislop Pass and Borsana Monastery. Explore life in the," +
                        "outskirts of Romania's rural life,",
                         Price = 40,
                         ImageUrl = "https://i.ibb.co/cYDNtr9/iz1-1024x682.jpg",
                         ImageUrl2= "https://i.ibb.co/C6b02NV/iz2-1024x682.jpg",
                         ImageUrl3 = "https://i.ibb.co/Krf3fPM/hutulca1-1024x685.jpg",
                         ImageThumbnailUrl = "https://i.ibb.co/ZmKFNmF/575f0917-bafb-3e19-bcc2-0f5c3d1d43b9.jpg",
                         IsAvailable = true
                     },

            new Experience
            {
                //Id = 2,
                Name = "Travel through Constanta",
                ShortDescription = "Constanta - Sea side",
                TripDescription = "Constanta is the county seat of the county with the same name, Dobrogea, Romania, consisting of Constanta (residence), Mamaia and Palazu Mare. Constanta is one of the oldest cities in Romania. The first documentary testimony dates back to 657 BC. when a Greek colony called Tomis was formed on the site of the current peninsula (and even under the waters today, in front of the Casino). The locality was conquered by the Romans in 71 BC. and renamed Constantiana after the sister of Emperor Constantine the Great. During the 13th century, the Great Sea (as it was then called the Black Sea) was dominated by Italian merchants in Genoa who helped develop the city. Later, Constanta underwent a decline under the Ottoman rule, becoming a simple village inhabited by Greek fishermen and tattoo horses and sheep breeders. The town became a town after the construction of the Cernavoda-Constanta railway line and the port, in 1865, for the export of the Romanian grain. After the War of Independence (1877-1878), when Dobrogea became part of Romania, Constanta, the main port of the state, grew continuously, holding this role until today. Port of Constanta covers an area of ??39.26 km², it is almost 30 km long, it is the largest port in the Black Sea basin and is ranked 4th in Europe.",
                LongDescription = "You will explore Constanta Casino, go through the relax beach of Mamaia and visit the Museum of Natural Sciences, in which a Dolphine Show will await you",
                Price = 30,
                ImageUrl = "https://i.ibb.co/wBqzsKJ/Constanta.jpg",
                ImageUrl2 = "https://i.ibb.co/pzHBJnT/Constanta-Harbour-1200x800.jpg",
                ImageUrl3 = "https://i.ibb.co/4tZ9YC2/44892084.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/37hXLTG/640px-Cazinoul-din-Constanta-la-rasarit-HDR.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 3,
                Name = "Explore Dunarea and it's beauty",
                ShortDescription = "Dunarea - Sea side",
                TripDescription = "The Danube Delta can not bore you, even if you stay only for a weekend or a whole week. All views, idyllic villages and unique experiences here will keep you busy for a long time, and the delight of the Delta will appear as soon as you get home. Walking on the canals is a great opportunity to get to know the interesting life of the Delta - mammals and birds will meet you as soon as you get here. Although these walks are required to discover the Delta, and visits to the most beautiful castles, museums and churches in the Delta are not to be avoided, the Danube Delta has more to offer. We invite you to visit the Delta on wonderful excursions for unforgettable experiences in the Danube Delta.",
                LongDescription = "Explore one of the biggest rivers of Europe through Romania's eyes. You can go fishing, navigating a boat and take one of the famous cabanas alongside the river.",
                Price = 30,
                ImageUrl = "https://i.ibb.co/k6s0ZMp/flora-si-fauna.jpg",
                ImageUrl2 = "https://i.ibb.co/J7wrL9J/casa-1024x683.jpg",
                ImageUrl3 = "https://i.ibb.co/wQTkWT4/royal10.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/2jPF0mH/17523339-1302306296491827-7225206237483034002-n.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 4,
                Name = "Brasov & Medieval towns",
                ShortDescription = "Brasov - Mountain side",
                TripDescription = "A modern walking tour with a medieval twist in one of Romania’s top tourist destinations! Brasov is one of the must-see places that everyone needs to discover. This city comes with a bit of everything – breath-taking mountain scenery, captivating medieval vibe, architectural heritage, or the jazzy array of cafes. The Highlights of Brasov guided tour will take you straight to the heart of this fascinating city. You will explore some of the most important landmarks of this multi-faceted city by foot, see beyond what meets the eye and get a deeper understanding of the city's eclecticism from an experienced local guide. You will not only get to see the most popular sights, but uncover parts of Brasov you may never have known about. Join us and delve into the city's rich history, from medieval to more recent times, the Communist era and subsequent post-communist dizzying transformations.",
                LongDescription = " Explore Brasov town, its landscapes and the medieval towns that go alongside it.You will visit the Black Church, scenic mountains of Tampa and Poiana Brasov skiing & hiking.",
                Price = 20,
                ImageUrl = "https://i.ibb.co/6tHr7dC/brasov-street.jpg",
                ImageUrl2 = "https://i.ibb.co/N3tTs5C/Bastionul-Postavarilor.jpg",
                ImageUrl3 = "https://i.ibb.co/5RPhRtn/Brasov-foto-Ross-Helen.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/qWWMLxd/Brasov-foto-Ross-Helen.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 5,
                Name = "Valea Cetatii Cave & surroundings",
                ShortDescription = "Rasnov - Mountain side",
                TripDescription = "Actual Fish Farm dates back to year 2009. The inn consists of a restaurant, terraces, 8 two-room cottages and 2 flats, modern and demanding, with all utilities, wifi, with closed parking.",
                LongDescription = "Go through the dark secrets of Valea Cetatii cave and feel the goosebumps while the local guide is story-telling you the experience of Rasnov most famous cave.Take a closer look at one of the oldest cave in the country.",
                Price = 20,
                ImageUrl = "https://i.ibb.co/qjz488T/vedere-fata-1-1772x1182.jpg",
                ImageUrl2 = "https://i.ibb.co/nRwrxwv/Pestera-Valea-Cetatii-Rasnov-Bran-Brasov-Pestera-3-1030x773.jpg",
                ImageUrl3 = "https://i.ibb.co/Y8jFY1r/Pestera-Valea-Cetatii.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/xs1mqWt/415-pestera-valea-cetatii-20111121104133.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 6,
                Name = "Rasnov Castle",
                ShortDescription = "Rasnov - Mountain side",
                TripDescription = "The place you will visit lies in the forest next to Rasnov, Brasov. It is a 25 minute drive from Brasov city center to the parking lot, followed by a 1 hour moderate climb. I will personally pick you up by car from Brasov, Rasnov, Bran or any surrounding place where you may be hosted and drive you to the starting point of the climb.  As a bonus, the starting point is at the Ski Jumping basis for the Winter Olympic, which you will get to see closely. Along the way you will admire the beauty of the forest, gaze into an unexplored, wild cave, and reach the peak know to locals as Bisericuta Paganilor ( Pagans' Temple). This is a viewpoint, (a rock coming out of the thick forest) from which you have a 200 degree opening to admire the beauty of the mountains, the forest and embrace the calmness and silence. Once there, you will hear the history behind the place and what happened in the area in the 1600's. (P.S.: it involves medieval battles). ",
                LongDescription = "Explore the castle that was once the official house of the King of Romania.",
                Price = 20,
                ImageUrl = "https://i.ibb.co/YTqRZMh/rasnov-2.jpg",
                ImageUrl2 = "https://i.ibb.co/pKsG092/IMG-1932-1024x768.jpg",
                ImageUrl3 = "https://i.ibb.co/bHmmR8Y/dino-parc-rasnov-brasov-printesa-urbana-7.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/0fqyZzg/Cetatea-Rasnov.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 7,
                Name = "BRAN Castle & surrounding",
                ShortDescription = "BRAN - Mountain side",
                TripDescription = "Bran Castle is situated less than 30 km from Brasov, on the road that starts from the old Bartolomeu neighborhood and connects Brasovul de Campulung. Bran Castle is built on a cliff, at a key strategic point. At present, the collections of furniture, suits, weapons and armor are exhibited in the four-story museum, and the Bran Bran also includes the Royal Park with its two lakes, the Tea House, the Administrator's House and the Princess's House Ileana. In 2000 Bran Castle was claimed by Archduke Dominic of Habsburg and his sisters, Maria Magdalena Holzhausen and Elisabeth Sandhofer, the heirs of Princess Ileana, from which the castle was owned in 1948 by the state.",
                LongDescription = "Explore the BRAN castle, one of the most famous castles in Romania, that brings thousands of tourists curious about the story of Dracula.",
                Price = 20,
                ImageUrl = "https://i.ibb.co/sCvhC7C/admission-main1.jpg",
                ImageUrl2 = "https://i.ibb.co/svqBsCX/bunica3.jpg",
                ImageUrl3 = "https://i.ibb.co/1m6gHdp/bunica2.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/D8bctDK/bran-castel.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 8,
                Name = "Curtea de Arges Monastery",
                ShortDescription = "Curtea de Arges - Hills side",
                TripDescription = "Curtea de Arges was the first capital of Wallachia and preserves the most important Byzantine buildings on the territory of Romania, including the Princely Church, a 14th century monument on the UNESCO indicative list. An important political and economic center during the medieval age, Curtea de Arges fell after the relocation of the Wallachian town fortress to Targoviste but regained its prestige during the interwar period with the designation of the cathedral of the Curtea de Arges Monastery as royal necropolis by Carol I. At Curtea de Arges were born some of the most important rulers of the medieval history of Wallachia (Neagoe Basarab, Vlaicu Voda, Mircea the Elder), but also personalities.",
                LongDescription = " Curtea de Arges Monastery is one of the most famous monasteries in Romania and a must-see attraction if you’re looking to discover centuries-old religious sites.It’s the monumental church and its unique architectural style that make this monastery one of the most representative in Romania, a country that has hundreds of religious monuments of venerable age.",
                Price = 15,
                ImageUrl = "https://i.ibb.co/9tSCMTj/curtea-de-arges1.jpg",
                ImageUrl2 = "https://i.ibb.co/rtM7qkL/1024px-glise-princi-re-Curtea-de-Arges.jpg",
                ImageUrl3 = "https://i.ibb.co/ZWVxHGN/manastirea-curtea-de-arges-2.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/c1ThCcZ/manastirea-curtea-de-arges-2.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 9,
                Name = "Transfagaran & Transalpina",
                ShortDescription = "Transfagarasan - Mountain trip",
                TripDescription = "Transfagarasanul is a traffic road from Romania that starts in Bascov commune, Arges County near Pitesti town, towards Curtea de Arges and ends at the intersection with DN1 road between Sibiu and Brasov, near Cârtisoara commune, with a length 151 km, crossing the north-south axis Fagaras Mountains. The section from Vidraru Dam to Cârtisoara crosses a mountainous terrain at high altitudes and was built until the construction of Vidraru reservoir and reservoir, in 1965, along which the DN7C runs for nearly 20 km, there was an earth road and a mosquito line linking Capatâneni to the old village of Cumpana. The Transfagarasan was built between 1970 and 1974 at the initiative of Nicolae Ceausescu. Although at that time Romania already had several passages of the Southern Carpathians inherited before the Communist period (Alpine Road Novaci-Saliste or the old Câmpina-Predeal Road) or made in the first years of the regime (Bumbesti Jiu-Petrosani Road), the invasion of Czechoslovakia in 1968 by the Soviet troops and the ease with which they could be blocked or attacked by the existing crossings between Transylvania and Muntenia (which, with one exception, followed the course of some rivers) led to the urgent initiation of the Transfagarasan Project - a strategic road linking the Pitesti garrisons and Sibiu.",
                LongDescription = "Explore the Transfagarasan road that is one of the most famous roads in Romania, and even in Europe and rest of the world, due to the height at which it was built, beautiful landscapes and many switchbacks.After that, you will travel to Transalpina road, the highest altitude road in Romania.Whichever is more impressive is hard to say, and it’s up to you to decide",
                Price = 20,
                ImageUrl = "https://i.ibb.co/ccGW7KY/transfagarasan-2.jpg",
                ImageUrl2 = "https://i.ibb.co/YBkKQZj/transfagarasan-cazare-2018.jpg",
                ImageUrl3 = "https://i.ibb.co/mvmCW44/20150627-144845.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/Ntx8vX8/DSC-0147.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 10,
                Name = "Corvin Castle",
                ShortDescription = "Deva - Mountain trip",
                TripDescription = "Everyone has heard of the famous Corvin Castle, the best-preserved medieval monument in Southeast Europe, but few know that the fortification is not the only attraction of the ensemble. In the outer courtyard of the castle built on a rock in the fifteenth century by Iancu de Hunedoara, there is the Husarian Court. Here, tourists can visit a guild house, a museum of history and archeology, and a torture exhibition, all set in 17th-century old buildings.",
                LongDescription = "Explore the most spectacular Gothic-style castle in Romania, Corvin was built by the Anjou family on the site of a former Roman camp.The castle served as a fortress until the mid-14th century when it became the residence of Transylvania's voivode, Iancu de Hunedoara (Ioannes Corvinus in Latin, Hunyadi in Hungarian).Iancu upgraded the fortress transforming it into a stunning Transylvania castle",
                Price = 20,
                ImageUrl = "https://i.ibb.co/k5QTMXF/Castelul-Corvinilor.jpg",
                ImageUrl2 = "https://i.ibb.co/s3VS7PP/Castelul-Huniazilor.jpg",
                ImageUrl3 = "https://i.ibb.co/3CNDdtH/castel-corvini.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/44nvMRx/996f8a109e652b85786e524b5773137f.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 11,
                Name = "Sibiu & Medieval Towns",
                ShortDescription = "Sibiu - City trip",
                TripDescription = "Sightseeing and walking around Sibiu is a nice way to spend a day... but do you know all the secrets and stories of the places you see? Every town has its legends and Sibiu is no exception. Join me in a tour around town focused on legends and stories that few people know and even fewer people share. Interactively participate in the experience, by answering questions and a quiz (don't worry, it's a pleasant one) for which you will get a Legendary Certificate. Trust me, it will be fun!",
                LongDescription = "Explore the beautiful town of Sibiu and listen to the stories of medieval towns that took place in this wonderful city. The location is full of history, rich in culture and it is officialy recognised as one of the UNESCO Heritage sites.",
                Price = 40,
                ImageUrl = "https://i.ibb.co/bRBqH0K/e99ca8aa-9b92-37c7-8ff7-ee889c18e10d.jpg",
                ImageUrl2 = "https://i.ibb.co/sgkFdhP/moara.jpg",
                ImageUrl3 = "https://i.ibb.co/RpYYg9h/DSC01559.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/9tBGwV6/e99ca8aa-9b92-37c7-8ff7-ee889c18e10d.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 12,
                Name = "Cheile Bicaz & Harghita",
                ShortDescription = "Harghita - Mountain trip",
                TripDescription = "Bicaz Gorges is a particularly picturesque geographical area in Romania, located in the central part of the Hasmas Mountains, in the north-east of the country, in Neamt and Harghita counties. Bicaz Gorges were formed by the Bicaz River and connect Transylvania with Moldova. The Cheile Bicazului area, with a length of over 6 km, runs between Upper Lake and upstream Bicaz-Chei, and is crossed by the trans-Carpathian road DN12C connecting Gheorgheni and Bicaz. Bicaz Gorges are included in the Bicaz - Cheile Bicazului National Park - Hasmas (6.575 ha), located on the territory of the Harghita and Neamt counties.",
                LongDescription = "Go through the Cheile Bicaz wonderful landscapes to escape from the city life and live the mountain story of Harghita.",
                Price = 20,
                ImageUrl ="https://i.ibb.co/mhtQL1R/barajul-bicazului-lacul-izvorul-muntelui8.jpg",
                ImageUrl2 = "https://i.ibb.co/CvQGYVH/barajul-bicazului-lacul-izvorul-muntelui8.jpg",
                ImageUrl3 = "https://i.ibb.co/bFH4xpL/lacul-rosu-8.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/6PYQ4dd/cheile-bicazului1.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 13,
                Name = "Fishing house & surroundings",
                ShortDescription = "Harghita - Hills trip",
                TripDescription = "Pension is located in the mountains at an altitude of 1850 meters above see level. The nature around is just smashing! There is no asphalt road to this place, only gravel road. We were over there by adventure motorbikes, thus it was an advantage for us!",
                LongDescription = "Explore the Fishing Cottage, very famous for its delicious food and local experiences around.They organize tours and special experiences for the curious few and discover what true fishing is.",
                Price = 15,
                ImageUrl = "https://i.ibb.co/Ct8jCsc/h54-0.jpg",
                ImageUrl2 = "https://i.ibb.co/51rwRwf/h54-5.jpg",
                ImageUrl3 = "https://i.ibb.co/g9FLgS4/Campul-Cetatii-Han-Pescaresc-panoramio-3.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/10GTRqP/h54-0.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 14,
                Name = "Salina Turda & surroundings",
                ShortDescription = "Turda - Mountain trip",
                TripDescription = "Salt Turda is probably one of the most important and interesting places to see from Transylvania. If we were to find it in a classification, it would certainly be in the Top 10 places to see in Transylvania. The arrangement of the Turda Salt was restored between 2008-2010. A panoramic elevator, a gondola wheel, has been created to create a recreational area with a pier where tourists can take the boats. According to a top made by businessinsider.com Salina Turda is number 22 in the top of the world's most spectacular landmarks.",
                LongDescription = "Go and explore the Turda Salt Mine in which wonderful stories were written and it is now one of the most famous salt mines from Eastern Europe.",
                Price = 20,
                ImageUrl = "https://i.ibb.co/1MyVBWf/6a257228-7cf1-3d53-b77d-288164521183.jpg",
                ImageUrl2 = "https://i.ibb.co/g3qJyG6/salina-turda-5.jpg",
                ImageUrl3 = "https://i.ibb.co/3m5Bxz3/4fa1f73a999f6d85ff9dcd2c0b6b2fe8.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/rybwmV3/6a257228-7cf1-3d53-b77d-288164521183.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 15,
                Name = "Peles Castle Story",
                ShortDescription = "Peles - Mountain trip",
                TripDescription = "You will get the unique opportunity to discover in a fast way the most hidden back country mountain attractions and historical Sinaia Royal city special attractions, as only a local would know. Will have an electric mountain bike guided tour using the facilities of a premium equipment that nobody else have available in the area. You will visit the historical buildings and monuments searching for the forgotten places and will check the garden and outside of Pele? ?i Peli?or and get revealing the most secret or unknown stories of the Royal and communist eras. Then we will climb easy on eMTB some secret trails to feel the most hidden attractions in the wonderful Sinaia back country protected mountain environment.",
                LongDescription = "Nestled at the foot of the Bucegi Mountains in the picturesque town of Sinaia, Peles Castle is a masterpiece of German new-Renaissance architecture, considered by many one of the most stunning castles in Europe.Explore it with one of our local guide and discover the story behind it.",
                Price = 20,
                ImageUrl = "https://i.ibb.co/Bzhb49W/Castelul-Pelesjpg.jpg",
                ImageUrl2 = "https://i.ibb.co/dJ4McPf/salonul-maur-castelul-peles-trivo-ro.jpg",
                ImageUrl3 = "https://i.ibb.co/JFSPBtH/1200px-Kasteel-Peles-2006.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/59BCd4x/Castelul-Peles-Sinaia.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 16,
                Name = "Targu Jiu & Brancusi experience",
                ShortDescription = "Targu Jiu - City trip",
                TripDescription = "Targu Jiu, Brancusi's Town is one of the most important places in Romania from a cultural point of view. The artist, born in Hobita, Gorj County, created in Targu Jiu the monumental ensemble The Heroes Way, with works of art of major importance, with overwhelmingly legendary legends. He is said to be the best sculptor of our age. Including the Table of Silence, the Alley of the Chairs, the Kiss Gate, and the Infinite Column (also known as the Endless Column), all united by an axis, the monumental ensemble The Heroes Way crossed the whole city. One of the largest sculptures in the world, the Infinite Column, considered by the great Sydney Geist infinite sacrifice, represents the cutting edge of modern art, a true spiritual treasure left by Brancusi to mankind. It has a height of 29.33 meters and is made up of 16 modules (15 whole, one half down and one half at the top) made in cast iron, diamond-shaped. Set in two different parks, united by a straight street, as a 1.5 kilometer long axis, called the Heroes Way, the sculptures were put in a specific order, for a specific reason, which we will reveal later. Therefore, the Column of Infinity is located in the Column Park, located at the entrance to the city, in the side of Ramnicu Valcea, and the Meadow of Silence and the Kiss of the Kiss can be found in the Central Park located in the center of Targu Jiu.",
                LongDescription = "A former Roman settlement, the city of Targu Jiu lies at the foothills of the Carpathian Mountains, on the banks of the river Jiu.Constantin Brancusi, one of the most influential modern sculptors of the 20th century, was born near Targu Jiu, in Hobita.Although he lived and worked for most of his life in Paris, his legacy is also preserved in Romania, in the city of Targu Jiu.",
                Price = 40,
                ImageUrl = "https://i.ibb.co/Lh1SXnW/Poarta-Sarutului-2.jpg",
                ImageUrl2 = "https://i.ibb.co/5rSKznB/0316-tg-jiu.jpg",
                ImageUrl3 = "https://i.ibb.co/NmpjbGJ/DSC-5880.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/n1DZJRs/02-targu-jiu.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 17,
                Name = "White mountain Pension & surroundings",
                ShortDescription = "Brasov - Mountain trip",
                TripDescription = "Pension is located in the mountains at an altitude of 1850 meters above see level. The nature around is just smashing! There is no asphalt road to this place, only gravel road. We were over there by adventure motorbikes, thus it was an advantage for us!",
                LongDescription = "Discover the uncommon pension White Mountain hidden in the mountains of Bucegi. Here you will discover what life in the mountains is, with very nice accomodations, you feel welcomed in this wonderful experience.",
                Price = 20,
                ImageUrl = "https://i.ibb.co/7b9070r/78701993.jpg",
                ImageUrl2 = "https://i.ibb.co/hKf2h9x/57462151.jpg",
                ImageUrl3 = "https://i.ibb.co/Htn8M6v/57462360.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/JtMqM3y/cerna-8s218-b.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 18,
                Name = "Sarmisegetusa story & surroundings",
                ShortDescription = "Sarmisegetusa - Mountain trip",
                TripDescription = "Sarmizegetusa Regia was the capital and most important military, religious and political center of the Dacian state before the wars with the Roman Empire. It was the core of a strategic defensive system consisting of six Dacian fortresses from the Orastie Mountains, used by Decebal for defending against the Roman conquest. The archaeological site Sarmizegetusa is located in the village of Gradistea Muncelului in Hunedoara County. After the conquest of Dacia and its incorporation into the Roman Empire, the capital was moved to Ulpia Traiana(Sarmizegetusa), which is more than 40 km away.The ruins of the Dacian fortress Sarmizegetusa Regia have been included on the UNESCO World Heritage List.",
                LongDescription = "Hidden in the dense forests of the Carpathians, Sarmizegetusa Regia is one of the oldest, most surprising and mysterious historical attractions in Romania.The capital of ancient Dacia more than two millenniums ago, this site was the core of the Dacian defensive system before the Roman conquest from the 2nd century AD",
                Price = 20,
                ImageUrl = "https://i.ibb.co/3W70cdp/Sarmisegetusa-Regia-Zona-sacra-Gradistea-Muntelui-Muntii-Sureanu-Hunedoara-Romania-21.jpg",
                ImageUrl2 = "https://i.ibb.co/rxzm8HD/sanctuare-sarmizegetusa-4.jpg",
                ImageUrl3 = "https://i.ibb.co/Dp7W6tD/1200px-Sarmizegetusa-Regia.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/Jr9KJ0q/Sarmisegetusa-Regia-Zona-sacra-Gradistea-Muntelui-Muntii-Sureanu-Hunedoara-Romania-21.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 19,
                Name = "Colibita House & surroundings",
                ShortDescription = "Colibita House - Mountain trip",
                TripDescription = "Colibita is a village in Bistrita Bârgaului commune, Bistrita-Nasaud county, Transylvania, Romania. The settlement is situated on the Bistrita Valley, between the Bârgau Mountains and the Calimani Mountains. As you take the road from Bistrita to Vatra Dornei, you enter into a row, like the endless communes, known as Bârgaie: Rusu Bârgaului, Josenii Bârgaului, Mijlocenii Bârgaului, Susenii Bârgaului, Prundul Bârgaului, Tiha Bârgaului and Muresenii Bârgaului. From Prundul Bargaului, towards the church, the road to the right leads to Colibita, of course through another commune called Bistrita Bargaului. Most people in the area earn their living in agriculture, animal husbandry and wood processing. At the exit from Bistrita Bârgaului the road begins to climb up, the landscape becoming more and more wild. About 7 km from Bistrita Bargaului, there is the accumulation dam and Colibita lake. Looking at the dam you can only see a part of the lake that is quite large, a small detour of it lasts 2 hours by car, of course admiring the beauties of the surrounding nature, and in the distance you can see the mountains that guard the lake: Strunioru and Bistricioru.",
                LongDescription = "Colibita has transformed itself in recent years into a real resort visited both in summer and winter by a considerable number of Romanian and foreign tourists, providing them with plenty of resources to relax their body and mind and enjoy their souls",
                Price = 20,
                ImageUrl = "https://i.ibb.co/Mh5N7bR/81942990.jpg",
                ImageUrl2 = "https://i.ibb.co/vPG3Pdk/Cobili-a-Lake-Bistri-a-N-s-ud.jpg",
                ImageUrl3 = "https://i.ibb.co/tYPGrrQ/colibita-lake.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/XZYgGpD/93559878.jpg",
                IsAvailable = true
            },

            new Experience
            {
                //Id = 20,
                Name = "Bucharest Unique experience",
                ShortDescription = "Bucharest - City trip",
                TripDescription = "Travel back in time through stories of a turbulent past and explore the less savory aspects of its history, from the bloody battles fought between Vlad the Impaler and the Ottoman Empire in the Middle Ages, to the Little Paris era of the early 20th century, and on to Communist times, undoubtedly one of Romania's darkest chapters. Visit the oldest cemetery in town, a beautiful final resting place with an eclectic collection of funeral monuments ranging from astoundingly beautiful to bewildering, and hear stories that will make your heart melt and your hair curl. Explore a former luxury brothel famous during the golden age of 'Little Paris', and hear stories of famous courtesans who stole the hearts of kings. Find out about our own 'Jack the Ripper', dubbed the 'Vampire of Bucharest', who had a penchant for blonde waitresses and terrorized the city in the early 70s. Finish the adventure in the Revolution Square and learn about the hardships of daily life under one of Eastern Europe's most brutal totalitarian regimes, as well as the struggle of the Romanian people to free themselves from oppression through the Revolution of 1989.",
                LongDescription = "Being over 550 years old, Bucharest went through a series of continuous changes, representing the central scene of Romania’s political, artistic, university, financial and cultural life. Between both world wars, due to the elegant architecture and the elite living here, the city was nicknamed “The Little Paris.” Explore the wonderful places of Bucharest, rich in history and culture, that will transcend you in a new world.",
                Price = 40,
                ImageUrl = "https://i.ibb.co/WFdqCgR/16-9-54199883-centru-vechi.jpg",
                ImageUrl2 = "https://i.ibb.co/C59D4zM/5841df49-1e3c-400f-b59c-c64e592b13d5.jpg",
                ImageUrl3 = "https://i.ibb.co/YDNGNdn/Centrul-Vechi.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/H70Y7gG/cec.jpg",
                IsAvailable = false
            },

            new Experience
            {
                //Id = 21,
                Name = "Nation's Heroes Mausoleum",
                ShortDescription = "Marasesti - Hills trip",
                TripDescription = "Marasesti is a town in Vrancea County, Moldova, Romania, consisting of the villages Marasesti (residence), Siretu and Tisita, and Calimanesti, Haret, Modruzeni and Padureni villages. Conflicts known generically as the Battle of Marasesti took place on a length of the front of 35 km, the entire strip of the front having about 75 km (between Namoloasa and Valea Sarii). This was where the Russian troops (84 battalions, 32 squadrons and 79 batteries) and the 1st Romanian Army, consisting of 6 divisions, one of which was a cavalry, three brigades, heavy artillery, Group II aeronautics, etc. (the Romanian army's fighting forces amounted to 170,000 people); on the other side, the German Army IX with 174 battalions, 16 squadrons, 150 batteries, three squadrons, a cycling company, etc.",
                LongDescription = "Explore the Nation's Heroes Mausoleum, among the most important monuments in Europe, The First World War Heroes Mausoleum from Marasesti distinguishes itself as well. It is a monument built in the memory of those who fought during The First World War, when, although inferior numerically to the German troops, the Romanian army succeeded in blocking the German attack.",
                Price = 15,
                ImageUrl = "https://i.ibb.co/tmfzxcB/67917-mausoleu-marasesti-8.jpg",
                ImageUrl2 = "https://i.ibb.co/VT4JtwN/Mausoleul-Eroilor-de-la-Mateia-750x468.jpg",
                ImageUrl3 = "https://i.ibb.co/YLSbSm8/dsc-0401.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/CJDN7DP/67917-mausoleu-marasesti-8.jpg",
                IsAvailable = false
            },

            new Experience
            {
                //Id = 22,
                Name = "Vf Omu & Carpatians Plateau",
                ShortDescription = "Bucegi - Mountain trip",
                TripDescription= "The Omu Peak in the Bucegi Mountains is the sixth highest mountain peak in Romania, located in the Bucegi Mountains, representing the highest point of this massif. According to the Romanian Military Topography Department (DTM), the topographic terminal behind the meteorological station is 2,504.9 meters. This estimate is found on the L-35-87-D-b, 1: 25,000 (1982) topographic sheet in the ministry. This concrete terminal is part of Romania's first order triangulation network. At the base of Omu Chalet, the height is 2,507 m, 2 meters above the topography. The highest natural point in the Bucegi Mountains is 2514 m, at the top of the rock (the boulder). The Omu Peak is visible from the Piatra Craiului Ridge, as well as from the Prahova Valley. On the Omu Peak there is Omu Chalet, and the Omu Peak Meteorological Station, which can be considered the highest place in Romania permanently populated.",
                LongDescription = "Discover the Omu Peak, the highest altitude of Romania.On the Omu Peak there is a narrow platform which shelters in the center a huge monolithic block of stone, about 10m height.On its shelter, the Omu House was built, the old chalet from our mountains. The chalet is also situated on the highest altitude in Romania.",
                Price = 20,
                ImageUrl = "https://i.ibb.co/XSLff38/sfinxul-din-bucegi-8538.jpg",
                ImageUrl2 = "https://i.ibb.co/rxKC0W3/Cabana-Omu.jpg",
                ImageUrl3 = "https://i.ibb.co/By3PW7w/20130727-120909.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/GTZpLHb/descoperirea-misterioasa-a-serviciului-secret-american-in-muntii-bucegi-422911.jpg",
                IsAvailable = false
            },

            new Experience
            {
                //Id = 23,
                Name = "Alba Iulia Citadel Experience",
                ShortDescription = "Alba Iulia - City trip",
                TripDescription = "The city of Alba Iulia is recognized by all Romanians as the place where the Great Union took place on December 1, 1918. Today, the largest fortress built in Vauban style in Romania, Alba Carolina Fortress, preserves the historical and cultural testimonies of the events that led to the formation of the Romanian people. After the great restoration project, the fortress became a tourist attraction point and a stronger symbol of the city, thanks to its cultural and historical heritage, being visited by hundreds of thousands of tourists annually. Alba Carolina Fortress was, is and will remain the emblem of the city of Alba Iulia. Despite the major importance it has over time, many factors have left a negative mark on its appearance and the present monuments.",
                LongDescription = "Discover the city of Alba Iulia, Alba County is one of the most important urban centers of Romania, a place of monumental historical significance, associated to the Great Union of 1918 and the coronation of the kings Ferdinand I and Mary, the first monarchs of Greater Romania. Its ancient medieval center, the Alba Carolina fortress, encloses between its walls several centuries old attractions laden with history, including Saint Michael’s Cathedral.",
                Price = 40,
                ImageUrl = "https://i.ibb.co/hgjxBSd/646x404.jpg",
                ImageUrl2 = "https://i.ibb.co/p4xpvXQ/Principala-1080x675.jpg",
                ImageUrl3 = "https://i.ibb.co/MNcwCTX/Alba-Iulia-cetatea-Alba-Carolina-foto-Photosebia.jpg",
                ImageThumbnailUrl = "https://i.ibb.co/SmYvTBW/cetatea-alba-carolina1.jpg",
                IsAvailable = false
            });

                context.SaveChanges();
            }
        }
    }
}
