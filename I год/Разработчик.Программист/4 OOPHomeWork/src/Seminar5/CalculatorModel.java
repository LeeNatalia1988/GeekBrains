package Seminar5;

public class CalculatorModel {
    private double result;
// Методы для вычисления суммы, разницы, умножения и деления введенных пользователем чисел
    public void summ(double number1, double number2) {
        result = number1 + number2;
    }

    public void subtraction(double number1, double number2) {
        result = number1 - number2;
    }

    public void multiplication(double number1, double number2) {
        result = number1 * number2;
    }

    public void divide(double number1, double number2) {
        if (number2 != 0) {
            result = number1 / number2;
        } else {
            // Обработка деления на ноль
            throw new IllegalArgumentException("На ноль делить нельзя!");
        }
    }
//    Метод для получения результата
    public double getResult() {
        return result;
    }


}
