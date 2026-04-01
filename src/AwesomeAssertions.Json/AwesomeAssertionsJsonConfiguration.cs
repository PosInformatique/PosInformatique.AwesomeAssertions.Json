//-----------------------------------------------------------------------
// <copyright file="AwesomeAssertionsJsonConfiguration.cs" company="P.O.S Informatique">
//     Copyright (c) P.O.S Informatique. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PosInformatique.AwesomeAssertions.Json
{
    using System.Text.Json;

    /// <summary>
    /// Default implementation of the <see cref="IAwesomeAssertionsJsonConfiguration"/>.
    /// </summary>
    internal sealed class AwesomeAssertionsJsonConfiguration : IAwesomeAssertionsJsonConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AwesomeAssertionsJsonConfiguration"/> class.
        /// </summary>
        public AwesomeAssertionsJsonConfiguration()
        {
            this.JsonSerializerOptions = new JsonSerializerOptions();
        }

        /// <inheritdoc />
        public JsonSerializerOptions JsonSerializerOptions { get; }
    }
}
