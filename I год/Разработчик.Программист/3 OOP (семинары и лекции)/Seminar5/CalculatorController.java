package Seminar5;

public class CalculatorController {
    private CalculatorView view;
    private CalculatorModel model;
    public CalculatorController(CalculatorModel model, CalculatorView view) {
        this.model = model;
        this.view = view;
    }
    public void performeOperation(String operation, int num1, int num2) {
        switch (operation) {
            case "+":
                model.add(num1, num2);
            break;
            case "-":
                model.subtract(num1, num2);
            break;
            case "*":
                model.multiply(num1, num2);
            break;
            case "/":
                model.divide(num1, num2);
            break;
            default: System.out.println("Некорректная операция!"); }
        view.displayResult(model.getResult()); }
}
