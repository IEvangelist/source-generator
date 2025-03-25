// Copyright (c) GitHub 2023-2025 - Licensed as MIT.

using Microsoft.Kiota.Abstractions.Authentication;

namespace GitHub.Octokit.Client.Authentication;

/// <summary>
/// Used for basic token authentication
/// </summary>
public class TokenProvider : IAccessTokenProvider
{
    private readonly string _accessToken;

    /// <inheritdoc cref="IAccessTokenProvider.AllowedHostsValidator" />
    AllowedHostsValidator IAccessTokenProvider.AllowedHostsValidator => new();

    /// <summary>
    /// Constructor for TokenProvider using the access token
    /// </summary>
    /// <param name="accessToken">The access token to be used for authentication.</param>
    /// <exception cref="ArgumentException">Thrown when the access token is null or empty.</exception>
    public TokenProvider(string accessToken)
    {
        ArgumentException.ThrowIfNullOrEmpty(accessToken, nameof(accessToken));

        _accessToken = accessToken;
    }

    /// <summary>
    /// Gets the authorization token.
    /// </summary>
    /// <param name="requestUri">The URI of the request.</param>
    /// <param name="additionalAuthenticationContext">Additional context for authentication.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the access token.</returns>
    public Task<string> GetAuthorizationTokenAsync(Uri requestUri, Dictionary<string, object>? additionalAuthenticationContext = default, CancellationToken cancellationToken = default) => Task.FromResult(_accessToken);
}
