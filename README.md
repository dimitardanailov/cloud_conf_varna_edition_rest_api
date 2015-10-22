# Cloud Conf Varna Edition 4

### Table of Contents
  1. [Security](#security)

### Security 

We will store all configuration in external files.

Our need to have `Security/AppSettingsSecrets.config`.

```xml
<appSettings> 
	
	<!-- MongoDB -->
	<add key="MongoDBServerLocation" value="MongodbLocation"/>
	<add key="MongoDBDatabase" value="DatabaseName"/>
	<!-- MongoDB -->
	  
</appSettings>
```

### Sources:
  1. [Best practices for deploying passwords and other sensitive data to ASP.NET and Azure App Service](http://www.asp.net/identity/overview/features-api/best-practices-for-deploying-passwords-and-other-sensitive-data-to-aspnet-and-azure)
  
**[⬆ back to top](#table-of-contents)**
