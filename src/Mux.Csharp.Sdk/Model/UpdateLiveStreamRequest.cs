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
    /// UpdateLiveStreamRequest
    /// </summary>
    [DataContract(Name = "UpdateLiveStreamRequest")]
    public partial class UpdateLiveStreamRequest : IEquatable<UpdateLiveStreamRequest>, IValidatableObject
    {
        /// <summary>
        /// Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Set this as an alternative to setting low latency or reduced latency flags. The Low Latency value is a beta feature. Read more here: https://mux.com/blog/introducing-low-latency-live-streaming/
        /// </summary>
        /// <value>Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Set this as an alternative to setting low latency or reduced latency flags. The Low Latency value is a beta feature. Read more here: https://mux.com/blog/introducing-low-latency-live-streaming/</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LatencyModeEnum
        {
            /// <summary>
            /// Enum Low for value: low
            /// </summary>
            [EnumMember(Value = "low")]
            Low = 1,

            /// <summary>
            /// Enum Reduced for value: reduced
            /// </summary>
            [EnumMember(Value = "reduced")]
            Reduced = 2,

            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 3

        }


        /// <summary>
        /// Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Set this as an alternative to setting low latency or reduced latency flags. The Low Latency value is a beta feature. Read more here: https://mux.com/blog/introducing-low-latency-live-streaming/
        /// </summary>
        /// <value>Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Set this as an alternative to setting low latency or reduced latency flags. The Low Latency value is a beta feature. Read more here: https://mux.com/blog/introducing-low-latency-live-streaming/</value>
        [DataMember(Name = "latency_mode", EmitDefaultValue = false)]
        public LatencyModeEnum? LatencyMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLiveStreamRequest" /> class.
        /// </summary>
        /// <param name="passthrough">Arbitrary user-supplied metadata set for the live stream. Max 255 characters. In order to clear this value, the field should be included with an empty-string value..</param>
        /// <param name="latencyMode">Latency is the time from when the streamer transmits a frame of video to when you see it in the player. Set this as an alternative to setting low latency or reduced latency flags. The Low Latency value is a beta feature. Read more here: https://mux.com/blog/introducing-low-latency-live-streaming/.</param>
        /// <param name="reconnectWindow">When live streaming software disconnects from Mux, either intentionally or due to a drop in the network, the Reconnect Window is the time in seconds that Mux should wait for the streaming software to reconnect before considering the live stream finished and completing the recorded asset.  Reduced and Low Latency streams with a Reconnect Window greater than zero will insert slate media into the recorded asset while waiting for the streaming software to reconnect or when there are brief interruptions in the live stream media. When using a Reconnect Window setting higher than 60 seconds with a Standard Latency stream, we highly recommend enabling slate with the &#x60;use_slate_for_standard_latency&#x60; option.  (default to 60F).</param>
        /// <param name="useSlateForStandardLatency">By default, Standard Latency live streams do not have slate media inserted while waiting for live streaming software to reconnect to Mux.  Setting this to true enables slate insertion on a Standard Latency stream. (default to false).</param>
        /// <param name="reconnectSlateUrl">The URL of the image file that Mux should download and use as slate media during interruptions of the live stream media.  This file will be downloaded each time a new recorded asset is created from the live stream.  Set this to a blank string to clear the value so that the default slate media will be used..</param>
        /// <param name="maxContinuousDuration">The time in seconds a live stream may be continuously active before being disconnected. Defaults to 12 hours. (default to 43200).</param>
        public UpdateLiveStreamRequest(string passthrough = default(string), LatencyModeEnum? latencyMode = default(LatencyModeEnum?), float reconnectWindow = 60F, bool useSlateForStandardLatency = false, string reconnectSlateUrl = default(string), int maxContinuousDuration = 43200)
        {
            this.Passthrough = passthrough;
            this.LatencyMode = latencyMode;
            this.ReconnectWindow = reconnectWindow;
            this.UseSlateForStandardLatency = useSlateForStandardLatency;
            this.ReconnectSlateUrl = reconnectSlateUrl;
            this.MaxContinuousDuration = maxContinuousDuration;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Arbitrary user-supplied metadata set for the live stream. Max 255 characters. In order to clear this value, the field should be included with an empty-string value.
        /// </summary>
        /// <value>Arbitrary user-supplied metadata set for the live stream. Max 255 characters. In order to clear this value, the field should be included with an empty-string value.</value>
        [DataMember(Name = "passthrough", EmitDefaultValue = false)]
        public string Passthrough { get; set; }

        /// <summary>
        /// When live streaming software disconnects from Mux, either intentionally or due to a drop in the network, the Reconnect Window is the time in seconds that Mux should wait for the streaming software to reconnect before considering the live stream finished and completing the recorded asset.  Reduced and Low Latency streams with a Reconnect Window greater than zero will insert slate media into the recorded asset while waiting for the streaming software to reconnect or when there are brief interruptions in the live stream media. When using a Reconnect Window setting higher than 60 seconds with a Standard Latency stream, we highly recommend enabling slate with the &#x60;use_slate_for_standard_latency&#x60; option. 
        /// </summary>
        /// <value>When live streaming software disconnects from Mux, either intentionally or due to a drop in the network, the Reconnect Window is the time in seconds that Mux should wait for the streaming software to reconnect before considering the live stream finished and completing the recorded asset.  Reduced and Low Latency streams with a Reconnect Window greater than zero will insert slate media into the recorded asset while waiting for the streaming software to reconnect or when there are brief interruptions in the live stream media. When using a Reconnect Window setting higher than 60 seconds with a Standard Latency stream, we highly recommend enabling slate with the &#x60;use_slate_for_standard_latency&#x60; option. </value>
        [DataMember(Name = "reconnect_window", EmitDefaultValue = false)]
        public float ReconnectWindow { get; set; }

        /// <summary>
        /// By default, Standard Latency live streams do not have slate media inserted while waiting for live streaming software to reconnect to Mux.  Setting this to true enables slate insertion on a Standard Latency stream.
        /// </summary>
        /// <value>By default, Standard Latency live streams do not have slate media inserted while waiting for live streaming software to reconnect to Mux.  Setting this to true enables slate insertion on a Standard Latency stream.</value>
        [DataMember(Name = "use_slate_for_standard_latency", EmitDefaultValue = true)]
        public bool UseSlateForStandardLatency { get; set; }

        /// <summary>
        /// The URL of the image file that Mux should download and use as slate media during interruptions of the live stream media.  This file will be downloaded each time a new recorded asset is created from the live stream.  Set this to a blank string to clear the value so that the default slate media will be used.
        /// </summary>
        /// <value>The URL of the image file that Mux should download and use as slate media during interruptions of the live stream media.  This file will be downloaded each time a new recorded asset is created from the live stream.  Set this to a blank string to clear the value so that the default slate media will be used.</value>
        [DataMember(Name = "reconnect_slate_url", EmitDefaultValue = false)]
        public string ReconnectSlateUrl { get; set; }

        /// <summary>
        /// The time in seconds a live stream may be continuously active before being disconnected. Defaults to 12 hours.
        /// </summary>
        /// <value>The time in seconds a live stream may be continuously active before being disconnected. Defaults to 12 hours.</value>
        [DataMember(Name = "max_continuous_duration", EmitDefaultValue = false)]
        public int MaxContinuousDuration { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateLiveStreamRequest {\n");
            sb.Append("  Passthrough: ").Append(Passthrough).Append("\n");
            sb.Append("  LatencyMode: ").Append(LatencyMode).Append("\n");
            sb.Append("  ReconnectWindow: ").Append(ReconnectWindow).Append("\n");
            sb.Append("  UseSlateForStandardLatency: ").Append(UseSlateForStandardLatency).Append("\n");
            sb.Append("  ReconnectSlateUrl: ").Append(ReconnectSlateUrl).Append("\n");
            sb.Append("  MaxContinuousDuration: ").Append(MaxContinuousDuration).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLiveStreamRequest);
        }

        /// <summary>
        /// Returns true if UpdateLiveStreamRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateLiveStreamRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateLiveStreamRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Passthrough == input.Passthrough ||
                    (this.Passthrough != null &&
                    this.Passthrough.Equals(input.Passthrough))
                ) && 
                (
                    this.LatencyMode == input.LatencyMode ||
                    this.LatencyMode.Equals(input.LatencyMode)
                ) && 
                (
                    this.ReconnectWindow == input.ReconnectWindow ||
                    this.ReconnectWindow.Equals(input.ReconnectWindow)
                ) && 
                (
                    this.UseSlateForStandardLatency == input.UseSlateForStandardLatency ||
                    this.UseSlateForStandardLatency.Equals(input.UseSlateForStandardLatency)
                ) && 
                (
                    this.ReconnectSlateUrl == input.ReconnectSlateUrl ||
                    (this.ReconnectSlateUrl != null &&
                    this.ReconnectSlateUrl.Equals(input.ReconnectSlateUrl))
                ) && 
                (
                    this.MaxContinuousDuration == input.MaxContinuousDuration ||
                    this.MaxContinuousDuration.Equals(input.MaxContinuousDuration)
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Passthrough != null)
                {
                    hashCode = (hashCode * 59) + this.Passthrough.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LatencyMode.GetHashCode();
                hashCode = (hashCode * 59) + this.ReconnectWindow.GetHashCode();
                hashCode = (hashCode * 59) + this.UseSlateForStandardLatency.GetHashCode();
                if (this.ReconnectSlateUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ReconnectSlateUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxContinuousDuration.GetHashCode();
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // ReconnectWindow (float) maximum
            if (this.ReconnectWindow > (float)1800)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReconnectWindow, must be a value less than or equal to 1800.", new [] { "ReconnectWindow" });
            }

            // ReconnectWindow (float) minimum
            if (this.ReconnectWindow < (float)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReconnectWindow, must be a value greater than or equal to 0.", new [] { "ReconnectWindow" });
            }

            // MaxContinuousDuration (int) maximum
            if (this.MaxContinuousDuration > (int)43200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxContinuousDuration, must be a value less than or equal to 43200.", new [] { "MaxContinuousDuration" });
            }

            // MaxContinuousDuration (int) minimum
            if (this.MaxContinuousDuration < (int)60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxContinuousDuration, must be a value greater than or equal to 60.", new [] { "MaxContinuousDuration" });
            }

            yield break;
        }
    }

}
