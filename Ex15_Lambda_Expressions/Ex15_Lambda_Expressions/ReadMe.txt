Ex 15 Lambda Expression Challenge 

Subject:

Create a dictionary that will contain <string, Func<>> pairs. 
The keys will be operation signs "+", "-", "/", "*" and values will be the lambda expressions 
that will perform the corresponding operation on two floats and return a result with type float.

One more time in detail:

    Create and store using static keyword Lambda expressions with names Plus, Minus, Divide and Multiply.

    You can store function as follow:

    static Func<int, int> Name = (a) => a;

    Create a static dictionary called Operators that uses a string as a Key and lambda function as a value.

    Example: {"sign", Function}

    Create a static method OperationGet that will get as input a string, 
    test if this string is a Key in the dictionary and if positive return function otherwise returns null.

Remember, this is an advanced topic. Take your time and read the Lambda documentation.

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator

https://www.geeksforgeeks.org/lambda-expressions-in-c-sharp/

