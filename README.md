# Software Developer Interview Questions

# General
- What brings you to computer programming?
- What is your favorite programming language?
- What programming paradigms do you know?
- How do you learn and keep yourself up to date?
- What is your goal for the next 5 years?
# Object Orientated Design
- Describe core principles of Object Orientated Design
- Describe SOLID software design principles principles
- Describe code reuse and DRY  (don’t repeat yourself) principle and why following it
- Describe dependency injection (DI) and inversion of control (IoC) and why they are needed
- What are design patterns  and which ones do you know?
- Describe the Domain Driven Design (DDD)
  - How an *entity* object is different from a *value* object?
- Assume you are designing an externally facing API. What are the considerations?
# Testing
- Why do we need automated software testing?
- Describe the types of automated software testing that you know and what are the pros and cons of each
- Describe unit testing, the pros and cons
  - What are the prerequisites of unit testing?
  - What is mocking and what it is used for?
- What testing frameworks / libraries have you used?
# Computer Science (basic)
- What is an algorithm?
- What is the complexity of an algorithm?
- What data structures do you know?
  - Assume you have a very large collection of airport objects and the only retrieval is by the airport code. What collection type would you use? 
# C#
- What are your favorites new features of the latest new versions of C#
- What types of multi-tasking and parallel processing C# supports?
- What is **async** / **await** and how the code having **await** is executed?
- What are the benefits of exceptions vs. returning error codes?
- What is LINQ?
- Assume you have code which executes multiple threads simultaneously. What should you take into account?

**Code sample**
Which implementation below is better and why?
1.

        public class Shop
        {
            public List<string> ProductCodes { get; set; }
        }   

2.

        public class Shop
        {
            public ICollection<string> ProductCodes { get; } = new HashSet<string>();
            
            public void AddProductCode(string code)
            {
                if (!string.IsNullOrWhiteSpace(code))
                    ProductCodes.Add(code);
            }
        }

**Code sample**
What issue(s), if any, can you spot in the code below

            public string[] Names { get; set; }
            
            public bool AreThereAnyNames()
            {
                return Names?.Length != 0;
            }

**Code sample**
What issue(s), if any, can you spot in the code below

            public double Divide(int a, int b)
            {
                return a / b;
            }

**Code sample**
Is there anything not quite right with throwing an exception below?

    if (arg == null)
      throw new Exception("The arg is null, must pass a value.");

**Code sample**
What issue(s)  if any, the class below has?

     public class Util
        {
            public bool IsEmpty(string str) => string.IsNullOrWhiteSpace(str);
            
            public int? ParseIntSafe(string input)
            {
                return int.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result) ? 
                    (int?)result : null;
            }
            
            public PassengerModel GetPassengerByName(string fullName)
            {
                // ... some code here ...
                return new PassengerModel();
            }
            
            public FrequentFlyerModel GetFrequentFlyerByName(string fullName)
            {
                // ... some code here ...
                return new FrequentFlyerModel();
            }
            
            public void ExecuteSafely(Action action)
            {
                try
                {
                    action();
                }
                catch (Exception e)
                {
                    Trace.TraceError(e.ToString());
                }
            }
        }


# .NET
- What are benefits of using a framework (e.g. Java / .NET)
- What is .NET Core, .NET Standard, and .NET Framework, and the relation between them?
- What collection types .NET has and when to use which?
- What is garbage collection and benefits (or disadvantages)?
- What two types of performance problems an application might have and your steps of troubleshooting performance problems
# JavaScript
- Describe pros and cons of dynamically typed language
  - Any benefits of using typed language e.g. *Typescript*?
- What is *hoisting*?
- What are your favorite new features of Javascript 6?


1. What is the code below doing and why?
    var that = this;


2. Describe the difference between the possible variable declarations below
    var num = 6;
    let num = 6;
    const num = 6;
# Angular
- What are main differences between, for example, jQuery and Angular?
- What types of data binding do you know?
- What is a component and what parts does it have?
# HTTP / Web API (basic)

Assume I have made a request to a HTTP Web API created by someone 

    GET Customers/1

And receive the following response

    200
    
    {
        "Id": 0,
        "FirstName": null,    
        "LastName": null,
        "Message": "Customer not found"
    }

Do you see any problem with the response?


Next, assume I have made a request to a HTTP Web API created by someone 

    GET Customers/xyz

And receive the following response

    200
    
    {
        "Id": 0,
        "FirstName": null,    
        "LastName": null,
        "Message": "FormatException"
    }

Do you see any problem with the response?



