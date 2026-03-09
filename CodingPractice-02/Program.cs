using System; 

static void Go() => Console.WriteLine("직진");
static void Left() => Console.WriteLine("좌회전");
static void Right() => Console.WriteLine("우회전");
static void Transformer(int[] values, Transformer t) {
    foreach (var value in values) {
        Console.WriteLine(t(value));
    }
}

int Square(int x) => x * x;
int Cube(int x) => x * x * x;

// 1. 인스턴스 메서드 참조
{
    Calculator calculator = new Calculator();
    Transformer t = calculator.Multiply;

    t(5);
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 멀티캐스트 대리자 : 추가와 제거
{
    CarDriver cd = Go;
    cd += Left;
    cd += Right;
    cd();
    Console.WriteLine();
    cd -= Left;
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 배열 변환 예제
{
    Transformer tf = Square;
    int[] values = new int[] { 1, 2, 3, 4, 5 };

    Transformer(values, tf);
    Console.WriteLine();
    tf = Cube;
    Transformer(values, tf);
    Console.WriteLine();
    Console.WriteLine();
}


delegate void CarDriver();
delegate int Transformer(int x);