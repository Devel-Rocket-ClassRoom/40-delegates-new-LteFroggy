using System;

string ToUpperCase(string s) => s.ToUpper();
string ToLowerCase(string s) => s.ToLower();
string AddBrackets(string s) => "[" + s + "]";
string Reverse(string s) {
    char[] chars = s.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
}

void ProcessAndPrint(string input, StringProcessor processor) {
    Console.WriteLine($"결과 : {processor(input)}");
}

Console.WriteLine($"=== 문자열 가공기 ===");
Console.WriteLine();
string str = "Hello, World!";
Console.WriteLine($"원본 : {str}");
Console.WriteLine();

StringProcessor processor = ToUpperCase;
Console.WriteLine($"[대문자 변환]");
ProcessAndPrint(str, processor);
Console.WriteLine();

processor = ToLowerCase;
Console.WriteLine($"[소문자 변환]");
ProcessAndPrint(str, processor);
Console.WriteLine();

processor = AddBrackets;
Console.WriteLine($"[괄호 추가]");
ProcessAndPrint(str, processor);
Console.WriteLine();

processor = Reverse;
Console.WriteLine($"[소문자 변환]");
ProcessAndPrint(str, processor);
Console.WriteLine();

Console.WriteLine();
Console.WriteLine();

delegate string StringProcessor(string str);