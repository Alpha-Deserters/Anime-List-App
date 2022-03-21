using Anime_List_App.Core.Interfaces;
using Anime_List_App.Core.Model;
using Anime_List_App.Core.StaticClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Anime_List_App.Core.Models.RootModels
{
    public class UserRoots : IRoutItem<User>
    {
        [JsonPropertyName("items")]
        public List<User>? Items { get; set; }

        public async Task UpdateItems()
        {
            Items = new List<User>();
            await this.ConvertJsonToList(JsonType.Users);
        }
    }
}
