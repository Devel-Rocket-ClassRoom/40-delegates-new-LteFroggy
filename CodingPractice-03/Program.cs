using System;

static void Go() => Console.WriteLine("직진");
static void Left() => Console.WriteLine("좌회전");
static void Right() => Console.WriteLine("우회전");

// 1. 내장 대리자(Action)로 멀티캐스트
{
    Action act = Go;
    act += Left;
    act += Right;

    act();
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 익명 메서드와 멀티캐스트
{
    Action action = Go;
    action += Left;
    action += delegate() {
        Console.WriteLine($"우회전");
    };

    action();
    Console.WriteLine();
    Console.WriteLine();
}