FindsiClient.Net
==========

Specialized http client and a set of convenient extensions for communicating with the Findsi API

Findsi
-----------------
http://www.findsi.com
http://api.findsi.com/docs

Basic usage
-----------
At application startup (ie. `Main()` or `Application_Start()`) setup the `FindsiHalHttpClientFactory`:

```c#
// Create the default parser
IHalJsonParser parser = new HalJsonParser();

// Create the settings
var settings = new FindsiClientSettings {Key = Key, BaseAddress = _apiUri};

// Create the factory
IHalHttpClientWithRootFactory factory = new FindsiHalHttpClientFactory(parser, settings);
```

The factory is now ready for use and can be held, in your IoC container of choice, within singleton scope.

Within your code, you can now use the factory to create your clients as follows:

```c#
using (var client = _factory.CreateClientWithRoot())
{
	var resource = await client.ActorList();
	
	// do something with the retrieved data ...
}
```

Note that the client is disposable!

The object graph returned -- which is defined in the HalClient.Net library -- by the client is a generic representation of the object, that makes contained data elements easy to traverse/access. For convenience some extension methods have been added that simplify the projection of an `IResourceObject` into an `Identifier` or a `RankedIdentifier`.

```c#
var target = new Identifier { Id = "3717492", Classification = "article" };

using (var client = _factory.CreateClientWithRoot())
{
	var resource = await client.TargetDetail(target);
	var identifier = resource.AsIdentifier();
	
	// do something with the identifier ...
}
```

Work in progress
----------------
Fndsi is currently in beta, as such this library will inevitably change every time the API does.