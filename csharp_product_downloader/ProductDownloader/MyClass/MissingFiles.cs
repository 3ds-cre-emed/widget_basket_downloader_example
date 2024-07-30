using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDownloader.MyClass
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class MissingFile
    {
        public string id { get; set; }
        public string name { get; set; }
        public string filename { get; set; }
        public string url { get; set; }
        public string targetpath { get; set; }
    }

    public class MissingFiles
    {
        public int itemCount { get; set; }
        public string parent { get; set; }
        public List<MissingFile> missingFiles { get; set; }
    }


}
