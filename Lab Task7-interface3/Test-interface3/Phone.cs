using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_interface3
{
    class Phone : Device, MusicPlayerInterface, RadioPlayerInterface
    {
        private MusicFile[] musicFiles;
        public int myfileCount { get; set; }
        public Phone()
        {
            musicFiles = new MusicFile[500];
            myfileCount = 0;
        }
        public Phone(String deviceName,String model):base(deviceName,model)
        {
            musicFiles = new MusicFile[500];
            myfileCount = 0;

        }
        public void AddMusicFile(params MusicFile[] files)
        {
            foreach (var musicFile in files)
            {
                if (myfileCount < 50)
                {
                    this.musicFiles[myfileCount++] = musicFile;
                }
                else
                    Console.WriteLine("OOPS!!! Cant add more music!!!!!");

            }
        }
        public void ShowAllMusicFile()
        {
            Console.WriteLine("-----------the musiic list-----------");
            for (int i = 0; i < myfileCount; i++)
            {
                musicFiles[i].showMusicInfo();
                Console.WriteLine();

            }
        }

        //for radio
        public double recentChannelNumber{ get; set; }
        public double changedChannel { get; set; }

        public void NowInRadio(double recentChannelNumber)
        {
            Console.WriteLine();
            this.recentChannelNumber = recentChannelNumber;
            Console.WriteLine("The recent channel on radio is : " +recentChannelNumber);
        }
        public int song { get; set; }
     
        public void settingsForMusic(int song)
        {
            Console.WriteLine();
            Console.WriteLine("Your recent song is : ");
            musicFiles[song].showMusicInfo();
        }

        public void changeChannel()
        {
            
            changedChannel = recentChannelNumber + 1;
            Console.WriteLine("The channel is changed and now its on "+changedChannel+" channel");
        }

        public void play(bool on)
        {
            
            if (on == true)
            {
                Console.WriteLine("Music player Swtich is on" + on);
            }
            else
                Console.WriteLine("Music player Switch is off");
        }
       // public int recentsong { get; set; }

        public void playNext()
        {
            Console.WriteLine();
            Console.WriteLine("******Playing the next song*****");
            musicFiles[song+1].showMusicInfo();
            Console.WriteLine();
            
        }

        public void playPrevious()
        {
            Console.WriteLine();
            Console.WriteLine("******Playing the previous song*****");
            musicFiles[song-1].showMusicInfo();
           
        }

        public void retune(double frequency)
        {
            
            Console.WriteLine("The frequency of radio is :"+frequency+" Hz");
        }

        public void setVolume(int loudness)
        {
           
            Console.WriteLine("The volume is at :" + loudness);
        }

        public void Switch(bool on)
        {
            Console.WriteLine();
            if (on==true)
            {
                Console.WriteLine(" Swtich is on");
            }
            else
                Console.WriteLine("Switch is off");
           
        }

    }
}
