/*
 * Developer: Ramtin Jokar [ user@example.invalid ] [ My Telegram Account: https://t.me/ramtinak ]
 * 
 * Github source: https://github.com/ramtinak/InstagramApiSharp
 * Nuget package: https://www.nuget.org/packages/InstagramApiSharp
 * 
 * IRANIAN DEVELOPERS
 */

using InstagramApiSharp.Enums;
using System.Collections.Generic;
using System.Linq;

namespace InstagramApiSharp.API.Versions
{
    internal class InstaApiVersionList
    {
        public static InstaApiVersionList GetApiVersionList() => new InstaApiVersionList();

        public Dictionary<InstaApiVersionType, InstaApiVersion> ApiVersions()
        {
            return new Dictionary<InstaApiVersionType, InstaApiVersion>
            {
                {
                    InstaApiVersionType.Version35,
                    new InstaApiVersion
                    {
                         AppApiVersionCode = "95414346",
                         AppVersion = "35.0.0.20.96",
                         Capabilities = "3brTBw==",
                         SignatureKey = "REPLACE_WITH_YOUR_VALUE"
                    }
                },
                {
                    InstaApiVersionType.Version44,
                    new InstaApiVersion
                    {
                         AppApiVersionCode = "REPLACE_WITH_YOUR_VALUE",
                         AppVersion = "44.0.0.9.93",
                         Capabilities = "3brTPw==",
                         SignatureKey = "REPLACE_WITH_YOUR_VALUE"
                    }
                },
                {
                    InstaApiVersionType.Version61,
                    new InstaApiVersion
                    {
                         AppApiVersionCode = "REPLACE_WITH_YOUR_VALUE",
                         AppVersion = "61.0.0.19.86",
                         Capabilities = "3brTPw==",
                         SignatureKey = "REPLACE_WITH_YOUR_VALUE"
                    }
                },
                {
                    InstaApiVersionType.Version64,
                    new InstaApiVersion
                    {
                         AppApiVersionCode = "REPLACE_WITH_YOUR_VALUE",
                         AppVersion = "64.0.0.14.96",
                         Capabilities = "3brTvw==",
                         SignatureKey = "REPLACE_WITH_YOUR_VALUE"
                    }
                },
                {
                    InstaApiVersionType.Version74,
                    new InstaApiVersion
                    {
                         AppApiVersionCode = "REPLACE_WITH_YOUR_VALUE",
                         AppVersion = "74.0.0.21.99",
                         Capabilities = "3brTvw==",
                         SignatureKey = "REPLACE_WITH_YOUR_VALUE"
                    }
                },
                {
                    InstaApiVersionType.Version76,
                    new InstaApiVersion
                    {
                         AppApiVersionCode = "REPLACE_WITH_YOUR_VALUE",
                         AppVersion = "76.0.0.15.395",
                         Capabilities = "3brTvw==",
                         SignatureKey = "REPLACE_WITH_YOUR_VALUE"
                    }
                },
                {
                    InstaApiVersionType.Version86,
                    new InstaApiVersion
                    {
                         AppApiVersionCode = "REPLACE_WITH_YOUR_VALUE",
                         AppVersion = "86.0.0.24.87",
                         Capabilities = "3brTvw==",
                         SignatureKey = "REPLACE_WITH_YOUR_VALUE"
                    }
                },
                {
                    InstaApiVersionType.Version107,
                    new InstaApiVersion
                    {
                         AppApiVersionCode = "REPLACE_WITH_YOUR_VALUE",
                         AppVersion = "107.0.0.27.121",
                         Capabilities = "3brTvw==",
                         SignatureKey = "REPLACE_WITH_YOUR_VALUE"
                    }
                },
                {
                    InstaApiVersionType.Version126,
                    new InstaApiVersion
                    {
                         AppApiVersionCode = "REPLACE_WITH_YOUR_VALUE",
                         AppVersion = "126.0.0.25.121",
                         Capabilities = "3brTvwM=",
                         SignatureKey = "REPLACE_WITH_YOUR_VALUE",
                         BloksVersionId = "REPLACE_WITH_YOUR_VALUE"
                    }
                }
            };
        }

        public InstaApiVersion GetApiVersion(InstaApiVersionType versionType)
        {
            return (from apiVer in ApiVersions()
                    where apiVer.Key == versionType
                    select apiVer.Value).FirstOrDefault();
        }
    }
}
