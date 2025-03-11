package Seminar5;

public class CalculatorPresenter {
    private CalculatorView view;
    private CalculatorModel model;

//    Конструктор
    public CalculatorPresenter(CalculatorModel model, CalculatorView view) {
        this.model = model;
        this.view = view;
    }

//    Метод для выбора операции пользователем и получения результата
    public void performeOperation(String operation, double number1, double number2) {
        switch (operation) {
            case "+":
                model.summ(number1, number2);
                break;
            case "-":
                model.subtraction(number1, number2);
                break;
            case "*":
                model.multiplication(number1, number2);
                break;
            case "/":
                model.divide(number1, number2);
                break;
            default:
                System.out.println("Некорректная операция!");
        }
        view.getResult(model.getResult());
    }
}

