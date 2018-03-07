// Class – think of a class like a blueprint of an object. A class has properties (data) and methods (functions).  
 
// Members – properties and methods  
 
// The purpose of a class if to provide the definition for an object.  
// An object is an instance of a class  

public class Customer
{
    public inst CustomerId {get; set;}
    public string EmaiAddress {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public bool validate(); 
}

Customer customer1 = new Customer(); 
customer.FirstName = "Frodo";
customer.validate();

//Objects only exist at runtime
//Class still exists
//Business object: Refers to a class specifically designed to solve a business problem.
//Each object has its own values for the properties. 

//Entitiy: define the things that are significant enoughs to consider or be represented as a class

//Object Oriented Programming 
// Build applictions that are felixible, testable, well crafted
// Focus on objects that interact cleanly with one another 
// Represents the enitties and concepts of an application as classes 
// 1) Indentifying classes
// 2) Separating responsibilities 
// 3) Establishing Relationships
// 4) Leveraging Reuse




