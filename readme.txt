what is an automapper:
AutoMapper is a simple C# library that transforms one object type to another object type, which means, it’s a mapper between two objects. AutoMapper is the convention-based object to object mapper. 
It maps the properties of two different objects by transforming the input object of one type to the output object of another type.



steps to achieve the automapper:

1. use NuGet package manager to install the package automapper or automapper.extension.Microsoft.dependency injection
2. need to tell the application that you are using the automapper. for that, you need to add the service inside the configuration method of startup.cs class.
3. Before mapping the data from one class to another class, we need to create a PROFILE
4. We can create a profile directly in the method or we can create globally.
5. to create the profile globally, to keep things in well manner, let us create a folder nemed HELPER
6. Create a class called any name you want, let me take Mapper.cs inside the helper folder
7. inherit the class Mapper.cs by the Profile class which is available in the automapper library package.
8. To create a profile you need to create the constructor for the mapper.cs class.	
9. inside the constructor you need to create a map of two class. createMap<source_class, Destination_class>
10. or we can reverse the mapping by using createMap<source_class, destination_class>.reverseMap();
11. it supports the dependency injection so we can use it inside the repo class.
12. create the object of the mapper inside the repo class using the IMapper.
13. then by using the mapper obj map the source and destination class and map the data.
14.  return _mapper.Map<List<target_class>>(obj_of_source_class).
15. if the name of the model property is diff then
		then we have to define those mappings in the profile class (mapper.cs)
