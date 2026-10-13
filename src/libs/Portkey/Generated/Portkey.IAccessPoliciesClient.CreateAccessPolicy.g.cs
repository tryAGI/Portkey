#nullable enable

namespace Portkey
{
    public partial interface IAccessPoliciesClient
    {
        /// <summary>
        /// Create Access Policy<br/>
        /// Create an access policy that allows or denies a set of subjects (users, groups, agents) access to a set of targets (MCP servers and providers) in a workspace.<br/>
        /// - `allow` policies must name at least one specific user, group, or agent.<br/>
        /// - When `effect` is omitted it is inferred: `deny` if `subjects` contains both a user `ANY` and an agent `ANY` entry, otherwise `allow`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateAccessPolicyResponse> CreateAccessPolicyAsync(

            global::Portkey.CreateAccessPolicyRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Access Policy<br/>
        /// Create an access policy that allows or denies a set of subjects (users, groups, agents) access to a set of targets (MCP servers and providers) in a workspace.<br/>
        /// - `allow` policies must name at least one specific user, group, or agent.<br/>
        /// - When `effect` is omitted it is inferred: `deny` if `subjects` contains both a user `ANY` and an agent `ANY` entry, otherwise `allow`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Portkey.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.AutoSDKHttpResponse<global::Portkey.CreateAccessPolicyResponse>> CreateAccessPolicyAsResponseAsync(

            global::Portkey.CreateAccessPolicyRequest request,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Access Policy<br/>
        /// Create an access policy that allows or denies a set of subjects (users, groups, agents) access to a set of targets (MCP servers and providers) in a workspace.<br/>
        /// - `allow` policies must name at least one specific user, group, or agent.<br/>
        /// - When `effect` is omitted it is inferred: `deny` if `subjects` contains both a user `ANY` and an agent `ANY` entry, otherwise `allow`.
        /// </summary>
        /// <param name="workspaceId">
        /// Workspace ID or slug. Required when using an organisation-level API key.
        /// </param>
        /// <param name="name">
        /// Unique within the workspace
        /// </param>
        /// <param name="description"></param>
        /// <param name="effect">
        /// Inferred when omitted (see endpoint description)
        /// </param>
        /// <param name="subjects"></param>
        /// <param name="targets"></param>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Portkey.CreateAccessPolicyResponse> CreateAccessPolicyAsync(
            string name,
            global::System.Collections.Generic.IList<global::Portkey.AccessPolicySubject> subjects,
            global::System.Collections.Generic.IList<global::Portkey.AccessPolicyTarget> targets,
            string? workspaceId = default,
            string? description = default,
            global::Portkey.CreateAccessPolicyRequestEffect? effect = default,
            bool? enabled = default,
            global::Portkey.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}