﻿using System;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    /// <summary>
    /// An enhanced git commit containing links to additional resources
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class GitHubCommitStats
    {
        /// <summary>
        /// The number of additions made within the commit
        /// </summary>
        public int Additions { get; set; }

        /// <summary>
        /// The number of deletions made within the commit
        /// </summary>
        public int Deletions { get; set; }

        /// <summary>
        /// The total number of modifications within the commit
        /// </summary>
        public int Total { get; set; }

        internal string DebuggerDisplay
        {
            get
            {
                return String.Format(CultureInfo.InvariantCulture, "Stats: +{0} -{1} ={2}", Additions, Deletions, Total);
            }
        }
    }
}