# Org.OpenAPITools.Api.DefaultApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppControllerCreate**](DefaultApi.md#appcontrollercreate) | **POST** /point-event | 
[**AppControllerDashboard**](DefaultApi.md#appcontrollerdashboard) | **GET** / | 
[**AppControllerFacebookConnect**](DefaultApi.md#appcontrollerfacebookconnect) | **GET** /connect/facebook | 
[**AppControllerFacebookConnectRedirect**](DefaultApi.md#appcontrollerfacebookconnectredirect) | **GET** /callback/facebook/connect | 
[**AppControllerFacebookLogin**](DefaultApi.md#appcontrollerfacebooklogin) | **GET** /login/facebook | 
[**AppControllerFacebookLoginRedirect**](DefaultApi.md#appcontrollerfacebookloginredirect) | **GET** /callback/facebook/login | 
[**AppControllerInstagramConnect**](DefaultApi.md#appcontrollerinstagramconnect) | **GET** /connect/instagram | 
[**AppControllerInstagramConnectRedirect**](DefaultApi.md#appcontrollerinstagramconnectredirect) | **GET** /callback/instagram/connect | 
[**AppControllerInstagramLogin**](DefaultApi.md#appcontrollerinstagramlogin) | **GET** /login/instagram | 
[**AppControllerInstagramLoginRedirect**](DefaultApi.md#appcontrollerinstagramloginredirect) | **GET** /callback/instagram/login | 
[**AppControllerLanding**](DefaultApi.md#appcontrollerlanding) | **GET** /landing | 
[**AppControllerLoginWithClientCredentials**](DefaultApi.md#appcontrollerloginwithclientcredentials) | **POST** /oauth/token | 
[**AppControllerLogout**](DefaultApi.md#appcontrollerlogout) | **GET** /logout | 
[**AppControllerPointBadge**](DefaultApi.md#appcontrollerpointbadge) | **GET** /point-badge | 
[**AppControllerSse**](DefaultApi.md#appcontrollersse) | **GET** /sse | 
[**AppControllerTwitterConnect**](DefaultApi.md#appcontrollertwitterconnect) | **GET** /connect/twitter | 
[**AppControllerTwitterConnectRedirect**](DefaultApi.md#appcontrollertwitterconnectredirect) | **GET** /callback/twitter/connect | 
[**AppControllerTwitterLogin**](DefaultApi.md#appcontrollertwitterlogin) | **GET** /login/twitter | 
[**AppControllerTwitterLoginRedirect**](DefaultApi.md#appcontrollertwitterloginredirect) | **GET** /callback/twitter/login | 
[**EmailTemplateControllerCreate**](DefaultApi.md#emailtemplatecontrollercreate) | **POST** /email-template/{key} | 
[**EmailTemplateControllerFindOne**](DefaultApi.md#emailtemplatecontrollerfindone) | **GET** /email-template/{key} | 
[**EmailTemplateControllerIndex**](DefaultApi.md#emailtemplatecontrollerindex) | **GET** /email-template | 
[**EmailTemplateControllerLoginForm**](DefaultApi.md#emailtemplatecontrollerloginform) | **GET** /email-template/login | 
[**EmailTemplateControllerProcessLogin**](DefaultApi.md#emailtemplatecontrollerprocesslogin) | **POST** /email-template | 
[**PlatformConnectionControllerCreate**](DefaultApi.md#platformconnectioncontrollercreate) | **POST** /platform-connection | 
[**PlatformConnectionControllerFindAll**](DefaultApi.md#platformconnectioncontrollerfindall) | **GET** /platform-connection | 
[**PlatformConnectionControllerFindOne**](DefaultApi.md#platformconnectioncontrollerfindone) | **GET** /platform-connection/{id} | 
[**PlatformConnectionControllerRemove**](DefaultApi.md#platformconnectioncontrollerremove) | **DELETE** /platform-connection/{id} | 
[**PlatformConnectionControllerUpdate**](DefaultApi.md#platformconnectioncontrollerupdate) | **PATCH** /platform-connection/{id} | 
[**PointEventControllerFindAll**](DefaultApi.md#pointeventcontrollerfindall) | **GET** /point-event | 
[**PointEventControllerFindOne**](DefaultApi.md#pointeventcontrollerfindone) | **GET** /point-event/{id} | 
[**PointEventControllerRemove**](DefaultApi.md#pointeventcontrollerremove) | **DELETE** /point-event/{id} | 
[**PointEventControllerUpdate**](DefaultApi.md#pointeventcontrollerupdate) | **PATCH** /point-event/{id} | 
[**UserControllerCreate**](DefaultApi.md#usercontrollercreate) | **POST** /user | 
[**UserControllerFindOne**](DefaultApi.md#usercontrollerfindone) | **GET** /user/{id} | 
[**UserControllerFindOneByEmail**](DefaultApi.md#usercontrollerfindonebyemail) | **GET** /user/byEmail/{email} | 
[**UserControllerRemove**](DefaultApi.md#usercontrollerremove) | **DELETE** /user/{id} | 
[**UserControllerUpdate**](DefaultApi.md#usercontrollerupdate) | **PATCH** /user/{id} | 


<a name="appcontrollercreate"></a>
# **AppControllerCreate**
> CreatePointEventResponseDto AppControllerCreate (CreatePointEventDto createPointEventDto)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi(config);
            var createPointEventDto = new CreatePointEventDto(); // CreatePointEventDto | 

            try
            {
                CreatePointEventResponseDto result = apiInstance.AppControllerCreate(createPointEventDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createPointEventDto** | [**CreatePointEventDto**](CreatePointEventDto.md)|  | 

### Return type

[**CreatePointEventResponseDto**](CreatePointEventResponseDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollerdashboard"></a>
# **AppControllerDashboard**
> void AppControllerDashboard ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerDashboardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerDashboard();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerDashboard: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollerfacebookconnect"></a>
# **AppControllerFacebookConnect**
> void AppControllerFacebookConnect ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerFacebookConnectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerFacebookConnect();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerFacebookConnect: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollerfacebookconnectredirect"></a>
# **AppControllerFacebookConnectRedirect**
> void AppControllerFacebookConnectRedirect ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerFacebookConnectRedirectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerFacebookConnectRedirect();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerFacebookConnectRedirect: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollerfacebooklogin"></a>
# **AppControllerFacebookLogin**
> void AppControllerFacebookLogin ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerFacebookLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerFacebookLogin();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerFacebookLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollerfacebookloginredirect"></a>
# **AppControllerFacebookLoginRedirect**
> void AppControllerFacebookLoginRedirect ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerFacebookLoginRedirectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerFacebookLoginRedirect();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerFacebookLoginRedirect: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollerinstagramconnect"></a>
# **AppControllerInstagramConnect**
> void AppControllerInstagramConnect ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerInstagramConnectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerInstagramConnect();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerInstagramConnect: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollerinstagramconnectredirect"></a>
# **AppControllerInstagramConnectRedirect**
> void AppControllerInstagramConnectRedirect ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerInstagramConnectRedirectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerInstagramConnectRedirect();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerInstagramConnectRedirect: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollerinstagramlogin"></a>
# **AppControllerInstagramLogin**
> void AppControllerInstagramLogin ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerInstagramLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerInstagramLogin();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerInstagramLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollerinstagramloginredirect"></a>
# **AppControllerInstagramLoginRedirect**
> void AppControllerInstagramLoginRedirect ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerInstagramLoginRedirectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerInstagramLoginRedirect();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerInstagramLoginRedirect: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollerlanding"></a>
# **AppControllerLanding**
> void AppControllerLanding ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerLandingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerLanding();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerLanding: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollerloginwithclientcredentials"></a>
# **AppControllerLoginWithClientCredentials**
> ClientCredentialsResponseDto AppControllerLoginWithClientCredentials (ClientCredentialsDto clientCredentialsDto)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerLoginWithClientCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var clientCredentialsDto = new ClientCredentialsDto(); // ClientCredentialsDto | 

            try
            {
                ClientCredentialsResponseDto result = apiInstance.AppControllerLoginWithClientCredentials(clientCredentialsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerLoginWithClientCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientCredentialsDto** | [**ClientCredentialsDto**](ClientCredentialsDto.md)|  | 

### Return type

[**ClientCredentialsResponseDto**](ClientCredentialsResponseDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollerlogout"></a>
# **AppControllerLogout**
> void AppControllerLogout ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerLogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerLogout();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerLogout: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollerpointbadge"></a>
# **AppControllerPointBadge**
> void AppControllerPointBadge ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerPointBadgeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerPointBadge();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerPointBadge: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollersse"></a>
# **AppControllerSse**
> void AppControllerSse ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerSseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerSse();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerSse: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollertwitterconnect"></a>
# **AppControllerTwitterConnect**
> void AppControllerTwitterConnect ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerTwitterConnectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerTwitterConnect();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerTwitterConnect: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollertwitterconnectredirect"></a>
# **AppControllerTwitterConnectRedirect**
> void AppControllerTwitterConnectRedirect ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerTwitterConnectRedirectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerTwitterConnectRedirect();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerTwitterConnectRedirect: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollertwitterlogin"></a>
# **AppControllerTwitterLogin**
> void AppControllerTwitterLogin ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerTwitterLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerTwitterLogin();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerTwitterLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appcontrollertwitterloginredirect"></a>
# **AppControllerTwitterLoginRedirect**
> void AppControllerTwitterLoginRedirect ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppControllerTwitterLoginRedirectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.AppControllerTwitterLoginRedirect();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerTwitterLoginRedirect: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailtemplatecontrollercreate"></a>
# **EmailTemplateControllerCreate**
> void EmailTemplateControllerCreate (string key, Object body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EmailTemplateControllerCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var key = "key_example";  // string | 
            var body = null;  // Object | 

            try
            {
                apiInstance.EmailTemplateControllerCreate(key, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EmailTemplateControllerCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**|  | 
 **body** | **Object**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailtemplatecontrollerfindone"></a>
# **EmailTemplateControllerFindOne**
> void EmailTemplateControllerFindOne (string key)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EmailTemplateControllerFindOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var key = "key_example";  // string | 

            try
            {
                apiInstance.EmailTemplateControllerFindOne(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EmailTemplateControllerFindOne: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailtemplatecontrollerindex"></a>
# **EmailTemplateControllerIndex**
> void EmailTemplateControllerIndex ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EmailTemplateControllerIndexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.EmailTemplateControllerIndex();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EmailTemplateControllerIndex: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailtemplatecontrollerloginform"></a>
# **EmailTemplateControllerLoginForm**
> void EmailTemplateControllerLoginForm ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EmailTemplateControllerLoginFormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.EmailTemplateControllerLoginForm();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EmailTemplateControllerLoginForm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailtemplatecontrollerprocesslogin"></a>
# **EmailTemplateControllerProcessLogin**
> void EmailTemplateControllerProcessLogin ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EmailTemplateControllerProcessLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.EmailTemplateControllerProcessLogin();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EmailTemplateControllerProcessLogin: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="platformconnectioncontrollercreate"></a>
# **PlatformConnectionControllerCreate**
> void PlatformConnectionControllerCreate (Object body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PlatformConnectionControllerCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var body = null;  // Object | 

            try
            {
                apiInstance.PlatformConnectionControllerCreate(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PlatformConnectionControllerCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **Object**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="platformconnectioncontrollerfindall"></a>
# **PlatformConnectionControllerFindAll**
> void PlatformConnectionControllerFindAll ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PlatformConnectionControllerFindAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.PlatformConnectionControllerFindAll();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PlatformConnectionControllerFindAll: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="platformconnectioncontrollerfindone"></a>
# **PlatformConnectionControllerFindOne**
> void PlatformConnectionControllerFindOne (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PlatformConnectionControllerFindOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                apiInstance.PlatformConnectionControllerFindOne(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PlatformConnectionControllerFindOne: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="platformconnectioncontrollerremove"></a>
# **PlatformConnectionControllerRemove**
> void PlatformConnectionControllerRemove (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PlatformConnectionControllerRemoveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                apiInstance.PlatformConnectionControllerRemove(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PlatformConnectionControllerRemove: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="platformconnectioncontrollerupdate"></a>
# **PlatformConnectionControllerUpdate**
> void PlatformConnectionControllerUpdate (string id, Object body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PlatformConnectionControllerUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 
            var body = null;  // Object | 

            try
            {
                apiInstance.PlatformConnectionControllerUpdate(id, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PlatformConnectionControllerUpdate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | **Object**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pointeventcontrollerfindall"></a>
# **PointEventControllerFindAll**
> void PointEventControllerFindAll ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PointEventControllerFindAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.PointEventControllerFindAll();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PointEventControllerFindAll: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pointeventcontrollerfindone"></a>
# **PointEventControllerFindOne**
> void PointEventControllerFindOne (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PointEventControllerFindOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                apiInstance.PointEventControllerFindOne(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PointEventControllerFindOne: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pointeventcontrollerremove"></a>
# **PointEventControllerRemove**
> void PointEventControllerRemove (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PointEventControllerRemoveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                apiInstance.PointEventControllerRemove(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PointEventControllerRemove: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pointeventcontrollerupdate"></a>
# **PointEventControllerUpdate**
> void PointEventControllerUpdate (string id, UpdatePointEventDto updatePointEventDto)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PointEventControllerUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 
            var updatePointEventDto = new UpdatePointEventDto(); // UpdatePointEventDto | 

            try
            {
                apiInstance.PointEventControllerUpdate(id, updatePointEventDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PointEventControllerUpdate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **updatePointEventDto** | [**UpdatePointEventDto**](UpdatePointEventDto.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usercontrollercreate"></a>
# **UserControllerCreate**
> void UserControllerCreate (Object body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserControllerCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var body = null;  // Object | 

            try
            {
                apiInstance.UserControllerCreate(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UserControllerCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **Object**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usercontrollerfindone"></a>
# **UserControllerFindOne**
> void UserControllerFindOne (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserControllerFindOneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                apiInstance.UserControllerFindOne(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UserControllerFindOne: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usercontrollerfindonebyemail"></a>
# **UserControllerFindOneByEmail**
> void UserControllerFindOneByEmail (string email)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserControllerFindOneByEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var email = "email_example";  // string | 

            try
            {
                apiInstance.UserControllerFindOneByEmail(email);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UserControllerFindOneByEmail: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usercontrollerremove"></a>
# **UserControllerRemove**
> void UserControllerRemove (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserControllerRemoveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                apiInstance.UserControllerRemove(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UserControllerRemove: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usercontrollerupdate"></a>
# **UserControllerUpdate**
> void UserControllerUpdate (string id, Object body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserControllerUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 
            var body = null;  // Object | 

            try
            {
                apiInstance.UserControllerUpdate(id, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UserControllerUpdate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | **Object**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

