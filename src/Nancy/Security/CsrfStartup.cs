﻿namespace Nancy.Security
{
    using System;
    using Bootstrapper;
    using Cookies;
    using Cryptography;

    public class CsrfStartup : IStartup
    {
        public static CryptographyConfiguration CryptographyConfiguration { get; private set; }

        public static IObjectSerializer ObjectSerializer { get; private set; }

        public CsrfStartup(CryptographyConfiguration cryptographyConfiguration, IObjectSerializer objectSerializer)
        {
            CryptographyConfiguration = cryptographyConfiguration;
            ObjectSerializer = objectSerializer;
        }

        /// <summary>
        /// Perform any initialisation tasks
        /// </summary>
        public void Initialize()
        {
        }
    }
}