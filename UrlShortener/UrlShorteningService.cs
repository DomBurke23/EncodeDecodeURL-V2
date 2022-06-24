using System;
using System.Collections.Generic;
using System.Text;

namespace UrlShortener
{
    public class UrlShorteningService : IUrlShorteningService
    {
        private readonly Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public string Encode(string url)
        {
            // does url already exist in dictionary?
            // failing fast - improves performance (only slightly)
            if (!dictionary.ContainsKey(url))
            {
                // assign the url with this code (make unique) in a dictionary
                var bytes = System.Text.ASCIIEncoding.ASCII.GetBytes(dictionary.Count.ToString());
                string encodedUrl = Convert.ToBase64String(bytes);
                dictionary.Add(url, encodedUrl);
            }
            // key exists 
            return dictionary[url];
        }

        public string Decode(string encodedUrl)
        {
            if (!dictionary.ContainsKey(encodedUrl))
            {
                //log.LogError();
            }
            byte[] data = Convert.FromBase64String(encodedUrl);
            string decodedString = Encoding.ASCII.GetString(data);
            return decodedString;

            // replace and return dictionary value to match key encodedUrl 
        }
    }
}
