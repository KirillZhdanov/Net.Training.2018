using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URL
{
    public struct UrlStruct
    {

        /// <summary>
        /// original url 
        /// </summary>
        public string Original { get; private set; }

        /// <summary>
        /// url struct
        /// </summary>
        public string Struct { get; private set; }

        /// <summary>
        /// url host 
        /// </summary>
        public string Host { get; private set; }

        /// <summary>
        /// url path segments
        /// </summary>
        public string[] Segments { get; private set; }


        public KeyValuePair<string, string>[] Parameters { get; private set; }

        /// <summary>
        /// Try Parse Url
        /// </summary>
        /// <param name="urlString"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool TryParse(string urlString, out UrlStruct url)
        {
            if (Uri.TryCreate(urlString, UriKind.Absolute, out Uri uri))
            {
                url = new UrlStruct
                {
                    Original = uri.OriginalString,
                    Struct = uri.Scheme,
                    Host = uri.Host,
                    Segments = uri.Segments.Length > 0 ? uri.Segments.Skip(1).Select(str => new string(str.TakeWhile(ch => ch != '/').ToArray())).ToArray() : null,
                    Parameters = uri.Query.Length > 0 ? new string(uri.Query.Skip(1).ToArray()).Split('&').Select(str => new KeyValuePair<string, string>(new string(str.TakeWhile(ch => ch != '=').ToArray()), new string(str.SkipWhile(ch => ch != '=').Skip(1).ToArray()))).ToArray() : null
                };

                if (url.Parameters != null && !url.Parameters.All(kvp => kvp.Key != string.Empty && kvp.Value != string.Empty))
                {
                    return false;
                }

                return true;
            }

            url = default(UrlStruct);
            return false;
        }

    }
}
