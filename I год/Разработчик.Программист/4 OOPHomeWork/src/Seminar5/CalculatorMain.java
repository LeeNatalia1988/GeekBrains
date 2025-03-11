package Seminar5;

public class CalculatorMain {
    public static void main(String[] args) {
        CalculatorModel model = new CalculatorModel();
        CalculatorView view = new CalculatorView();
        CalculatorPresenter presenter = new CalculatorPresenter(model, view);
        String operation = view.getOperation();
        Double number1 = view.getNumber();
        Double number2 = view.getNumber();
//Обработка выбора операции пользователем
        presenter.performeOperation(operation, number1, number2);
    }
}
