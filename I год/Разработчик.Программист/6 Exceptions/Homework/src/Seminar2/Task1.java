package Seminar2;

import java.util.Scanner;

/**
 * Реализуйте метод, который запрашивает у пользователя ввод дробного числа (типа float), и возвращает введенное значение.
 * Ввод текста вместо числа не должно приводить к падению приложения, вместо этого, необходимо повторно запросить у
 * пользователя ввод данных.
 */
public class Task1 {

    public static void main(String[] args) {
        task1();
    }

    static void task1() {
        Scanner scanner = new Scanner(System.in);
        float number = 0.0F;
        System.out.println("Введите дробное число: ");
        if (scanner.hasNextFloat()) {
            number = scanner.nextFloat();
            System.out.println("Введенное число: " + number);
        } else {
            System.out.println("Вы ввели неверный тип данных! Повторите попытку. ");
            task1();
        }
    }
}




