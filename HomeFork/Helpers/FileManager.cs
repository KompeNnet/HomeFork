using HomeFork.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace HomeFork.Helpers
{
    public static class FileManager
    {
        private const string filePath = "Results\\SortingResultInfo.txt";

        public static void Save(List<SortingResult> content)
        {
            Directory.CreateDirectory("Results");
            File.WriteAllText(filePath, JsonSerializer.Serialize(content));
        }

        public static List<SortingResult> Load()
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Oh gosh, sort something at least once before trying to download results");
            }
            else
            {
                return JsonSerializer.Deserialize<List<SortingResult>>(File.ReadAllText(filePath));
            }
        }
    }
}
