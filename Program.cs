// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
using static System.Console;

int A = Number("A");
int B = Number("B");
WriteLine($"{A},{B} => {Exponentiation(A,B)}");
//WriteLine($"{A},{B} => {Math.Pow(A,B)}");

int Number(string name) {
    Write("Введите число {name}: ");
    return int.Parse(ReadLine());
}

int Exponentiation(int A, int B) {
    int result = 1;
    for(int i = 0; i < B; i++) {
        result = result*A;
    }
    return result;
}