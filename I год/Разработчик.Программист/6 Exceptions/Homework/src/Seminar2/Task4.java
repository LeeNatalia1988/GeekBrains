package Seminar2;
/**
 * Разработайте программу, которая выбросит Exception, когда пользователь вводит пустую строку.
 * Пользователю должно показаться сообщение, что пустые строки вводить нельзя.
 */

import java.util.Scanner;

public class Task4 {
    public static void main(String[] args) {
        task4();
    }

    public static void task4() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите строку: ");
        String str = scanner.nextLine();
        if (str != "") {
            System.out.println("Вы ввели: " + str);
        } else {
            System.out.println("Вы ввели пустую строку. Так не пойдет. Повторите попытку: ");
            task4();
        }
    }
}
