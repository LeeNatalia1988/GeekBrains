
//1) Вычислить n-ое треугольного число (сумма чисел от 1 до n), n! (произведение чисел от 1 до n)
package main.Seminar_1;

import java.util.Scanner;

public class Task_1 {
    public static void main(String[] args) {
        Scanner iScanner = new Scanner(System.in);
        System.out.printf("Введите число: ");
        int x = iScanner.nextInt();
        iScanner.close();
        System.out.printf("Треугольное число: %d\n", triangle(x));
        System.out.printf("Факториал: %d\n", factorial(x));
    }

    public static int triangle(int x) {
        return (x * (x + 1)) / 2;
    }

    public static int factorial(int x){
        int fact = 1;
        if (x == 0) {
            return 1;
        }
        else {
            for (int i = 1; i <= x; i++) {
                fact = fact * i;
            }
        }
        return fact;
    }
}

