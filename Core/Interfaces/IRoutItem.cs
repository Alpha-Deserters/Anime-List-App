using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_List_App.Core.Interfaces
{
    public interface IRoutItem<T>
    {
        public List<T> Items { get; set; } // mb switch to IEnumerator 
    }
}
