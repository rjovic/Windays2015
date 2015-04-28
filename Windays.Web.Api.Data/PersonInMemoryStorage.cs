using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windays.Web.Api.Data
{
    /// <summary>
    /// Our "in-memory" database
    /// </summary>
    public class PersonInMemoryStorage
    {
        private static PersonInMemoryStorage _instance;
        public static PersonInMemoryStorage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PersonInMemoryStorage();
                }

                return _instance;
            }
        }

        public List<Person> People;

        public void Initialize()
        {
            People = new List<Person>();

            People.Add(new Person(Guid.Parse("C8D5A2D9-6A70-EF95-8A56-4C67B43C4E3C"), "Amber Waller", "Middlesbrough", "Ultrices Sit Amet LLP", 59, Gender.Male));
            People.Add(new Person(Guid.Parse("622EE7C3-6043-0F24-4285-6D5C8C02F813"), "Drake Hays", "Piracicaba", "Pellentesque Company", 40, Gender.Male));
            People.Add(new Person(Guid.Parse("6EE1E25F-0195-3E29-23A0-3027B1ABC273"), "Wendy Santana", "Bilbo", "Velit Quisque Institute", 25, Gender.Male));
            People.Add(new Person(Guid.Parse("FE623A48-7B17-83D8-48D0-9195D271CB87"), "Remedios Hughes", "Balfour", "Lorem Ipsum Dolor Corp.", 26, Gender.Female));
            People.Add(new Person(Guid.Parse("5635600F-8A9E-17BD-0DB8-46502BD61926"), "Rebekah Huff", "Basildon", "Aptent Taciti Sociosqu Associates", 36, Gender.Male));
            People.Add(new Person(Guid.Parse("F2EF40C4-55A3-F5BD-4DCF-80B414D64430"), "Leandra Moran", "Leamington", "Pede Blandit Congue Associates", 29, Gender.Female));
            People.Add(new Person(Guid.Parse("00B0CC55-FD11-3FC1-D8AC-F4F321E2A803"), "Dale Blair", "Wedel", "Eu Euismod Industries", 31, Gender.Female));
            People.Add(new Person(Guid.Parse("63197DCE-1DEF-BE5F-AB04-7A6CFDD2DC44"), "Colorado Sherman", "Stevenage", "Donec LLP", 29, Gender.Female));
            People.Add(new Person(Guid.Parse("642C9DA9-71F9-C166-592A-C2FACFB429E0"), "Stacey Buchanan", "Vegreville", "Ultricies Incorporated", 20, Gender.Male));
            People.Add(new Person(Guid.Parse("68120DB9-115D-D09C-35F4-1BAC67EE22CD"), "Ora Vance", "Khanpur", "Nullam Corporation", 38, Gender.Male));
            People.Add(new Person(Guid.Parse("0308D4CB-00FF-C82B-7FEE-5262B3D6D131"), "Kirby Horton", "Saint-Nicolas", "Donec Fringilla Donec Industries", 36, Gender.Male));
            People.Add(new Person(Guid.Parse("0B07B287-946B-15A8-27BB-8D30B5ECFF3D"), "Wanda Copeland", "Seevetal", "Urna Inc.", 42, Gender.Female));
            People.Add(new Person(Guid.Parse("1D7564BE-D4BE-D7F7-D78D-7792F6D2224E"), "Eagan Nieves", "Worcester", "Non Dui LLP", 45, Gender.Male));
            People.Add(new Person(Guid.Parse("117ABE91-5784-1140-AB7C-77E39E526203"), "John Bright", "Ficarolo", "Dictum Mi Foundation", 35, Gender.Male));
            People.Add(new Person(Guid.Parse("59D78E3E-AD99-4FEE-86D5-04D53BCC6948"), "Wyoming Aguilar", "Khanpur", "Venenatis Vel Faucibus Inc.", 65, Gender.Female));
            People.Add(new Person(Guid.Parse("98CA2006-BC44-3D3D-576E-8C3861A81DC4"), "Quynn Britt", "Mignanego", "Ullamcorper Velit Associates", 48, Gender.Female));
            People.Add(new Person(Guid.Parse("19F43B2A-141B-CFCD-D3CE-4A4F4DE6C20C"), "Stephanie Fry", "Abeokuta", "Dui Company", 38, Gender.Female));
            People.Add(new Person(Guid.Parse("62C93E62-F5D7-FF65-C3BA-FF051724482D"), "Paloma Gentry", "Saint-L?onard", "Id Enim Curabitur Company", 36, Gender.Male));
            People.Add(new Person(Guid.Parse("6A69B0A9-44E7-6C6E-92CC-97F0CAB813B2"), "Macaulay Wells", "Metz", "Ac Mattis Consulting", 44, Gender.Female));
            People.Add(new Person(Guid.Parse("29797B48-B36E-F9DE-8F9F-476E9A646DEF"), "Jonah Wiggins", "Anantapur", "Augue Eu Tempor Consulting", 46, Gender.Female));
            People.Add(new Person(Guid.Parse("2F377883-9347-FAB5-D8D5-3956E08DF8B7"), "Callum Roman", "Pak Pattan", "Vel Vulputate Consulting", 20, Gender.Male));
            People.Add(new Person(Guid.Parse("66D05FA0-BBF1-1A6D-722A-43705FC0F34C"), "Raymond Lawrence", "Te Awamutu", "Lorem Luctus Ut Foundation", 27, Gender.Male));
            People.Add(new Person(Guid.Parse("0D5A7300-1225-056C-C357-3EECF10AD615"), "Kane Olson", "Jonqui�re", "Tincidunt LLP", 40, Gender.Male));
            People.Add(new Person(Guid.Parse("BCE1AC05-F0DF-E45F-7FEC-F8AEE05D349D"), "Kasimir Beck", "Glossop", "Aenean Massa Integer Ltd", 58, Gender.Male));
            People.Add(new Person(Guid.Parse("9689C1EE-183B-99E6-71FD-A89E5DB757D5"), "Shana Britt", "Draguignan", "Non Cursus LLC", 52, Gender.Male));
            People.Add(new Person(Guid.Parse("58683E78-69BA-E4BE-EDA7-DAA6333CF65C"), "Cody Higgins", "Blumenau", "Sem Molestie Sodales Institute", 23, Gender.Female));
            People.Add(new Person(Guid.Parse("B67B005D-24CD-C515-E9C9-84447938E486"), "Cairo Joyner", "Morolo", "Felis Adipiscing Fringilla Institute", 18, Gender.Female));
            People.Add(new Person(Guid.Parse("0AD314C5-6244-EA10-E955-101C18CE772B"), "Nash Bowen", "Bala", "Orci Quis LLP", 54, Gender.Male));
            People.Add(new Person(Guid.Parse("3B7AD843-F5A9-9392-DA7D-670904A94536"), "Joel Acevedo", "Kalyan", "At Company", 22, Gender.Female));
            People.Add(new Person(Guid.Parse("2441469C-DD77-54F5-1EE9-2DE9D8AF8206"), "Cyrus Mcdaniel", "Höchst", "Vulputate Nisi Limited", 62, Gender.Female));
            People.Add(new Person(Guid.Parse("2A7E8769-65EB-9967-B7B1-6D1CB34EC34C"), "Blake Brock", "Borgone Susa", "Curabitur Foundation", 44, Gender.Male));
            People.Add(new Person(Guid.Parse("CD2A4C7E-689C-0344-0B11-4528E626B779"), "Arden Hahn", "Belvedere Ostrense", "Felis Foundation", 39, Gender.Male));
            People.Add(new Person(Guid.Parse("EC9085B3-288A-49F2-5DDB-0350989181D1"), "Jakeem Holman", "Fauvillers", "Interdum Industries", 45, Gender.Male));
            People.Add(new Person(Guid.Parse("4D44C033-3574-44AC-5081-2532F734F083"), "Russell Hinton", "Körfez", "Quisque Imperdiet Industries", 57, Gender.Male));
            People.Add(new Person(Guid.Parse("250A111D-497F-EC31-F87B-1E679D5E7AAC"), "Cole Solis", "Altmünster", "Quam Dignissim Pharetra PC", 26, Gender.Female));
            People.Add(new Person(Guid.Parse("5BA7C6DC-BD8F-C614-A8E7-0BB908050A83"), "Jasper Aguilar", "Campbelltown", "Vel Est Company", 37, Gender.Male));
            People.Add(new Person(Guid.Parse("A692A079-5B86-2C88-EC67-C201656E0AB2"), "Jakeem Garza", "Oud-Turnhout", "Nulla Industries", 30, Gender.Male));
            People.Add(new Person(Guid.Parse("0FC5D615-6A19-7325-1AE9-E2311DAE18AF"), "Simon Hardy", "Sandy", "Pellentesque Consulting", 54, Gender.Male));
            People.Add(new Person(Guid.Parse("DD6638D8-1B40-CFE8-F675-4AE7465D44C6"), "Geoffrey Tate", "Gander", "Ante Dictum Cursus Associates", 25, Gender.Female));
            People.Add(new Person(Guid.Parse("ABBAB0BC-1921-53E4-4C70-1DB492DE3B09"), "Kelsie Hardy", "Ham-sur-Sambre", "Est Mauris Rhoncus PC", 43, Gender.Female));
            People.Add(new Person(Guid.Parse("9721E057-7B55-DE8C-0E25-A027836E519A"), "Sarah Crosby", "Taunton", "Diam Dictum Incorporated", 65, Gender.Male));
            People.Add(new Person(Guid.Parse("67D01CAF-908B-57EB-68BA-BA2192341E27"), "Gloria Fuller", "Villers-la-Ville", "Curabitur Sed Limited", 32, Gender.Male));
            People.Add(new Person(Guid.Parse("C35CF6EE-A3D2-0241-B354-BACEB4E935F3"), "Delilah Hurley", "Valverde", "Ante Blandit Institute", 29, Gender.Male));
            People.Add(new Person(Guid.Parse("BB57FD87-F8A4-CA69-F5FA-5094C015CA2D"), "Caldwell Buckner", "Oostakker", "Donec Non Foundation", 20, Gender.Female));
            People.Add(new Person(Guid.Parse("634FCE25-5A1D-6B52-9FE6-37FD04AFF0E6"), "Tad Barker", "Bolzano/Bozen", "Purus Maecenas Institute", 52, Gender.Male));
            People.Add(new Person(Guid.Parse("7BECAECC-3135-A2A8-8321-384A2D413801"), "Macey Baldwin", "Millet", "Ac Mattis Ornare Consulting", 31, Gender.Male));
            People.Add(new Person(Guid.Parse("BDB85DF0-0A30-15F7-935B-71CA374CE206"), "Blaine Gentry", "St. Andrä", "Neque LLC", 38, Gender.Female));
            People.Add(new Person(Guid.Parse("34F86B3F-BD42-1E3F-2C36-84E3D3006B2A"), "Deanna Ortega", "Comeglians", "Tellus Sem Consulting", 27, Gender.Male));
            People.Add(new Person(Guid.Parse("D0ADF506-90C3-4137-6BF0-0D3E8593DCA1"), "Adria Cleveland", "Hisar", "Sed Id Risus Industries", 26, Gender.Male));
            People.Add(new Person(Guid.Parse("DBB0C6A1-FD0B-C3BC-5ECD-1F1135ABC4C2"), "Serina Riddle", "Gillette", "Nunc Consulting", 54, Gender.Male));
            People.Add(new Person(Guid.Parse("3CC770C3-2762-4511-FFD9-54D27525EBC8"), "Slade Rodgers", "Cambridge", "Arcu Eu Odio Institute", 18, Gender.Female));
            People.Add(new Person(Guid.Parse("80D91E3F-2D10-5ECD-6CA5-B1CB09039CE8"), "Jayme Hicks", "Fort McPherson", "Libero Et Corporation", 65, Gender.Female));
            People.Add(new Person(Guid.Parse("8CB9F91E-52E2-E4CA-F31D-AC099B952CEB"), "Morgan Stephenson", "Asse", "Ultrices Ltd", 41, Gender.Male));
            People.Add(new Person(Guid.Parse("653CE114-C1A5-3A8A-EBCF-44FA4D5E4BD0"), "Joshua Foster", "Ways", "Congue Corporation", 51, Gender.Male));
            People.Add(new Person(Guid.Parse("C70F160C-D187-6E3A-1392-DDC167F6C715"), "Nomlanga Hicks", "Brandenburg", "Nunc LLC", 57, Gender.Female));
            People.Add(new Person(Guid.Parse("E46FB2DB-C1F7-4989-2D20-0CFF4D397A3E"), "Xanthus Morton", "Saint-Remy", "Est Nunc Ltd", 64, Gender.Female));
            People.Add(new Person(Guid.Parse("1BC0920C-8F5E-7D07-2710-1E114C744EC5"), "Cullen Espinoza", "Zaventem", "Laoreet Libero Et Inc.", 29, Gender.Male));
            People.Add(new Person(Guid.Parse("18A9D541-162F-3FB5-9EC7-16397487D60A"), "Owen Booker", "Palagianello", "Vehicula Risus Nulla Associates", 58, Gender.Female));
            People.Add(new Person(Guid.Parse("4FE5AE61-6872-B5BF-B82E-287D03884E55"), "Cheryl Mann", "Beervelde", "Ipsum Dolor Sit Consulting", 23, Gender.Male));
            People.Add(new Person(Guid.Parse("6120932D-F534-E399-DA02-692B7688D176"), "Keefe Garrett", "Mogi das Cruzes", "Aenean Corporation", 38, Gender.Female));
            People.Add(new Person(Guid.Parse("00ADC152-4102-D026-4F58-25FA75C247EB"), "Judah Anderson", "Teralfene", "Risus Varius Incorporated", 60, Gender.Male));
            People.Add(new Person(Guid.Parse("4B7D0F97-79E4-B3E1-8349-A2545DF0D9EB"), "Jarrod Bray", "St. Andrä", "Nonummy Ultricies LLC", 45, Gender.Female));
            People.Add(new Person(Guid.Parse("0FB0BD56-7F08-6C33-D19A-E46A3C59E934"), "Taylor Vargas", "Weesp", "Augue Scelerisque Mollis Corporation", 60, Gender.Female));
            People.Add(new Person(Guid.Parse("88DF5FC3-C043-1D6C-7C8A-8165714C96C2"), "Velma Britt", "Ahrensburg", "Consectetuer Company", 48, Gender.Male));
            People.Add(new Person(Guid.Parse("C32BB1DF-CFC8-A977-5D02-397E116367D4"), "Slade Booth", "Hallein", "Sed Incorporated", 57, Gender.Male));
            People.Add(new Person(Guid.Parse("BE7EB6A0-8669-1275-D88E-A259AB3758B5"), "Anne Black", "Parla", "Quisque Fringilla Foundation", 57, Gender.Male));
            People.Add(new Person(Guid.Parse("1E8426D5-C9F7-7BFB-F042-CDB8BF0D585A"), "Leila Gordon", "Worcester", "Fusce Fermentum Associates", 25, Gender.Female));
            People.Add(new Person(Guid.Parse("F34B4DA9-794D-945F-32FF-6B49525EEC64"), "Porter Hampton", "Latera", "Aenean Sed Pede Corp.", 19, Gender.Male));
            People.Add(new Person(Guid.Parse("FD094CC8-90AA-E275-F732-0FFFAB91FBA6"), "Farrah Washington", "Garbsen", "Faucibus Ut Corporation", 19, Gender.Male));
            People.Add(new Person(Guid.Parse("5AEC81BA-2DE9-E6D2-C82A-BBB32F53F638"), "Sandra Gould", "Wachtebeke", "Donec Tempor Corp.", 40, Gender.Female));
            People.Add(new Person(Guid.Parse("0DD9555D-60D0-C127-8ED5-7488E21D0FD8"), "Claire Knapp", "Enterprise", "Phasellus PC", 24, Gender.Female));
            People.Add(new Person(Guid.Parse("A5469FEB-68B5-1E39-A1B7-8E007006DD7E"), "Gwendolyn Mcdaniel", "Wenduine", "Blandit PC", 23, Gender.Female));
            People.Add(new Person(Guid.Parse("B4542E48-B114-5167-24AD-B7E0A6E7A386"), "Travis Gardner", "San Vicente", "Lorem Foundation", 64, Gender.Male));
            People.Add(new Person(Guid.Parse("A9414691-8295-8D82-4FA7-5644113EE010"), "Irene Cunningham", "Savannah", "Nulla Interdum Curabitur Company", 23, Gender.Female));
            People.Add(new Person(Guid.Parse("80C39CBF-480C-DE4E-B213-057F2FF112E1"), "Summer Short", "Duncan", "Etiam Laoreet Incorporated", 53, Gender.Female));
            People.Add(new Person(Guid.Parse("E44CF019-CB30-06A8-9490-0B53ECA02F63"), "Felix Yates", "San Gregorio nelle Alpi", "Ligula Aenean Euismod Corporation", 44, Gender.Male));
            People.Add(new Person(Guid.Parse("70D94014-2C86-78F3-AC27-0CB3DA76F6F8"), "Yetta Jordan", "Telde", "Integer Vitae Nibh Company", 32, Gender.Female));
            People.Add(new Person(Guid.Parse("B7E43DD7-1F16-350F-948E-5AA566C8D453"), "Jack Brown", "Musselburgh", "Dignissim Tempor Inc.", 61, Gender.Male));
            People.Add(new Person(Guid.Parse("16DAA941-3186-5ECB-B94F-0B7408087286"), "Knox Kaufman", "Iseyin", "Lorem Institute", 43, Gender.Female));
            People.Add(new Person(Guid.Parse("74598E10-1242-80BA-96B7-3AF689E6B379"), "Kasimir Carr", "Cornwall", "Cursus Consulting", 64, Gender.Male));
            People.Add(new Person(Guid.Parse("3DF7F3D9-4708-9E29-5E3D-5808553F6F18"), "Cleo Reyes", "Cerami", "Et Ultrices Posuere LLC", 50, Gender.Female));
            People.Add(new Person(Guid.Parse("466CB812-7F9D-885B-7BC6-FA2AEED5A6EA"), "Alexander Jensen", "Hassan", "In Company", 48, Gender.Male));
            People.Add(new Person(Guid.Parse("89B1FB04-3110-CF34-B972-0E365167C2B4"), "Lenore Peterson", "Muridke", "Fermentum Convallis Ligula Corp.", 39, Gender.Male));
            People.Add(new Person(Guid.Parse("A8D8361D-63FF-DE0F-EAF1-10442A3E37E9"), "Graiden Cardenas", "Folkestone", "Malesuada LLC", 55, Gender.Male));
            People.Add(new Person(Guid.Parse("687B8C1E-0D1E-3F8B-0C98-D95F2ECF82CD"), "Quyn Hodges", "Cherbourg-Octeville", "Montes Consulting", 35, Gender.Female));
            People.Add(new Person(Guid.Parse("65B81532-1FBD-3C52-E626-AB09817B0AA9"), "Quintessa Lyons", "Okara", "Cursus Et Eros Limited", 63, Gender.Male));
            People.Add(new Person(Guid.Parse("0F9E98D4-6F15-5B7C-82D4-EA6AE25D8310"), "Hayes Mason", "Lourdes", "Dis Parturient Institute", 28, Gender.Male));
            People.Add(new Person(Guid.Parse("6E551AA8-44F9-D3FE-A1EA-3014FE24C41E"), "Melyssa Bruce", "Fort Resolution", "Arcu Institute", 41, Gender.Female));
            People.Add(new Person(Guid.Parse("BDB278E3-8C77-75ED-024E-81589FC29811"), "Kennedy Buck", "Gallodoro", "Dolor Quam Consulting", 40, Gender.Female));
            People.Add(new Person(Guid.Parse("E670EA03-304E-5EB1-7D44-395292E603FC"), "Deborah Patrick", "Eschwege", "Quis Diam Industries", 39, Gender.Male));
            People.Add(new Person(Guid.Parse("E66B9EB7-C129-7E58-3465-0C83F939020A"), "Jordan Welch", "North Saanich", "Interdum Feugiat Sed Corp.", 53, Gender.Male));
            People.Add(new Person(Guid.Parse("A87ABFF6-8F9A-1F0B-3AED-B3A943E3EE60"), "Ezekiel Mathews", "Kaduna", "Convallis Ltd", 19, Gender.Male));
            People.Add(new Person(Guid.Parse("E87B7AAF-00DD-34BB-07E8-9285EF12C456"), "Allistair Brewer", "Redruth", "Dictum Magna Company", 60, Gender.Female));
            People.Add(new Person(Guid.Parse("71AFC925-FD39-FEEA-FDDB-184A2B7A733C"), "Keefe Castillo", "Wollongong", "Ultricies Ornare Foundation", 64, Gender.Male));
            People.Add(new Person(Guid.Parse("F5B57513-7D08-3870-3BAD-E5A7040C358A"), "Steel Winters", "Strombeek-Bever", "Ultrices Vivamus Rhoncus Ltd", 62, Gender.Female));
            People.Add(new Person(Guid.Parse("C13B5C04-3351-2EA2-A808-63446DCBB19C"), "Hannah Huffman", "Berg", "Tristique Pharetra Institute", 54, Gender.Female));
            People.Add(new Person(Guid.Parse("6C3DAB7D-922E-C7F8-3F20-E32E144ECB23"), "Tyrone King", "Seattle", "Facilisis Facilisis Corp.", 38, Gender.Female));
            People.Add(new Person(Guid.Parse("E51A7663-5611-FF4D-822C-E022C5F654F5"), "Quamar Mckenzie", "Colledimacine", "Massa Corporation", 57, Gender.Female));
            People.Add(new Person(Guid.Parse("5035A680-4BDE-DA73-7D4C-4E4B45021C01"), "Melanie Waters", "Durg", "Nibh Phasellus Limited", 45, Gender.Male));
            People.Add(new Person(Guid.Parse("9BB926F5-AB90-C07E-E1D2-D710861E1FF2"), "Fallon Horton", "Çarşamba", "Scelerisque Limited", 56, Gender.Male));
        }
    }
}
