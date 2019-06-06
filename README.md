## Thanks for looking into my custom class encryption module
### It is just a new project, so I do not know where we will end up.

Currently it is only a wrapper class around the Rijndaelmanaged cryptography.

Useage example:
```csharp
public class Person : EntityBase
{
	private List<string> protectedProperties = new List<string>
	{
		"Name",
		"Email"
	};

	public Person : base(protectedProperties)
	{ }
	
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