using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_interface3
{
    class MusicFile
    {
        private String title;

        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        private String artist;

        public String Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        private int yearOfRelease;

        public int YearOfRelease
        {
            get { return yearOfRelease; }
            set { yearOfRelease = value; }
        }
        private int durationInSecond;

        public int DurationInSecond
        {
            get { return durationInSecond; }
            set { durationInSecond = value; }
        }

        public MusicFile() { }
        public MusicFile(String title,String artist,int yearOfRelease,int durationInSecond)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSecond = durationInSecond;
        }
        
        public void ChangeTitle(String title)
        {
            this.title = title;
            Console.WriteLine("The title has been changed into :" +title);
        }
        public void showMusicInfo()
        {
            Console.WriteLine("The title of the music : "+title);
            Console.WriteLine("The artist of the music : " + artist);
            Console.WriteLine("The year of release of the music : " + yearOfRelease);
            Console.WriteLine("The duration of the music : " + durationInSecond +" seconds");
        }
    }
}
