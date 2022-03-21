using Anime_List_App.Core.Interfaces;
using Anime_List_App.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Anime_List_App.Core.StaticClasses
{
    public static class FileConverter
    {
        private static readonly JsonSerializerOptions _jsonSerializerOptions = new() { WriteIndented = true };

        public static async Task ConvertJsonToList<TSource>(this IRoutItem<TSource> list, string fileName)
            where TSource : class
        {
            FileStream? fs = null;

            try
            {
                fs = new FileStream($"{LocalPath.JsonPath}{fileName}.json", FileMode.Open);
                var jsonItems = (await System.Text.Json.JsonSerializer.DeserializeAsync(fs, list.GetType())) as IRoutItem<TSource>;
                if(jsonItems != null)
                    foreach (var item in jsonItems.Items)               
                         list.Items.Add(item);                                               
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                if(fs != null)
                    await fs.DisposeAsync();
            }
        }

        public static async Task<Result<bool>> TryWriteToJson<T>(T instance, string fileName)
            where T : class
        {
            var result = new Result<bool>();
            FileStream? fs = null;

            try
            {
                fs = new FileStream($"{LocalPath.JsonPath}{fileName}.json", FileMode.Create);
                await System.Text.Json.JsonSerializer.SerializeAsync<T>(fs, instance, _jsonSerializerOptions);
                result.Data = true;
            }
            catch (Exception error)
            {
                result.Data = false;
                result.Error = error.Message;
            }
            finally
            {
                if( fs != null)
                    await fs.DisposeAsync();
            }

            return result;
        }
    }
}
