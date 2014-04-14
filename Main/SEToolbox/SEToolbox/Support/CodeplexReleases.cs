﻿namespace SEToolbox.Support
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.Text.RegularExpressions;
    using SEToolbox.Controls;

    /// <summary>
    /// Extracts the CodePlex website information to determine the version of the current release.
    /// </summary>
    public class CodeplexReleases
    {
        private const string UpdatesUrl = "http://setoolbox.codeplex.com/releases/";

        #region properties

        public string Link { get; set; }
        public Version Version { get; set; }

        #endregion

        #region CheckForUpdates

        public static CodeplexReleases CheckForUpdates()
        {
#if DEBUG
            // Skip the load check, as it make take a few seconds.
            if (Debugger.IsAttached)
                return null;
#endif

            var assemblyVersion = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false)
                    .OfType<AssemblyFileVersionAttribute>()
                    .FirstOrDefault();
            var currentVersion = new Version(assemblyVersion.Version);

            // Create the WebClient with Proxy Credentials.
            var webclient = new MyWebClient();
            webclient.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials; // For Proxy servers on Corporate networks.
            webclient.Headers.Add("Referer", string.Format("https://setoolbox.codeplex.com/updatecheck?current={0}", currentVersion));

            string webContent = null;
            try
            {
                webContent = webclient.DownloadString(UpdatesUrl);
            }
            catch
            {
                // Ignore any errors.
                // If it cannot connect, then there may be an intermittant connection issue, either with the internet, or codeplex (which has happened before).
            }

            if (webContent == null)
                return null;

            // search for html in the form:  <h1 class="page_title wordwrap">SEToolbox 01.025.021 Release 2</h1>
            var match = Regex.Match(webContent, @"\<h1 class=\""(?:[^\""]*)\""\>(?<title>(?:[^\<\>\""]*?))\s(?<version>[^\<\>\""]*)\<\/h1\>");

            if (!match.Success)
                return null;

            // link should be in the form "http://setoolbox.codeplex.com/releases/view/120855"
            var link = webclient.ResponseUri == null ? null : webclient.ResponseUri.AbsoluteUri;

            var item = new CodeplexReleases() { Link = link, Version = GetVersion(match.Groups["version"].Value) };
            if (item.Version > currentVersion)
                return item;

            return null;
        }

        #endregion

        #region GetVersion

        private static Version GetVersion(string version)
        {
            var match = Regex.Match(version, @"(?<v1>\d+)\.(?<v2>\d+)\.(?<v3>\d+)\sRelease\s(?<v4>\d+)");
            if (match.Success)
            {
                return new Version(match.Groups["v1"].Value + "." + match.Groups["v2"].Value + "." + match.Groups["v3"].Value + "." + match.Groups["v4"].Value);
            }
            else
            {
                match = Regex.Match(version, @"(?<v1>\d+)\.(?<v2>\d+)\.(?<v3>\d+).(?<v4>\d+)");
                if (match.Success)
                {
                    return new Version(match.Groups["v1"].Value + "." + match.Groups["v2"].Value + "." + match.Groups["v3"].Value + "." + match.Groups["v4"].Value);
                }
                else
                    return new Version(0, 0, 0, 0);
            }
        }

        #endregion
    }
}
