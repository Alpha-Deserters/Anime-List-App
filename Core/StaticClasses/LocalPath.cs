using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_List_App.Core.StaticClasses
{
    public class LocalPath
    {
        public static string ProjectPath { get; } = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\"));
        public static string JsonPath { get; } = $"{ProjectPath}JSON\\";
        public static string IconsPath { get; } = $"{ProjectPath}Icons\\";
    }
}
