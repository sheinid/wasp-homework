using System;

namespace MusicStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("Music Store", "123 Green St.");

            store += new Audio("The Beatles", "Abbey Road", 14, "Revolver", "Psychedelic  Rock");
            store += new Audio("Pink Floyd", "Abbey Road", 10, "The Dark Side of the Moon", "Progressive  Rock");
            store += new Audio("Van der Graaf Generator", "Trident Studios", 7, "H to He, Who Am the Only One",
                "Progressive  Rock");

            store += new DVD("John Carpenter", "Embassy Pictures", 99, "Escape From New York", "Action");
            store += new DVD("Steven Spielberg", "Paramount Pictures", 118, "Indiana Jones and the Temple of Doom",
                "Action-Adventure");

            Console.WriteLine(store.ToString());
            
            store.Audios[0].Burn("Mike Oldfield", "Virgin Records", "1", "Tubular Bells", "Progressive  Rock");
            Console.Write(store.Audios[0].ToString());

            foreach (Audio audio in store.Audios)
            {
                Console.WriteLine($"{audio.Name} -> {audio.DiskSize}");
            }
            
            foreach (DVD dvd in store.DVDs)
            {
                Console.WriteLine($"{dvd.Name} -> {dvd.DiskSize}");
            }
            
            Console.Read();
        }

        public interface IStoreItem
        {
            double Price { get; set; }

            public void DiscountPrice(int percent)
            {
                Price -= (Price * percent / 100);
            }
        }

        public class Disk : IStoreItem
        {
            public string Name { get; set; }
            public string Genre { get; set; }
            public int BurnCount { get; set; }

            public Disk(string name, string genre)
            {
                Name = name;
                Genre = genre;
            }

            public virtual int DiskSize { get; set; }

            public virtual void Burn(params string[] values)
            {
            }

            public double Price { get; set; }

            public void DiscountPrice(int percent)
            {
                Price -= (Price * percent / 100);
            }
        }

        public class Audio : Disk
        {
            public string Artist { get; set; }
            public string RecordingStudio { get; set; }
            public int SongsNumber { get; set; }

            public Audio(string artist, string recordingStudio, int songsNumber, string name, string genre) : base(name,
                genre)
            {
                Artist = artist;
                RecordingStudio = recordingStudio;
                SongsNumber = songsNumber;
            }

            public override int DiskSize
            {
                get => SongsNumber * 8;
            }

            public override void Burn(params string[] values)
            {
                Artist = values[0];
                RecordingStudio = values[1];
                SongsNumber = Convert.ToInt32(values[2]);
                Name = values[3];
                Genre = values[4];
                BurnCount++;
            }

            public override string ToString()
            {
                return
                    $"Name: {Name}, Genre: {Genre}, Artist: {Artist}, RecordingStudio: {RecordingStudio}, SongsNumber: {SongsNumber}, BurnCount: {BurnCount}\n";
            }
        }

        public class DVD : Disk
        {
            public string Producer { get; set; }
            public string FilmCompany { get; set; }
            public int MinutesCount { get; set; }

            public DVD(string producer, string filmCompany, int minutesCount, string name, string genre) : base(name,
                genre)
            {
                Producer = producer;
                FilmCompany = filmCompany;
                MinutesCount = minutesCount;
            }

            public override int DiskSize
            {
                get => (MinutesCount / 64) * 2;
            }

            public override void Burn(params string[] values)
            {
                Name = values[0];
                Genre = values[1];
                Producer = values[2];
                FilmCompany = values[3];
                MinutesCount = Convert.ToInt32(values[4]);
                BurnCount++;
            }

            public override string ToString()
            {
                return
                    $"Name: {Name}, Genre: {Genre}, Producer: {Producer}, FilmCompany: {FilmCompany}, MinutesCount: {MinutesCount}, BurnCount: {BurnCount}\n";
            }
        }

        public class Store
        {
            public string StoreName { get; set; }
            public string Address { get; set; }
            public List<Audio> Audios = new List<Audio>();
            public List<DVD> DVDs = new List<DVD>();

            public Store(string storeName, string address)
            {
                StoreName = storeName;
                Address = address;
            }

            public static Store operator +(Store store, DVD dvd)
            {
                store.DVDs.Add(dvd);
                return store;
            }

            public static Store operator -(Store store, DVD dvd)
            {
                store.DVDs.Remove(dvd);
                return store;
            }

            public static Store operator +(Store store, Audio audio)
            {
                store.Audios.Add(audio);
                return store;
            }

            public static Store operator -(Store store, Audio audio)
            {
                store.Audios.Remove(audio);
                return store;
            }

            public override string ToString()
            {
                string audioOutput = "";
                foreach (Audio audio in Audios)
                {
                    audioOutput += audio.ToString();
                }

                string dvdOutput = "";
                foreach (DVD dvd in DVDs)
                {
                    dvdOutput += dvd.ToString();
                }

                return $"Audios:\n{audioOutput} \nDVDs:\n{dvdOutput}\n";
            }
        }
    }
}