package Seminar7;

/**
 * Класс для связи model и view
 */
public class CalculatorPresenter {

    private CalculatorView view;
    /**
     * @param view объект класса CalculatorView
     */
    private CalculatorModel model;
    /**
     * @param model объект класса CalculatorModel
     * */

    /**
     * Конструктор CalculatorPresenter
     */
    public CalculatorPresenter(CalculatorModel model, CalculatorView view) {
        this.model = model;
        this.view = view;
    }

    /**
     * Метод для выбора операции пользователем и получения результата
     */

    public void performOperation(String operation, double number1, double number2) {
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

