using System;

Action<string> action;
string str = "Hello, World!";
Console.WriteLine($"=== 문자열 처리 파이프라인 ===");
Console.WriteLine();

action = PrintOriginal;
Console.WriteLine($"--- 단계 1 : 원본 출력만 ---");
action(str);
Console.WriteLine();

action += PrintUpper;
Console.WriteLine($"--- 단계 2 : 대문자 추가 ---");
action(str);
Console.WriteLine();

action += PrintLower;
action += PrintLength;
Console.WriteLine($"--- 단계 3: 소문자, 길이 추가 ---");
action(str);
Console.WriteLine();

action -= PrintUpper;
Console.WriteLine($"--- 단계 4 : 대문자 제거 ---");
action(str);
Console.WriteLine();

void PrintOriginal(string str) {
    Console.WriteLine($"원본 : {str}");
}

void PrintUpper(string str) {
    Console.WriteLine($"대문자 : {str.ToUpper()}");
}

void PrintLower(string str) {
    Console.WriteLine($"소문자 : {str.ToLower()}");
}

void PrintLength(string str) {
    Console.WriteLine($"길이 : {str.Length}");
}