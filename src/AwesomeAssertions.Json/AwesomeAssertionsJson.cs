//-----------------------------------------------------------------------
// <copyright file="AwesomeAssertionsJson.cs" company="P.O.S Informatique">
//     Copyright (c) P.O.S Informatique. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PosInformatique.AwesomeAssertions.Json
{
    /// <summary>
    /// Allows to access to the configuration of <c>PosInformatique.AwesomeAssertions.Json</c> library.
    /// </summary>
    public static class AwesomeAssertionsJson
    {
        /// <summary>
        /// Gets the <see cref="IAwesomeAssertionsJsonConfiguration"/> instance which allows to configure the
        /// <c>PosInformatique.AwesomeAssertions.Json</c> library.
        /// </summary>
        public static IAwesomeAssertionsJsonConfiguration Configuration { get; internal set; } = new AwesomeAssertionsJsonConfiguration();
    }
}
