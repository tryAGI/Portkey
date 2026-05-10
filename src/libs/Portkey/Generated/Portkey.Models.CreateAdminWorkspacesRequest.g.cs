
#nullable enable

namespace Portkey
{
    /// <summary>
    /// Example: {"name":"My Workspace","description":"My Description","defaults":{"metadata":{"environment":"production","foo":"bar"}}}
    /// </summary>
    public sealed partial class CreateAdminWorkspacesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaults")]
        public global::Portkey.CreateAdminWorkspacesRequestDefaults? Defaults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<string>? Users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_limits")]
        public global::System.Collections.Generic.IList<global::Portkey.UsageLimits>? UsageLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limits")]
        public global::System.Collections.Generic.IList<global::Portkey.RateLimits>? RateLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminWorkspacesRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaults"></param>
        /// <param name="users"></param>
        /// <param name="usageLimits"></param>
        /// <param name="rateLimits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAdminWorkspacesRequest(
            string? name,
            string? description,
            global::Portkey.CreateAdminWorkspacesRequestDefaults? defaults,
            global::System.Collections.Generic.IList<string>? users,
            global::System.Collections.Generic.IList<global::Portkey.UsageLimits>? usageLimits,
            global::System.Collections.Generic.IList<global::Portkey.RateLimits>? rateLimits)
        {
            this.Name = name;
            this.Description = description;
            this.Defaults = defaults;
            this.Users = users;
            this.UsageLimits = usageLimits;
            this.RateLimits = rateLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminWorkspacesRequest" /> class.
        /// </summary>
        public CreateAdminWorkspacesRequest()
        {
        }

    }
}