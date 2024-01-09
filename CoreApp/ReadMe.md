1. Models -
	A) Automatically Implemented Properties
			public string Name{get; set;}
	is same as 
			public string Name{
			get {return _name};
			set { _name =value;}
			}
	B) Readonly Automatically Implemented Properties, 
		public bool InStock { get; } =true;
		Note: the value can reassigned using constructor only
2. String interpolation instead of using the string.Format we can use variables directly. The strings are prefixed with $
		Example:Refer Homecontroller (privacy)---> $"Name: {name}, Price: {price}" 

3. Conditional Operator--> ?. 
   Checks if the object is null , if not null assigns the property value else the system does not throw null exception
		Example:Refer Homecontroller (privacy)
				int Id = item?.Id?

4. Coalescing Operator--> ??.
	Checks if the property value of the object is null, if not null assigns the property value else sets the default value
		Example:Refer Homecontroller (privacy)
				string name = item?.ProductName ?? "No Name";

5. Implemented Lambda Expressions and Methods
		Example:Refer ProductExtensions

6. Using the Options Pattern to access the values from appsettings.json 
		Example:Refer Startup.cs

7. Using the strongly typed class Pattern to access the values from appsettings.json 
		Example:Refer HomeController - IConfiguration and GetSection("AppSettings")

