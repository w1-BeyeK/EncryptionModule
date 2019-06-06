## Thanks for looking into my custom class encryption module
### It is just a new project, so I do not know where we will end up.

Currently it is only a wrapper class around the Rijndaelmanaged cryptography.

Example of implementation:
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