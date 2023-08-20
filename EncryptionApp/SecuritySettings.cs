using System.Collections.Generic;

namespace EncryptionApp
{
    public class SecuritySettings : ISettings
    {
        /// <summary>
        /// Gets or sets an encryption key
        /// </summary>
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Gets or sets a list of system allowed IP addresses
        /// </summary>
        public List<string> SystemAllowedIpAddresses { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to allow non-ASCII characters in headers
        /// </summary>
        public bool AllowNonAsciiCharactersInHeaders { get; set; }
    }
}
