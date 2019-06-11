# Thanks for looking into my custom class encryption module
### It is just a new project, so I do not know where we will end up.

Currently it is only a wrapper class around the Rijndaelmanaged cryptography.

## I would like to have your feedback
So in case you have any, or want to request new features - if enough request them I will add them shortly - fill in [this](https://docs.google.com/forms/d/e/1FAIpQLScEEG5srRuAewsxFCKtZKA5JK2-lAhf3UAYOMaHc9LkDKxGiA/viewform?usp=sf_link) form.

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

# New in 2.0
## Custom configuration

As of now you can upload your own configuration with the following properties:
 * Password
 * KeySize
 * BlockSize
 * Iterations of en- and decoding
 
## How to?

1. Create a baseclass inheriting EntityBase
```csharp
public class BaseClass : EntityBase
{
	// ...
}
```

2. Override the GetConfiguration (parameterless) method
```csharp
protected override Configuration GetConfiguration()
{
	return Configuration.Standard; // or add some custom logic
}
```