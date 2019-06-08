namespace OnlineRadioDatabase
{
    using System;

    public class Song
    {
        private const int ArtistMinNameLength = 3;
        private const int ArtistMaxNameLength = 20;
        private const int SongMinNameLength = 3;
        private const int SongMaxNameLength = 30;
        private const int MinutesMin = 0;
        private const int MinutesMax = 14;
        private const int SecondsMin = 0;
        private const int SecondsMax = 59;

        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;

        public Song(
            string artistName,
            string songName,
            int minutes,
            int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public string ArtistName
        {
            get => this.artistName;

            private set
            {
                if (value.Length < ArtistMinNameLength || value.Length > ArtistMaxNameLength)
                {
                    throw new ArgumentException($"Artist name should be between {ArtistMinNameLength} and {ArtistMaxNameLength} symbols.");
                }

                this.artistName = value;
            }
        }

        public string SongName
        {
            get => this.songName;

            private set
            {
                if (value.Length < SongMinNameLength || value.Length > SongMaxNameLength)
                {
                    throw new ArgumentException($"Song name should be between {SongMinNameLength} and {SongMaxNameLength} symbols.");
                }

                this.songName = value;
            }
        }

        public int Minutes
        {
            get => this.minutes;

            private set
            {
                if (value < MinutesMin || value > MinutesMax)
                {
                    throw new ArgumentException($"Song minutes should be between {MinutesMin} and {MinutesMax}.");
                }

                this.minutes = value;
            }
        }

        public int Seconds
        {
            get => this.seconds;

            private set
            {
                if (value < SecondsMin || value > SecondsMax)
                {
                    throw new ArgumentException($"Song seconds should be between {SecondsMin} and {SecondsMax}.");
                }

                this.seconds = value;
            }
        }
    }
}