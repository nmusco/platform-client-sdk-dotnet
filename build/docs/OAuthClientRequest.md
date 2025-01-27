---
title: OAuthClientRequest
---
## ININ.PureCloudApi.Model.OAuthClientRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of the OAuth client. | |
| **AccessTokenValiditySeconds** | **long?** | The number of seconds, between 5mins and 48hrs, until tokens created with this client expire. If this field is omitted, a default of 24 hours will be applied. | [optional] |
| **Description** | **string** |  | [optional] |
| **RegisteredRedirectUri** | **List&lt;string&gt;** | List of allowed callbacks for this client. For example: https://myap.example.com/auth/callback | [optional] |
| **RoleIds** | **List&lt;string&gt;** | Deprecated. Use roleDivisions instead. | [optional] |
| **AuthorizedGrantType** | **string** | The OAuth Grant/Client type supported by this client. Code Authorization Grant/Client type - Preferred client type where the Client ID and Secret are required to create tokens. Used where the secret can be secured. Implicit grant type - Client ID only is required to create tokens. Used in browser and mobile apps where the secret can not be secured. SAML2-Bearer extension grant type - SAML2 assertion provider for user authentication at the token endpoint. Client Credential grant type - Used to created access tokens that are tied only to the client.  | |
| **Scope** | **List&lt;string&gt;** | The scope requested by this client. Scopes only apply to clients not using the client_credential grant | [optional] |
| **RoleDivisions** | [**List&lt;RoleDivision&gt;**](RoleDivision.html) | Set of roles and their corresponding divisions associated with this client. Roles and divisions only apply to clients using the client_credential grant | [optional] |
{: class="table table-striped"}


