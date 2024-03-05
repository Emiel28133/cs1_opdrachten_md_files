using System;

namespace VariableOpdracht2
{
    internal class Program
    {
        //class variables & gebruik
        static void Main(string[] args)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();

            twitchStream.name = "zackrawr";
            twitchStream.lastStreamName = "pindakaasMannn!";
            twitchStream.streamGame = (new Game("pindakaasLand"));
            twitchStream.followers = 12;
            twitchStream.automod = false;
            //geef nu de stream de volgende waardes:
            //name, waarde: je favoriete streamer
            //lastStreamName, waarde: de streamname van de laatste keer
            //streamGame, waarde een nieuwe instance van Game (new Game("naam van de game hier"})
            //followers, waarde: hoeveel followers
            //automod, waarde: staat automod aan?


            Console.WriteLine("Hello, World!");
        }
    }
}