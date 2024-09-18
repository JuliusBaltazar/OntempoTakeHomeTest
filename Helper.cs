
// ================================================================
// Module   : Helper
// Author   : Julius Baltazar
// Date     : 17/09/2024
// ================================================================
// Revision History
// JLnnnnn | dd/mm/yyyy | Author | Change description
// ================================================================
// ================================================================

using Newtonsoft.Json;
using System.IO;
namespace OntempoTakeHomeTest
{
    public static class Helper
    {

        /// <summary>
        /// Load Data from Json file .
        /// Note: Uses Newtonsoft.Json 13.0.3 from NuGet. Will use System.Text.Json if project is using .NET Core or .NET 5+ frameworks
        /// </summary>
        /// <param name="fileName"></param>
        public static RegionList LoadDataFromJsonFile(string fileName)
        {
            
            // Read the JSON file content
            string jsonString = File.ReadAllText(fileName);

            // Deserialize the JSON content to a RegionList object
            return JsonConvert.DeserializeObject<RegionList>(jsonString);
        }
    }
}
