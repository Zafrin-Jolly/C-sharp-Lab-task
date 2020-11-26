using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_interface3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("*****************WELCOME********************"); 
            Console.WriteLine();
            Phone p1 = new Phone("Huawie", "Nova 3i");
            p1.showInfo();
            Console.WriteLine();
            Console.WriteLine("-------In this device,the radio player------------");
            p1.NowInRadio(2.4);
            p1.Switch(true);
            p1.retune(12.34);
            p1.setVolume(60);
            p1.changeChannel();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("-------In this device,The music player----------");
            
            MusicFile m1 = new MusicFile("la la la","jolly",2020,120);
            MusicFile m2 = new MusicFile("sorry", "justin ", 2015, 200);
            MusicFile m3 = new MusicFile("2002", "anne marie", 2016,245);
            MusicFile m9 = new MusicFile("savage", "megan", 2020, 255);
            MusicFile m4 = new MusicFile("rain on me", "lady gaga", 2020, 196);
            MusicFile m5 = new MusicFile("Go crazy", "Christ Brown", 2016, 290);
            MusicFile m6 = new MusicFile("Yummy", "justin biber", 2020, 321);
            MusicFile m7 = new MusicFile("alarm", "anne marie", 2018, 226);
            MusicFile m8 = new MusicFile("Control", "Halsey", 2015, 278);

            p1.AddMusicFile(m1, m2, m3,m4,m5,m6,m7,m8,m9);
            

            //for music player
            p1.Switch(true);
            p1.play(false);
            p1.setVolume(70);
           
            p1.settingsForMusic(3);
            p1.playNext();

            Console.WriteLine("..............Here are the list of all songs...............");
            p1.ShowAllMusicFile();
        }
    }
}
