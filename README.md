# Symptom
Used for visual studio custom proxy, Team Explorer issue fix.
# CustomProxy
Corporate firewalls only allow traffic to go through proxy servers. It's shame that Visual Studio hasn't got the ability to specify that in the Tools -> Options area.
Enter your company credentials
Once you've compiled the dll copy it into Visual Studio IDE folder
```
%PROGRAMFILES\Microsoft Visual Studio 10.0\Common7\IDE
```
```xml
<system.net>
  <!--<defaultProxy enabled="true" useDefaultCredentials="false">  
  <proxy bypassonlocal="false" proxyaddress="12.34.56.78:8080"/>  
  </defaultProxy>-->
  <defaultProxy enabled="true">
    <module type="CustomProxy.ProxyAuthorisation, CustomProxy"/>
  </defaultProxy>
  <settings>
        <ipv6 enabled="true"/>
  </settings>
</system.net>
```
