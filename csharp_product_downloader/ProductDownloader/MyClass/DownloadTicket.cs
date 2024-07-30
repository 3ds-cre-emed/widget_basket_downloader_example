using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDownloader.MyClass
{
    // DownloadTicketFile myDeserializedClass = JsonConvert.DeserializeObject<DownloadTicketFile>(myJsonResponse);
    public class Child
    {
        public string id { get; set; }
        public string name { get; set; }
        public string dsxcad { get; set; }
        public int level { get; set; }
        public List<Child> children { get; set; }
        public DownloadTicket downloadTicket { get; set; }
        public List<Drawing> drawings { get; set; }
    }

    public class DownloadTicket
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Drawing
    {
        public Info info { get; set; }
        public DownloadTicket downloadTicket { get; set; }
    }

    public class Info
    {
        public string name { get; set; }
        public string title { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string modified { get; set; }
        public string created { get; set; }
        public string revision { get; set; }
        public string state { get; set; }
        public string owner { get; set; }
        public string organization { get; set; }
        public string collabspace { get; set; }
        public string cestamp { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string name { get; set; }
        public string dsxcad { get; set; }
        public int level { get; set; }
        public List<Child> children { get; set; }
        public DownloadTicket downloadTicket { get; set; }
        public List<Drawing> drawings { get; set; }
    }

    public class DownloadTicketFile
    {
        public object totalItemCount { get; set; }
        public int totalFolder { get; set; }
        public List<Item> items { get; set; }
    }

}
