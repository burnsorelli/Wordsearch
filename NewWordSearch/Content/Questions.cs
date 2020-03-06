using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Content
{
    class Questions
    {
        private static Dictionary<string, string> _permanentQuestionList =
            new Dictionary<string, string>
        {
            // Geography
            { "What is the capital of Egypt", "Cairo" },
            {"In which US state is Plymouth Rock", "Massachusetts" },
            {"What is the national animal of Australia", "Kangaroo" },
            {"In which country is Ben Nevis located", "Scotland" },
            {"In which country can you find the 'mistral' wind", "France" },
            {"Which is the southern-most Country on the South American " +
                    "continent", "Chile" },
            {"What is the largest country in South America", "Brazil" },
            {"How many states are there in the United States of America",
                    "Fifty" },
            {"What is the capital of China", "Beijing" },
            {"Which is the largest continent by area", "Asia" },
            
            // History
            {"In world war 2 the US dropped atomic bombs on Nagasaki and" +
                    " which other Japanese city", "Hiroshima" },
            { "Who issued the Emancipation Proclamation", "Lincoln" },
            {"What sort of buildings are Windsor, Carnarvon and Leeds",
                    "Castle" },
            {"Which battle occured in England in 1066", "Hastings" },
            {"At which battle was Napoleon defeated by Wellington",
                    "Waterloo" },
            {"Who was British prime minister during World War 2",
                    "Churchill" },
            {"What was the title of a ruler in ancient egypt", "Pharo" },
            {"Which team won the first ever world cup", "Uruguay" },
            {"The gunfight at the O.K. Corral took place in which town " +
                    "in Arizona", "Tombstone"},
            {"Who was the first Holywood actor (surname) to become president" +
                    " of the US", "Reagan" },
            {"The spinning jenny was an important invention in which " +
                    "revolution", "Industrial" },
            // Science and Nature
            {"Spiders and scorpions are members of which family",
                    "Arachnids" },
            {"Bronze is an alloy is made from tin and mostly which other " +
                    "metal", "Copper" },
            {"What is the largest flightless bird", "Ostrich" },
            {"Narwhal, Beluga and Bowhead are what type of creature",
                    "Whale" },
            {"Newts and frogs are member of what class of animals",
                    "Amphibians" },
            {"What geographic feature is Krakatoa famous for", "Volcano" },
            {"Which is the largest of the great apes", "Gorilla" },
            {"What colour does copper turn if exposed to the air", "Green" },
            {"Which ingredient is used to make bread rise", "Yeast" },
            {"What desirable item is sometimes produced from an oyster",
                    "Pearl" },
            {"The first man in space was Yuri who", "Gagarin" },
            {"Mixing blue and which other primary colour makes green",
                    "Yellow" },
            // Food and drink
            {"Bread is most commonly made from which crop", "wheat" },
            {"What is the most popular type of pasta", "Spaghetti" },
            {"Goulash is origanally from which country", "Hungary" },
            {"Roast beef is traditionally served with which pudding",
                    "Yorkshire" },
            {"What is battered on a stick to make a corndog", "hotdog" },
            {"Over a campfire what confectionary is traditionally toasted",
                    "Marshmallow" },
            {"Mustard, salt, pepper and mayonnaise are all types of what",
                    "Condiment" },
            {"Haggis comes from which country", "Scotland" },
            {"Wine and champagne are mostly made from which fruits",
                    "Grapes" },
            {"Which country produces the most wine", "Italy" },
            {"Red leicester, emmental and gorgonzola are all types of what",
                    "Cheese" },
            {"Which chocolate manufacturer makes dairy milk and flake bars",
                    "Cadburys" },
            // Sport
            {"In which sport did Martina Navratilova compete", "Tennis" },
            {"The Calcutta cup is a trophy in which sport", "Rugby"  },
            {"Which nation has won the world cup the most", "Brazil" },
            {"Which footballer (surname) married Victoria Adams in 1999",
                    "Beckham" },
            {"What position did Tom Brady play for the New England Patriots",
                    "Quarterback" },
            {"In which sport did Michael Phelps gain 23 gold medals",
                    "Swimming" },
            {"Which olympic event includes javelin, long jump, shot put " +
                    "and discus", "Decathlon" },
            {"What metal traditional represents 3rd place in sporting " +
                    "events", "Bronze" },
            {"How many players in a cricket team", "Eleven" },
            {"In which season does Wimbleden take place", "Summer" },
            {"Who (surname) committed hand-ball against England in the " +
                    "1986 world cup", "Maradona" },
            {"The Rock and Stone Cold Steve Austin became famous from " +
                    "which sport", "Wrestling" },
            // Film and TV
            {"The US film industry is headquartered in which city",
                    "Hollywood" },
            {"Leonardo Dicaprio and Kate Winslet set sail in which film",
                    "Titanic" },
            {"Carl Weathers and Arnold Schwarzenegger fight for their live " +
                    "together against which alien species", "Predator" },
            {"What rare mineral causes friction in James Cameron's Avatar",
                    "Unobtanium" },
            {"Brody, Quint and which other character head out to hunt the " +
                    "shark in Jaws", "Hooper" },
            {"E.T. the Extra-Terrestrial was discovered and befriended by who",
                    "Elliot" },
            {"The popularity of the zombie genre of films is largely " +
                    "credited to which director (surname)", "Romero" },
            {"Which comedy film stars Jonah Hill and Michael Cera as high " +
                    "schoolers about to graduate", "Superbad" },
            {"How many oscars did Ben-Hur and Titanic each win", "Eleven" },
            {"Which actor (surname) starred in Coctail and Days of Thunder",
                    "Cruise" },
            {"Tom Hanks starred alongside Wilson in which film", "Castaway" },
            {"Earth and what other planet are locations in the original " +
                    "film Total Recall", "Mars" },
            // Religion
            {"Which biblical character was swallowed by a whale", "Jonah" },

            // Music
            {"What is the surname of the brothers who formed Oasis ",
                    "Gallagher" },
            {"Smells like teen spirit and all apologies were tracks by " +
                    "which band", "Nirvana" },
            {"Evita, Ray of Light & True Blue were number 1 albums for " +
                    "which female artist", "Madonna" }
        };

        public static Dictionary<string, string> PermanentQuestionList
        {
            get => _permanentQuestionList;
        }
    }
}
