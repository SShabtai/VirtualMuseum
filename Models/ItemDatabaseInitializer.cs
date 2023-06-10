using System.Collections.Generic;
using System.Data.Entity;

namespace VirtualMuseum.Models
{
    public class ItemDatabaseInitializer : DropCreateDatabaseIfModelChanges<ItemContext> // DropCreateDatabaseAlways
    {
        protected override void Seed(ItemContext context)
        {
            GetItemTypes().ForEach(t => context.ItemTypes.Add(t));
            GetArtItems().ForEach(i => context.ArtItems.Add(i)); 
        }

        private static List<ItemType> GetItemTypes()
        {
            var artItems = new List<ItemType> {
                new ItemType
                {
                    ItemTypeID = 1,
                    ItemTypeName = "Painting"
                },
                new ItemType
                {
                    ItemTypeID = 2,
                    ItemTypeName = "Sculpture"
                },
                new ItemType
                {
                    ItemTypeID = 3,
                    ItemTypeName = "VideoArt"
                },
                new ItemType
                {
                    ItemTypeID = 4,
                    ItemTypeName = "Drawing"
                },
                new ItemType
                {
                    ItemTypeID = 5,
                    ItemTypeName = "Photography"
                },
            };

            return artItems;
        }
        private static List<ArtItem> GetArtItems()
        {
            var artItem = new List<ArtItem> {
                new ArtItem
                {
                    ItemID = 1,
                    ItemName = "Mishkenot Shaananim 7",
                    Description = "Aliza Dayan is a multidisciplinary Israeli artist, engaged in painting, sculpture, stained glass and more." +
                    "Dayan studied painting with the painter Meir Natif, and since then has been painting from observation and exploration of the environment. Dayan's paintings vary between several styles - realistic, abstract, naive art and more, and she usually paints mainly in the technique of oil paints on canvas. " +
                    "Dayan usually depicts a wide variety of subjects in her paintings, including paintings of people, landscapes, still life, and more, all from a deep observation and attraction to aesthetics. Dayans paintings are full of emotion and expression. Aliza Dayan presented in several exhibitions in Israel," +
                    "and is also a member of the Mosaic Artists Association in Israel.",
                    ImagePath= "Mishkenot_7.png",
                    UnitPrice = 2300.00,
                    ItemTypeID = 1 // Painting. 
               },
                new ArtItem
                {
                    ItemID = 2,
                    ItemName = "Nectarine", 
                    Description = "Ish Gordon is an Israeli multidisciplinary artist, engaged in painting, digital painting, photography, design and curation. Born in Israel in 1951." +
                                  "Gordon started painting already while in the military service, and even won the first prize as part of a young artists competition.After his military " +
                                  "service he studied art and graphic design in Haifa, and then studied curatorial studies at the Kibbutzim Seminary College." +
                                  "Ish Gordon's paintings are divided into three main categories: abstracts and landscapes, portraits and erotic figurative painting, in some of his " +
                                  "paintings digital work is combined with the material paintings." +
                                  "Ish Gordon presented his works in a large number of exhibitions in Israel and abroad, and won several prestigious awards.",
                    ImagePath="Nectarine.png",
                    UnitPrice = 5300.00,
                    ItemTypeID = 1
               },
                new ArtItem
                {
                    ItemID = 3,
                    ItemName = "Lonly Tree",
                    Description = "Assaf Rodriguez is an Israeli artist, born in Jerusalem. Lives and creates in Kibbutz Megido. Rodriguez started painting at a very young age, " +
                    "he learned a lot from his father (David) the painter. " +
                                  "Assaf Rodriguez acquired a higher education in art studies at the university, " +
                                  "and continued to deepen his knowledge of painting in an autodidactic way, " +
                                  "in addition to studying in various painting workshops. " +
                                  "Rodríguez experimented with a wide variety of styles, " +
                                  "and presented his works in several exhibitions, artistic settings, " +
                                  "and even experimented with wall paintings in large formats. " +
                                  "Most of Rodriguez's works today are in oil paints and drawings, " +
                                  "in a realist style as well as in an abstract style, and he usually paints the landscapes of the north of the country out of love for the region and as a mission to educate the love of the country and its scenery. ",
                    ImagePath="Lonly_Tree.png",
                    UnitPrice = 2900.00,
                    ItemTypeID = 1
                },
                new ArtItem
                {
                    ItemID = 4,
                    ItemName = "View to the Vally",
                    Description = "Eli Shamir is an Israeli artist, born in Kfar Yehoshua in 1953. " +
                                  "Shamir studied art at Bezalel Jerusalem, and then lived and created for a period in Jerusalem and Boston, USA. " +
                                  "Since his return to Israel, Shamir has lived and created in Kfar Yehoshua in the Jezreel Valley, something that is clearly reflected in his works. " +
                                  "Eli Shamir's paintings depict the landscapes of the valley, which are integrated into the story of his life and the life of his family, as well as the historical story of the area. " +
                                  "Shamir presented his works in many exhibitions in Israel and around the world. ",
                    ImagePath="View_to_the_Vally.png",
                    UnitPrice = 235.00,
                    ItemTypeID = 1
                },
                new ArtItem
                {
                    ItemID = 5,
                    ItemName = "Figures",
                    Description = "Meiri studied drawing, sculpture and painting at the Avni Institute in Tel Aviv between 1978-1982. " +
                                  "He painted his first mural at Gordon Beach in Tel Aviv in 1980. It is one of the first murals done in the city. " +
                                  "Since then this art has developed and become an important part of the cultural mosaic of Tel Aviv. ",
                    ImagePath="Figures.png",
                    UnitPrice = 780.00,
                    ItemTypeID = 1
                },
                new ArtItem
                {
                    ItemID = 6,
                    ItemName = "Mexico",
                    Description = "Lior Matlov Kormes is an Israeli artist, born in 1986. " +
                                  "Lior started sculpting and designing at a very young age, first sculpting in ceramics and then moving to sculpting in galvanized iron mesh. " +
                                  "Matlov's works are unique and express his rich inner world, partly through the use of unconventional material from the world of construction, which takes on life and soul in the sculpture. " +
                                  "Another aspect of Lior Matlov's work is the prints he creates, which simulate in a two-dimensional way the sculptures he created. ",
                    ImagePath ="Mexico.png", 
                    UnitPrice = 5000.00, 
                    ItemTypeID = 2 // Sculpture 
                },
                new ArtItem
                {
                    ItemID = 7,
                    ItemName = "Money gets", //  in your eyes
                    Description = "Haim Biran is an Israeli artist, sculptor and architect, born in 1950. " +
                                  "A graduate of the Faculty of Architecture at the Technion in Haifa, he creates unique sculptures using diverse materials in a mixed technique. " +
                                  "The materials Biran works with are mainly brass, copper and wood. His works are special, colorful and thought-provoking. " +
                                  "They express his inner world and sometimes have a humorous nature, some in a surreal style. ",
                    ImagePath="Money_gets_in_your_eyes.png",
                    UnitPrice = 1440.00,
                    ItemTypeID = 2
                },
                new ArtItem
                {
                    ItemID = 8,
                    ItemName = "Laddie", 
                    Description = "Eran Shakine is an Israeli artist, born in 1962. He studied art history at Tel Aviv University as well as art studies at the Ecole de Bouzard in Paris. " +
                                  "Exhibited in many exhibitions in Israel and around the world. ",
                    ImagePath="Laddie.png",
                    UnitPrice = 500.00,
                    ItemTypeID = 2
                },
                new ArtItem
                {
                    ItemID = 9,
                    ItemName = "Was Missing",
                    Description = "Ikki Bar Ziv is a multidisciplinary artist, engaged in sculpture and design. " +
                                  "Bar Ziv's sculpting works range from interior and exterior sculpting, along with useful designs for the home and garden, customized to the customer's taste and needs. " +
                                  "Ikki Bar Ziv makes use of primary raw materials such as wood, iron, brass, tin, concrete in his creations, alongside the use of recycled materials that he finds in the environment. The result is always fascinating and special, expressing the artist's unique language. ",
                    ImagePath="Was_Missing.png",
                    UnitPrice = 1200.00,
                    ItemTypeID = 2
                },
                new ArtItem
                {
                    ItemID = 10,
                    ItemName = "Empire of Sense", // "Empire of Senselessness Part I",
                    Description = "Natascha Sadr Haghighian—born in 1957 in Teheran, Iran, and currently working and residing in " +
                                  "Berlin, Germany—is a contemporary artist whose work is grounded in collectivity, authorship, and various mechanisms of the contemporary art world. ",
                    ImagePath="Empire_of_Senselessness_Part_I.png",
                    UnitPrice = 1500.00,
                    ItemTypeID = 3
                },
                new ArtItem
                {
                    ItemID = 11,
                    ItemName = "Touching the Walls", // "TOUCHING THE WALLS WITH BOTH HANDS SIMULTANEOUSLY",
                    Description = "Rebecca Horn’s (b.1944) early sculptures and performances are about sensing the world in a new way. " +
                                   "Around 1970, during a long convalescence from a serious illness, Horn began making objects that extended the body physically in space. " +
                                   "Her experiences of being confined to bed and suffering isolation, pain, and physical vulnerability inspired a series of prosthetic body sculptures made from " +
                                   "materials reminiscent of bandages and medical devices such as splints. ",
                    ImagePath="TOUCHING_THE_WALLS_WITH_BOTH_HANDS_SIMULTANEOUSLY.png",
                    UnitPrice = 2600.00,
                    ItemTypeID = 3
                },
                new ArtItem
                {
                    ItemID = 12,
                    ItemName = "From the Back",
                    Description = "Dalia Segev is an Israeli painter, illustrator and art teacher, born in 1961. Graduated from art studies at Bezalel Jerusalem. " +
                                  "Segev creates in a variety of techniques, such as oil paintings on canvas, watercolor paintings, ink paintings, monotype prints and more. " +
                                  "Segev's paintings are created from observation, and she combines a variety of subjects in her works such as figures, natural landscapes of the Land of Israel as well as urban landscapes. " +
                                  "Dalia Segev's works have been presented in a large number of solo and group exhibitions, and her paintings are in collections in Israel and abroad. ",
                    ImagePath="From_the_Back.png",
                    UnitPrice = 500.00,
                    ItemTypeID =  4 // Drawing 
                },
                new ArtItem
                {
                    ItemID = 13,
                    ItemName = "Love",
                    Description = "Gil Goren is an internationally acclaimed artist, creating paintings and sculptures in a pop art style using a variety of techniques. " +
                                    "Goren began his journey in the world of advertising, and developed a rich career as a creative vice president in one of the largest advertising agencies in Israel. " +
                                    "A few years ago, Goren decided to change his life path and become a creative artist. Since then, Goren has managed to present and sell his works all over the world, " +
                                    "and cooperate with many partners along the way, including fashion companies in New York, the luxury store Barneys and more. " +
                                    "Among Goren's colorful works you can find paintings, prints and sculptures in the pop art style, which corresponds with American pop culture and the world of animation. ",
                    ImagePath="Love_4.png",
                    UnitPrice = 122.95,
                    ItemTypeID = 4 
                },
                new ArtItem
                {
                   ItemID = 14,
                   ItemName = "Central Park",
                   Description = "Ilan Bashor is an artistic photographer, born in 1952. " +
                                  "Bashor was born and raised in Kibbutz Geash. After his military service, he completed photography studies at Bezalel Jerusalem. " +
                                  "At the beginning of his artistic career Bashor took mainly fashion photographs for women's newspapers, alongside portrait photographs for magazines. " +
                                  "Bashor has photographed many artists and cultural figures, and among other things is responsible for photographing many covers of records and CDs, along with many posters for plays. " +
                                  "Bashor also photographed for some of the leading advertising agencies in Israel, record companies, musicians, designers and more.Beside commercial photography Bashor engages in artistic personal photography. " +
                                  "Ilan Bashor's works have appeared in a large number of solo and group exhibitions in Israel and around the world. To date Bashor has published 2 books of his photographs. ",
                    ImagePath ="Central_Park.png",
                    UnitPrice = 3000.00,
                    ItemTypeID = 5 // Photography 
                },
                new ArtItem
                {
                    ItemID = 15,
                    ItemName = "Angles",
                   Description = "Ilan Bashor is an artistic photographer, born in 1952. " +
                                  "Bashor was born and raised in Kibbutz Geash. After his military service, he completed photography studies at Bezalel Jerusalem. " +
                                  "At the beginning of his artistic career Bashor took mainly fashion photographs for women's newspapers, alongside portrait photographs for magazines. " +
                                  "Bashor has photographed many artists and cultural figures, and among other things is responsible for photographing many covers of records and CDs, along with many posters for plays. " +
                                  "Bashor also photographed for some of the leading advertising agencies in Israel, record companies, musicians, designers and more.Beside commercial photography Bashor engages in artistic personal photography. " +
                                  "Ilan Bashor's works have appeared in a large number of solo and group exhibitions in Israel and around the world. To date Bashor has published 2 books of his photographs. ",
                    ImagePath="Angels_5.png",
                    UnitPrice = 2900.00, 
                    ItemTypeID = 5
                },
                new ArtItem
                {
                    ItemID = 16,
                    ItemName = "Walk to Paradise",
                    Description = "Eugene Smith was an American photographer, lived between the years 1918-1978, best known for his photographs documenting the period of World War II and the period after it ." +
                                  "Smith was born in Kansas, United States, and began his photography career as a photojournalist, then moved to New York and worked for reputable newspapers such as Newsweek and Life. " +
                                  "At the outbreak of World War II, Smith accompanied the American forces in Japan and documented the battles and the forces.In the 1950s he worked in Great Britain and then returned to the United States " +
                                  "for a long project documenting the city of Pittsburgh." +
                                  "In the 1970s, Smith and his wife lived in Japan and worked to document the effects of air pollution in the city of Minamata on the residents. " +
                                  "Smith left behind a strong legacy of photographs and projects that documented historically defining phenomena and events.Today, there is a fund named after him, which encourages " +
                                  "humanistic photography and supports photographers who cover this field. ",
                    ImagePath="Walk_to_Paradise.png",
                    UnitPrice = 2500.00,
                    ItemTypeID = 5
                }
            };

            return artItem;
        }
    }
}
