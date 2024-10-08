# Libravatar-sharp

Libravatar-sharp is a very simple library for producing libravatar URIs from user information, in a C# application.

## Synopsis

```cs
using Libravatar;

var uri = AvatarUri.FromEmail("someone@example.com");
var uri = AvatarUri.FromEmail("someone@example.com", new AvatarOptions {});
 
var uri = AvatarUri.FromOpenID("http://example.com/id/john");
var uri = AvatarUri.FromOpenID("http://example.com/id/john", new AvatarOptions {});
```

## Options

 AvatarOptions supports the following options:

- `PreferHTTPS`: Produce 'https://' URIs where possible, which is useful if including URIs in a page served via HTTPS. The default value is `false`.
- `UseSHA256`: Use the stronger SHA256 algorithm to hash the user's identity. This is harder to reverse, but breaks the fallback to Gravatar for missing images. When using OpenID identities, this flag is ignored, and SHA256 is used at all times. The default value is `false`.
- `DefaultImage`: A URI to an image to use if none is found, or one of the values in AvatarDefaultImages. Not all servers support all of the magic values, however. The default value is null.
- `Size`: The size of the image you want, in pixels. Valid values are between 1 and 512 pixels inclusive. The default value is 80 pixels.
- `BaseUri`: Set the base URI for the server you want to use. By default, this is: <http://cdn.libravatar.org/avatar/>

> If you don't like freedom, you could point this directly at Gravatar or something.

- `SecureBaseUri`: Set the base URI for the server you want to use for HTTPS links. By default, this is: <https://seccdn.libravatar.org/avatar/>

## Bugs

 The following would be nice, but are not yet supported:

- Federation via DNS SRV requests

## Author

 Chris Forbes <chrisf@ijw.co.nz>
