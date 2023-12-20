//namespace _01.Songs
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            int numberOfSongs = int.Parse(Console.ReadLine());

//            List<Songs> songs = new List<Songs>();

//            for (int i = 0; i < numberOfSongs; i++)
//            {
//                string[] songComponents = Console.ReadLine().Split("_");
//                string songTypeList = songComponents[0];
//                string songName = songComponents[1];
//                string songTime = songComponents[2];

//                Songs currentSong = new Songs
//                {
//                    Name = songName,
//                    TypeList = songTypeList,
//                    Time = songTime,
//                };

//                songs.Add(currentSong);
//            }

//            string typeCommand = Console.ReadLine();

//            if (typeCommand != "all")
//            {
//                songs = songs.Where(x => x.TypeList == typeCommand).ToList();
//            }

//            foreach (Songs song in songs)
//            {
//                    Console.WriteLine(song.Name);
//            }

//            //if (typeCommand == "all")
//            //{
//            //    foreach (Songs song in songs)
//            //    {
//            //        Console.WriteLine(song.Name);
//            //    }
//            //}
//            //else
//            //{
//            //    List<Songs> filteredSongs = songs
//            //        .Where(x => x.TypeList == typeCommand)
//            //        .ToList();

//            //    foreach (Songs song in filteredSongs)
//            //    {
//            //        Console.WriteLine(song.Name);
//            //    }
//            //}
//        }
//    }

//    public class Songs
//    {
//        public string Name { get; set; }

//        public string Time { get; set; }

//        public string TypeList { get; set; }
//    }
//}




int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    string[] songDescription = Console.ReadLine().Split("_").ToArray();

    string typeList = songDescription[0];
    string name = songDescription[1];
    string time = songDescription[2];

    Song currentSong = new Song();

    currentSong.TypeList = typeList;
    currentSong.Name = name;
    currentSong.Time = time;


}

public class Song
{
    public string TypeList { get; set; }

    public string Name { get; set; }

    public string Time { get; set; }
}