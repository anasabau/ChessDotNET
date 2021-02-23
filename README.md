# ChessDotNET
OOP implementation of chess in .NET 5


## Development Principles
The main ideas in OOP are:

* Encapsulation
 - It should be very clear who owns what data, meaning, who is responsible to initialize it, change, retrieve it, etc.
 Usually, taken from programming langauges like Rust, it's a good idea, that data should only have one owner, aka one read/write owner.
 Data should not be made public by default, meaning objects should handle their internal state, and not expose it, just like that.
 Otherwise, external code to the calss, can mess up internal state.
 
 
 * Abstraction
 - Dependency relationships between classes, and other relationships as well, like composition, should mainly rely on abstraction, which in C# means interfaces, rather that on concrete types. Especially components that we want to be changeble.
 From practical experience, this is also very good in testing, because it makes testing more easy, as mocking can be done easly on abstractions. Aka, you can mock a dummy class to implement an interface.

 * Polymorphism

 This  means that objects of the same kind, (one usualy thinks, of inheritence here, but that's not the only case, for example, classes that implement the same interface, should be polymorphic as well) should be interchangeble.

 * Composition over Inheritence

 While C# is older than languages like Rust or Go, Inheritence, will be deprecated over Composition, which we consider a healthier and easier to develop/mantain principle.