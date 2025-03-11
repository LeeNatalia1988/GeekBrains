package Seminar7;

/**
 * Класс для описания логики операций
 */
public class CalculatorModel {
    private double result;
    /**
     * @param result переменная для результата операций
     */
    /**
     * Метод для вычисления суммы введенных пользователем чисел
     */
    public void summ(double number1, double number2) {
        result = number1 + number2;
    }

    /**
     * Метод для вычисления разницы введенных пользователем чисел
     */
    public void subtraction(double number1, double number2) {
        result = number1 - number2;
    }

    /**
     * Метод для вычисления произведения введенных пользователем чисел
     */
    public void multiplication(double number1, double number2) {
        result = number1 * number2;
    }

    /**
     * Метод для вычисления частного(деления) введенных пользователем чисел
     */
    public void divide(double number1, double number2) {
        if (number2 != 0) {
            result = number1 / number2;
        } else {
            // Обработка деления на ноль
            throw new IllegalArgumentException("На ноль делить нельзя!");
        }
    }

    /**
     * Метод для получения результата
     */

    public double getResult() {
        return result;
    }


}
