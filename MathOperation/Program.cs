using System;

int a = 20, b = 4;

Console.WriteLine($"=== 사칙연산 대리자 ===");
Console.WriteLine();
MathOp op = Add;
Console.WriteLine($"[덧셈]");
Console.WriteLine($"{a} + {b} = {op(a, b)}");
Console.WriteLine();
op = Subtract;
Console.WriteLine($"[덧셈]");
Console.WriteLine($"{a} - {b} = {op(a, b)}");
Console.WriteLine();
op = Multiply;
Console.WriteLine($"[곱셈]");
Console.WriteLine($"{a} * {b} = {op(a, b)}");
Console.WriteLine();
op = Divide;
Console.WriteLine($"[나눗셈]");
Console.WriteLine($"{a} / {b} = {op(a, b)}");
Console.WriteLine();
Console.WriteLine();


int Add(int x, int y) => x + y;
int Subtract(int a, int b) => a - b;
int Multiply(int a, int b) => a * b;
int Divide(int a, int b) => a / b;

delegate int MathOp(int x, int y);