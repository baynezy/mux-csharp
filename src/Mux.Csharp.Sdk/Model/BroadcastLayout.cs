/*
 * Mux API
 *
 * Mux is how developers build online video. This API encompasses both Mux Video and Mux Data functionality to help you build your video-related projects better and faster than ever before.
 *
 * The version of the OpenAPI document: v1
 * Contact: devex@mux.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Mux.Csharp.Sdk.Client.OpenAPIDateConverter;

namespace Mux.Csharp.Sdk.Model
{
    /// <summary>
    /// The layout used when broadcasting the space. Defaults to &#x60;gallery&#x60; if not set.
    /// </summary>
    /// <value>The layout used when broadcasting the space. Defaults to &#x60;gallery&#x60; if not set.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BroadcastLayout
    {
        /// <summary>
        /// Enum Gallery for value: gallery
        /// </summary>
        [EnumMember(Value = "gallery")]
        Gallery = 1,

        /// <summary>
        /// Enum ActiveSpeaker for value: active-speaker
        /// </summary>
        [EnumMember(Value = "active-speaker")]
        ActiveSpeaker = 2

    }

}
