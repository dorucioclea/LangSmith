
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetTransformation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Path { get; set; }

        /// <summary>
        /// Enum for dataset data types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transformation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.DatasetTransformationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.DatasetTransformationType TransformationType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetTransformation" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="transformationType">
        /// Enum for dataset data types.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DatasetTransformation(
            global::System.Collections.Generic.IList<string> path,
            global::LangSmith.DatasetTransformationType transformationType)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.TransformationType = transformationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetTransformation" /> class.
        /// </summary>
        public DatasetTransformation()
        {
        }
    }
}