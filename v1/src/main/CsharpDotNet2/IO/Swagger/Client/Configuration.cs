using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AdobeSignClient.V1.Client
{
    /// <summary>
    ///     Represents a set of configuration settings
    /// </summary>
    public class Configuration
    {
        private const string ISO8601_DATETIME_FORMAT = "o";

        /// <summary>
        ///     Version of the package.
        /// </summary>
        /// <value>Version of the package.</value>
        public const string Version = "1.0.0";

        private static string _tempFolderPath = Path.GetTempPath();

        /// <summary>
        ///     Gets or sets the API key based on the authentication name.
        /// </summary>
        /// <value>The API key.</value>
        public static Dictionary<string, string> ApiKey = new Dictionary<string, string>();

        /// <summary>
        ///     Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.
        /// </summary>
        /// <value>The prefix of the API key.</value>
        public static Dictionary<string, string> ApiKeyPrefix = new Dictionary<string, string>();

        /// <summary>
        ///     Gets or sets the default API client for making HTTP calls.
        /// </summary>
        /// <value>The API client.</value>
        public static ApiClient DefaultApiClient = new ApiClient();

        private static string _dateTimeFormat = ISO8601_DATETIME_FORMAT;


        /// <summary>
        ///     Gets or sets the the date time format used when serializing in the ApiClient
        ///     By default, it's set to ISO 8601 - "o", for others see:
        ///     https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        ///     and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        ///     No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public static string DateTimeFormat
        {
            get { return _dateTimeFormat; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                _dateTimeFormat = value;
            }
        }

        /// <summary>
        ///     Gets or sets the password (HTTP basic authentication).
        /// </summary>
        /// <value>The password.</value>
        public static string Password { get; set; }

        /// <summary>
        ///     Gets or sets the temporary folder path to store the files downloaded from the server.
        /// </summary>
        /// <value>Folder path.</value>
        public static string TempFolderPath
        {
            get { return _tempFolderPath; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _tempFolderPath = value;
                    return;
                }

                // create the directory if it does not exist
                if (!Directory.Exists(value))
                    Directory.CreateDirectory(value);

                // check if the path contains directory separator at the end
                if (value[value.Length - 1] == Path.DirectorySeparatorChar)
                    _tempFolderPath = value;
                else
                    _tempFolderPath = value + Path.DirectorySeparatorChar;
            }
        }

        /// <summary>
        ///     Gets or sets the username (HTTP basic authentication).
        /// </summary>
        /// <value>The username.</value>
        public static string Username { get; set; }

        /// <summary>
        ///     Returns a string with essential information for debugging.
        /// </summary>
        public static string ToDebugReport()
        {
            string report = "C# SDK (IO.Swagger) Debug Report:\n";
            report += "    OS: " + Environment.OSVersion + "\n";
            report += "    .NET Framework Version: " + Assembly
                          .GetExecutingAssembly()
                          .GetReferencedAssemblies()
                          .Where(x => x.Name == "System.Core").First().Version + "\n";
            report += "    Version of the API: 1.0.0\n";
            report += "    SDK Package Version: 1.0.0\n";

            return report;
        }
    }
}