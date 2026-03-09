using System;
using System.Threading.Channels;
static void Go() => Console.WriteLine("직진");
static void Back() => Console.WriteLine("후진");
static void RunnerCall(Runner runner) {
    Console.WriteLine($"=== 실행 시작 ===");
    runner();
    Console.WriteLine($"=== 실행 종료 ===");
}
static double GetArea(int radius) => radius * radius * Math.PI;
static void WriteToConsole(int progress) 
    => Console.WriteLine($"진행률 : {progress}%");
static void WriteToFile(int progress) 
    => Console.WriteLine($"[파일 기록] : {progress}%");

// 1. 대리자를 통한 메서드 호출
{
    SayDelegate Hello = () => Console.WriteLine("Hello Delegate");
    Hello();
    Hello.Invoke();
    Console.WriteLine();
    Console.WriteLine();
} 

// 2. 대리자 인스턴스 생성 방법
{
    void Hi() => Console.WriteLine($"안녕하세요");
    SayDelegate del = Hi;

    del();
    del.Invoke();
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 매개변수와 반환값이 있는 대리자
{
    GetAreaDelegate area = GetArea;

    area.Invoke(10);
    area(10);
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 강력한 형식의 대리자
{
    MathOperation op = Math.Pow;
    op(2, 10);
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 정적 메서드 참조
{
    TransFormer tf = Calculator.Square;

    Console.WriteLine(tf(5));
    Console.WriteLine();
    Console.WriteLine();
}

// 6. 멀티캐스트 대리자 : 진행률 보고
{
    ProgressReporter pr = WriteToConsole;
    pr += WriteToFile;

    pr(0);
    Console.WriteLine();
    pr(25);
    Console.WriteLine();
    pr(50);
    Console.WriteLine();
    pr(75);
    Console.WriteLine();
    pr(100);
    Console.WriteLine();
    Console.WriteLine();
}

// 7. 대리자를 매개변수로 전달
{
    Runner runner1 = Go;
    RunnerCall(runner1);
    Console.WriteLine();
    Runner runner2 = Back;
    RunnerCall(runner2);
    Console.WriteLine();
    Console.WriteLine();
}

// 8. Action 대리자
{
    Action<string> strAction = (str) => Console.WriteLine(str);
    Action<string, int> strIntAction = (str, val) => {
        for (int i = 0; i < val; i++) Console.WriteLine(str);
    };

    strAction("안녕하세요!");
    strAction("Hello, Action!");
    strIntAction("반복", 3);
    Console.WriteLine();
    Console.WriteLine();
}

// 9. Func 대리자
{
    Func<int> func_i= () => 42;
    Func<int, int> iFunc_i  = (val) => val * val;
    Func<int, int, int> iiFunc_i = (val1, val2) => val1 + val2;
    Func<int, int, string> iiFunc_s = (val1, val2) => val1.ToString() + val2.ToString();
}

// 10. Predicate 대리자
{
    Predicate<int> isEven = (x) => x % 2 == 0;
    Predicate<int> isPositive = (x) => x > 0;

    Console.WriteLine(isEven(4));
    Console.WriteLine(isEven(7));
    Console.WriteLine(isPositive(5));
    Console.WriteLine(isPositive(-3));
    Console.WriteLine();
    Console.WriteLine();
}

// 11. 익명 메서드
{
    SayDelegate say = delegate() {
        Console.WriteLine($"반갑습니다.");
    };
    say();
    Console.WriteLine();
    Console.WriteLine();
}

delegate void Runner();
delegate int TransFormer(int x);
delegate double GetAreaDelegate(int radius);
delegate double MathOperation(double floor, double exp);
delegate void SayDelegate();
delegate void ProgressReporter(int progress);