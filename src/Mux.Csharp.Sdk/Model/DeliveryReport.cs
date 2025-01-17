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
    /// DeliveryReport
    /// </summary>
    [DataContract(Name = "DeliveryReport")]
    public partial class DeliveryReport : IEquatable<DeliveryReport>, IValidatableObject
    {
        /// <summary>
        /// The state of the asset.
        /// </summary>
        /// <value>The state of the asset.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AssetStateEnum
        {
            /// <summary>
            /// Enum Ready for value: ready
            /// </summary>
            [EnumMember(Value = "ready")]
            Ready = 1,

            /// <summary>
            /// Enum Errored for value: errored
            /// </summary>
            [EnumMember(Value = "errored")]
            Errored = 2,

            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 3

        }


        /// <summary>
        /// The state of the asset.
        /// </summary>
        /// <value>The state of the asset.</value>
        [DataMember(Name = "asset_state", EmitDefaultValue = false)]
        public AssetStateEnum? AssetState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryReport" /> class.
        /// </summary>
        /// <param name="liveStreamId">Unique identifier for the live stream that created the asset..</param>
        /// <param name="assetId">Unique identifier for the asset..</param>
        /// <param name="passthrough">The &#x60;passthrough&#x60; value for the asset..</param>
        /// <param name="createdAt">Time at which the asset was created. Measured in seconds since the Unix epoch..</param>
        /// <param name="deletedAt">If exists, time at which the asset was deleted. Measured in seconds since the Unix epoch..</param>
        /// <param name="assetState">The state of the asset..</param>
        /// <param name="assetDuration">The duration of the asset in seconds..</param>
        /// <param name="deliveredSeconds">Total number of delivered seconds during this time window..</param>
        public DeliveryReport(string liveStreamId = default(string), string assetId = default(string), string passthrough = default(string), string createdAt = default(string), string deletedAt = default(string), AssetStateEnum? assetState = default(AssetStateEnum?), double assetDuration = default(double), double deliveredSeconds = default(double))
        {
            this.LiveStreamId = liveStreamId;
            this.AssetId = assetId;
            this.Passthrough = passthrough;
            this.CreatedAt = createdAt;
            this.DeletedAt = deletedAt;
            this.AssetState = assetState;
            this.AssetDuration = assetDuration;
            this.DeliveredSeconds = deliveredSeconds;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Unique identifier for the live stream that created the asset.
        /// </summary>
        /// <value>Unique identifier for the live stream that created the asset.</value>
        [DataMember(Name = "live_stream_id", EmitDefaultValue = false)]
        public string LiveStreamId { get; set; }

        /// <summary>
        /// Unique identifier for the asset.
        /// </summary>
        /// <value>Unique identifier for the asset.</value>
        [DataMember(Name = "asset_id", EmitDefaultValue = false)]
        public string AssetId { get; set; }

        /// <summary>
        /// The &#x60;passthrough&#x60; value for the asset.
        /// </summary>
        /// <value>The &#x60;passthrough&#x60; value for the asset.</value>
        [DataMember(Name = "passthrough", EmitDefaultValue = false)]
        public string Passthrough { get; set; }

        /// <summary>
        /// Time at which the asset was created. Measured in seconds since the Unix epoch.
        /// </summary>
        /// <value>Time at which the asset was created. Measured in seconds since the Unix epoch.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// If exists, time at which the asset was deleted. Measured in seconds since the Unix epoch.
        /// </summary>
        /// <value>If exists, time at which the asset was deleted. Measured in seconds since the Unix epoch.</value>
        [DataMember(Name = "deleted_at", EmitDefaultValue = false)]
        public string DeletedAt { get; set; }

        /// <summary>
        /// The duration of the asset in seconds.
        /// </summary>
        /// <value>The duration of the asset in seconds.</value>
        [DataMember(Name = "asset_duration", EmitDefaultValue = false)]
        public double AssetDuration { get; set; }

        /// <summary>
        /// Total number of delivered seconds during this time window.
        /// </summary>
        /// <value>Total number of delivered seconds during this time window.</value>
        [DataMember(Name = "delivered_seconds", EmitDefaultValue = false)]
        public double DeliveredSeconds { get; set; }

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
            sb.Append("class DeliveryReport {\n");
            sb.Append("  LiveStreamId: ").Append(LiveStreamId).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  Passthrough: ").Append(Passthrough).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  AssetState: ").Append(AssetState).Append("\n");
            sb.Append("  AssetDuration: ").Append(AssetDuration).Append("\n");
            sb.Append("  DeliveredSeconds: ").Append(DeliveredSeconds).Append("\n");
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
            return this.Equals(input as DeliveryReport);
        }

        /// <summary>
        /// Returns true if DeliveryReport instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryReport input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LiveStreamId == input.LiveStreamId ||
                    (this.LiveStreamId != null &&
                    this.LiveStreamId.Equals(input.LiveStreamId))
                ) && 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.Passthrough == input.Passthrough ||
                    (this.Passthrough != null &&
                    this.Passthrough.Equals(input.Passthrough))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
                ) && 
                (
                    this.AssetState == input.AssetState ||
                    this.AssetState.Equals(input.AssetState)
                ) && 
                (
                    this.AssetDuration == input.AssetDuration ||
                    this.AssetDuration.Equals(input.AssetDuration)
                ) && 
                (
                    this.DeliveredSeconds == input.DeliveredSeconds ||
                    this.DeliveredSeconds.Equals(input.DeliveredSeconds)
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
                if (this.LiveStreamId != null)
                {
                    hashCode = (hashCode * 59) + this.LiveStreamId.GetHashCode();
                }
                if (this.AssetId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                }
                if (this.Passthrough != null)
                {
                    hashCode = (hashCode * 59) + this.Passthrough.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.DeletedAt != null)
                {
                    hashCode = (hashCode * 59) + this.DeletedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AssetState.GetHashCode();
                hashCode = (hashCode * 59) + this.AssetDuration.GetHashCode();
                hashCode = (hashCode * 59) + this.DeliveredSeconds.GetHashCode();
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
            yield break;
        }
    }

}
