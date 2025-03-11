//3) Реализовать простой калькулятор
package main.Seminar_1;
import java.util.Scanner;
public class Task_3 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int numb_1 = sc.nextInt();
        System.out.print("Введите второе число: ");
        int numb_2 = sc.nextInt();
        System.out.println("Введите операцию + - * /: ");
        char operation;
        operation = sc.next().charAt(0);
        int res;
        switch (operation) {
            case '+':
                res = numb_1 + numb_2;
                System.out.printf("Результат: %d",res);
                break;
            case '-':
                res = numb_1 - numb_2;
                System.out.printf("Результат: %d",res);
                break;
            case '*':
                res = numb_1 * numb_2;
                System.out.printf("Результат: %d",res);
                break;
            case '/':
                res = numb_1 / numb_2;
                System.out.printf("Результат: %d",res);
                break;
        }
        sc.close();
    }
}

