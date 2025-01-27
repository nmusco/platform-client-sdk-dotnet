---
title: MessagingApi
---
## PureCloudPlatform.Client.V2.Api.MessagingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteMessagingIntegrationsFacebookIntegrationId**](MessagingApi.html#deletemessagingintegrationsfacebookintegrationid) | **DELETE** /api/v2/messaging/integrations/facebook/{integrationId} | Delete a Facebook messaging integration |
| [**DeleteMessagingIntegrationsLineIntegrationId**](MessagingApi.html#deletemessagingintegrationslineintegrationid) | **DELETE** /api/v2/messaging/integrations/line/{integrationId} | Delete a LINE messenger integration |
| [**DeleteMessagingIntegrationsTwitterIntegrationId**](MessagingApi.html#deletemessagingintegrationstwitterintegrationid) | **DELETE** /api/v2/messaging/integrations/twitter/{integrationId} | Delete a Twitter messaging integration |
| [**GetMessagingIntegrations**](MessagingApi.html#getmessagingintegrations) | **GET** /api/v2/messaging/integrations | Get a list of Integrations |
| [**GetMessagingIntegrationsFacebook**](MessagingApi.html#getmessagingintegrationsfacebook) | **GET** /api/v2/messaging/integrations/facebook | Get a list of Facebook Integrations |
| [**GetMessagingIntegrationsFacebookIntegrationId**](MessagingApi.html#getmessagingintegrationsfacebookintegrationid) | **GET** /api/v2/messaging/integrations/facebook/{integrationId} | Get a Facebook messaging integration |
| [**GetMessagingIntegrationsLine**](MessagingApi.html#getmessagingintegrationsline) | **GET** /api/v2/messaging/integrations/line | Get a list of LINE messenger Integrations |
| [**GetMessagingIntegrationsLineIntegrationId**](MessagingApi.html#getmessagingintegrationslineintegrationid) | **GET** /api/v2/messaging/integrations/line/{integrationId} | Get a LINE messenger integration |
| [**GetMessagingIntegrationsTwitter**](MessagingApi.html#getmessagingintegrationstwitter) | **GET** /api/v2/messaging/integrations/twitter | Get a list of Twitter Integrations |
| [**GetMessagingIntegrationsTwitterIntegrationId**](MessagingApi.html#getmessagingintegrationstwitterintegrationid) | **GET** /api/v2/messaging/integrations/twitter/{integrationId} | Get a Twitter messaging integration |
| [**GetMessagingSticker**](MessagingApi.html#getmessagingsticker) | **GET** /api/v2/messaging/stickers/{messengerType} | Get a list of Messaging Stickers |
| [**PostMessagingIntegrationsFacebook**](MessagingApi.html#postmessagingintegrationsfacebook) | **POST** /api/v2/messaging/integrations/facebook | Create a Facebook Integration |
| [**PostMessagingIntegrationsLine**](MessagingApi.html#postmessagingintegrationsline) | **POST** /api/v2/messaging/integrations/line | Create a LINE messenger Integration |
| [**PostMessagingIntegrationsTwitter**](MessagingApi.html#postmessagingintegrationstwitter) | **POST** /api/v2/messaging/integrations/twitter | Create a Twitter Integration |
| [**PutMessagingIntegrationsLineIntegrationId**](MessagingApi.html#putmessagingintegrationslineintegrationid) | **PUT** /api/v2/messaging/integrations/line/{integrationId} | Update a LINE messenger integration |
{: class="table table-striped"}

<a name="deletemessagingintegrationsfacebookintegrationid"></a>

## void DeleteMessagingIntegrationsFacebookIntegrationId (string integrationId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Delete a Facebook messaging integration



Requires ANY permissions: 

* messaging:integration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteMessagingIntegrationsFacebookIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Delete a Facebook messaging integration
                apiInstance.DeleteMessagingIntegrationsFacebookIntegrationId(integrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.DeleteMessagingIntegrationsFacebookIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletemessagingintegrationslineintegrationid"></a>

## void DeleteMessagingIntegrationsLineIntegrationId (string integrationId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Delete a LINE messenger integration



Requires ANY permissions: 

* messaging:integration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteMessagingIntegrationsLineIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Delete a LINE messenger integration
                apiInstance.DeleteMessagingIntegrationsLineIntegrationId(integrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.DeleteMessagingIntegrationsLineIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletemessagingintegrationstwitterintegrationid"></a>

## void DeleteMessagingIntegrationsTwitterIntegrationId (string integrationId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Delete a Twitter messaging integration



Requires ANY permissions: 

* messaging:integration:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteMessagingIntegrationsTwitterIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Delete a Twitter messaging integration
                apiInstance.DeleteMessagingIntegrationsTwitterIntegrationId(integrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.DeleteMessagingIntegrationsTwitterIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getmessagingintegrations"></a>

## [**MessagingIntegrationEntityListing**](MessagingIntegrationEntityListing.html) GetMessagingIntegrations (int? pageSize = null, int? pageNumber = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get a list of Integrations



Requires ANY permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetMessagingIntegrationsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of Integrations
                MessagingIntegrationEntityListing result = apiInstance.GetMessagingIntegrations(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingIntegrations: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**MessagingIntegrationEntityListing**](MessagingIntegrationEntityListing.html)

<a name="getmessagingintegrationsfacebook"></a>

## [**FacebookIntegrationEntityListing**](FacebookIntegrationEntityListing.html) GetMessagingIntegrationsFacebook (int? pageSize = null, int? pageNumber = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get a list of Facebook Integrations



Requires ANY permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetMessagingIntegrationsFacebookExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of Facebook Integrations
                FacebookIntegrationEntityListing result = apiInstance.GetMessagingIntegrationsFacebook(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingIntegrationsFacebook: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**FacebookIntegrationEntityListing**](FacebookIntegrationEntityListing.html)

<a name="getmessagingintegrationsfacebookintegrationid"></a>

## [**FacebookIntegration**](FacebookIntegration.html) GetMessagingIntegrationsFacebookIntegrationId (string integrationId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get a Facebook messaging integration



Requires ANY permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetMessagingIntegrationsFacebookIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Get a Facebook messaging integration
                FacebookIntegration result = apiInstance.GetMessagingIntegrationsFacebookIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingIntegrationsFacebookIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
{: class="table table-striped"}

### Return type

[**FacebookIntegration**](FacebookIntegration.html)

<a name="getmessagingintegrationsline"></a>

## [**LineIntegrationEntityListing**](LineIntegrationEntityListing.html) GetMessagingIntegrationsLine (int? pageSize = null, int? pageNumber = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get a list of LINE messenger Integrations



Requires ANY permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetMessagingIntegrationsLineExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of LINE messenger Integrations
                LineIntegrationEntityListing result = apiInstance.GetMessagingIntegrationsLine(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingIntegrationsLine: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**LineIntegrationEntityListing**](LineIntegrationEntityListing.html)

<a name="getmessagingintegrationslineintegrationid"></a>

## [**LineIntegration**](LineIntegration.html) GetMessagingIntegrationsLineIntegrationId (string integrationId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get a LINE messenger integration



Requires ANY permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetMessagingIntegrationsLineIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Get a LINE messenger integration
                LineIntegration result = apiInstance.GetMessagingIntegrationsLineIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingIntegrationsLineIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
{: class="table table-striped"}

### Return type

[**LineIntegration**](LineIntegration.html)

<a name="getmessagingintegrationstwitter"></a>

## [**TwitterIntegrationEntityListing**](TwitterIntegrationEntityListing.html) GetMessagingIntegrationsTwitter (int? pageSize = null, int? pageNumber = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get a list of Twitter Integrations



Requires ANY permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetMessagingIntegrationsTwitterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of Twitter Integrations
                TwitterIntegrationEntityListing result = apiInstance.GetMessagingIntegrationsTwitter(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingIntegrationsTwitter: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TwitterIntegrationEntityListing**](TwitterIntegrationEntityListing.html)

<a name="getmessagingintegrationstwitterintegrationid"></a>

## [**TwitterIntegration**](TwitterIntegration.html) GetMessagingIntegrationsTwitterIntegrationId (string integrationId)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get a Twitter messaging integration



Requires ANY permissions: 

* messaging:integration:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetMessagingIntegrationsTwitterIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var integrationId = integrationId_example;  // string | Integration ID

            try
            { 
                // Get a Twitter messaging integration
                TwitterIntegration result = apiInstance.GetMessagingIntegrationsTwitterIntegrationId(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingIntegrationsTwitterIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
{: class="table table-striped"}

### Return type

[**TwitterIntegration**](TwitterIntegration.html)

<a name="getmessagingsticker"></a>

## [**MessagingStickerEntityListing**](MessagingStickerEntityListing.html) GetMessagingSticker (string messengerType, int? pageSize = null, int? pageNumber = null)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Get a list of Messaging Stickers



Requires ANY permissions: 

* conversation:message:create

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetMessagingStickerExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var messengerType = messengerType_example;  // string | Messenger Type
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            { 
                // Get a list of Messaging Stickers
                MessagingStickerEntityListing result = apiInstance.GetMessagingSticker(messengerType, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessagingSticker: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messengerType** | **string**| Messenger Type |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**MessagingStickerEntityListing**](MessagingStickerEntityListing.html)

<a name="postmessagingintegrationsfacebook"></a>

## [**FacebookIntegration**](FacebookIntegration.html) PostMessagingIntegrationsFacebook (FacebookIntegrationRequest body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Create a Facebook Integration



Requires ANY permissions: 

* messaging:integration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostMessagingIntegrationsFacebookExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var body = new FacebookIntegrationRequest(); // FacebookIntegrationRequest | FacebookIntegrationRequest

            try
            { 
                // Create a Facebook Integration
                FacebookIntegration result = apiInstance.PostMessagingIntegrationsFacebook(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.PostMessagingIntegrationsFacebook: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FacebookIntegrationRequest**](FacebookIntegrationRequest.html)| FacebookIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**FacebookIntegration**](FacebookIntegration.html)

<a name="postmessagingintegrationsline"></a>

## [**LineIntegration**](LineIntegration.html) PostMessagingIntegrationsLine (LineIntegrationRequest body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Create a LINE messenger Integration



Requires ANY permissions: 

* messaging:integration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostMessagingIntegrationsLineExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var body = new LineIntegrationRequest(); // LineIntegrationRequest | LineIntegrationRequest

            try
            { 
                // Create a LINE messenger Integration
                LineIntegration result = apiInstance.PostMessagingIntegrationsLine(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.PostMessagingIntegrationsLine: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LineIntegrationRequest**](LineIntegrationRequest.html)| LineIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**LineIntegration**](LineIntegration.html)

<a name="postmessagingintegrationstwitter"></a>

## [**TwitterIntegration**](TwitterIntegration.html) PostMessagingIntegrationsTwitter (TwitterIntegrationRequest body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Create a Twitter Integration



Requires ANY permissions: 

* messaging:integration:add

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostMessagingIntegrationsTwitterExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var body = new TwitterIntegrationRequest(); // TwitterIntegrationRequest | TwitterIntegrationRequest

            try
            { 
                // Create a Twitter Integration
                TwitterIntegration result = apiInstance.PostMessagingIntegrationsTwitter(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.PostMessagingIntegrationsTwitter: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TwitterIntegrationRequest**](TwitterIntegrationRequest.html)| TwitterIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**TwitterIntegration**](TwitterIntegration.html)

<a name="putmessagingintegrationslineintegrationid"></a>

## [**LineIntegration**](LineIntegration.html) PutMessagingIntegrationsLineIntegrationId (string integrationId, LineIntegrationRequest body)

<span style="background-color: #f0ad4e;display: inline-block;padding: 7px;font-weight: bold;line-height: 1;color: #ffffff;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: .25em;margin: 10px 0;">DEPRECATED</span>

Update a LINE messenger integration



Requires ANY permissions: 

* messaging:integration:edit

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PutMessagingIntegrationsLineIntegrationIdExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var integrationId = integrationId_example;  // string | Integration ID
            var body = new LineIntegrationRequest(); // LineIntegrationRequest | LineIntegrationRequest

            try
            { 
                // Update a LINE messenger integration
                LineIntegration result = apiInstance.PutMessagingIntegrationsLineIntegrationId(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.PutMessagingIntegrationsLineIntegrationId: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **integrationId** | **string**| Integration ID |  |
| **body** | [**LineIntegrationRequest**](LineIntegrationRequest.html)| LineIntegrationRequest |  |
{: class="table table-striped"}

### Return type

[**LineIntegration**](LineIntegration.html)

