# Thanks for looking into my custom class encryption module
### It is just a new project, so I do not know where we will end up.

Currently it is only a wrapper class around the Rijndaelmanaged cryptography.

Useage example:
```csharp
public class Person : EntityBase
{
	public Person : base()
	{ 
		protectedProperties = new List<string>
		{
			// Note that it is NOT casesensitive, as you could use fields/properties together
			"Name",
			"Email",
		};
	}
	
	public long Id { get; set; }
	
	public string Name { get; set; }
	public string Email { get; set; }
}
```

To actually encrypt the values you just do the following:
```csharp
Person person = new Person();
person.Name = "Kevin";
person.Email = "test@!?";
person.Encode(); // Name and email will be encrypted

// Publish to database or something similair?

person.Decode(); // Both values should be themselves again
```

## To edit the passphrase you can do the following

1. Create a baseclass inheriting EntityBase
```csharp
public class BaseClass : EntityBase
{
	// ...
}
```

2. Override the following method: 'GetPassPhrase'
```csharp
protected override string GetPassPhrase()
{
	return "yourpassword"; // or add custom logic to retrieve this from a file
}
```