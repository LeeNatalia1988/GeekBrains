package Seminar7;

import java.util.Scanner;

/**
 * Класс, выводящий необходимые параметры и операции в терминал для пользователя
 */
public class CalculatorView {
    /**
     * Scanner для чтения с консоли
     */
    Scanner scanner = new Scanner(System.in);

    /**
     * Метод для получения результатов выбора операции пользователем
     */
    public String getOperation() {
        System.out.println("Введите опeрацию (+,-,*,/): ");
        return scanner.nextLine();
    }

    /**
     * Метод для получения чисел
     */

    public Double getNumber() {
        System.out.println("Введите число: ");
        return Double.parseDouble(scanner.nextLine());
    }

    /**
     * Метод для получения результата операции
     */

    public void getResult(double result) {
        System.out.println("Результат выбранной операции: " + result);
    }
}
