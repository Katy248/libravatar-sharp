using System;
using LibravatarSharp;

//const string email = "chrisf@ijw.co.nz";
const string email = "petrovanton247@gmail.com";

// 1. simple case: email in, gravatar-style output
var uri = AvatarUri.FromEmail(email);
Console.WriteLine(uri);

// 2. use a different hash
var uri2 = AvatarUri.FromEmail(email, new AvatarOptions { UseSHA256 = true });
Console.WriteLine(uri2);

// 3. you can also use HTTPS
var uri3 = AvatarUri.FromEmail(email, new AvatarOptions { PreferHttps = true });
Console.WriteLine(uri3);

// 4. AvatarOptions is just a normal C# object,
// so you can create one for the options you
// want, and store it / give it a name:
var favoriteOptions = new AvatarOptions { UseSHA256 = true, PreferHttps = true };
var uri4 = AvatarUri.FromEmail(email, favoriteOptions);
Console.WriteLine(uri4);

// 5. You can do monsters, wavatars, identicons, etc:
var uri5 = AvatarUri.FromEmail(
    "bogus@ijw.co.nz",
    new AvatarOptions { DefaultImage = AvatarDefaultImages.MonsterID }
);
Console.WriteLine(uri5);

// 6. If you need a size other than the default, you can specify that:
var uri6 = AvatarUri.FromEmail(email, new AvatarOptions { Size = 32 });
Console.WriteLine(uri6);
