using OopPolymorphismOverloading;

BasicMath basic1 = new();
BasicMath basic2 = new()
{
    NumberOne = 5
};
BasicMath basic3 = new()
{
    NumberTwo = 7
};
BasicMath basic4 = new()
{
    NumberOne = 5,
    NumberTwo = 10
};

basic1.Sum();   // => 0
basic2.Sum(5, 6); // => 11
basic3.Sum(5);

// named argument 
basic1.Sum(num2: 5);
basic1.Sum(num2: 5, num1: 9);