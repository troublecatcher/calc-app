using CalcApp;

Console.WriteLine("First number?:");
var a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Operation? + - * /:");
var op = Convert.ToString(Console.ReadLine());

Console.WriteLine("Second number?:");
var b = Convert.ToDouble(Console.ReadLine());

var calculator = new Calculator();
var result = calculator.Calc(a, b, op);

Console.WriteLine("Result: " + result);
