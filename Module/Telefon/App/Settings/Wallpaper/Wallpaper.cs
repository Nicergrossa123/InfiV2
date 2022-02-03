using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace GVRP.Module.Telefon.App.Settings.Wallpaper
{
    public class Wallpaper : Loadable<uint>
    {
        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        [JsonProperty("file")]
        public string File
        {
            get;
            set;
        }

        public Wallpaper(int id, string name, string file)
        {
            this.Id = id;
            this.Name = name;
            this.File = file;
        }
    }
}
