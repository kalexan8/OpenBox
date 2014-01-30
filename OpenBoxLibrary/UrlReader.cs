using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OpenBoxLibrary
{
    public class UrlReader
    {

        public string ReadUrl(string url)
        {
            return new WebClient().DownloadString(url);
        }
    }
}
