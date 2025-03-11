package Seminar5;

public class FromPlatformGB {
    // Модель (Model)
    public class CalculatorModel {
        private int result;
        public void add(int number1, int number2) {
            result = number1 + number2;
        }
        public int getResult() {
            return result;
        }
    }
    // Представление (View)
    public class CalculatorView {
        public void displayResult(int result) {
            System.out.println("Результат: " + result);
        }
        public int getUserInput() {
            Scanner scanner = new Scanner(System.in);
            System.out.print("Введите число: ");
            int input = scanner.nextInt();
            return input;
        }
    }
    // Презентер (Presenter)
    public class CalculatorPresenter {
        private CalculatorModel model;
        private CalculatorView view;
        public CalculatorPresenter(CalculatorModel model, CalculatorView view) {
            this.model = model;
            this.view = view;
        }
        public void onAddButtonClicked() {
            int number1 = view.getUserInput();
            int number2 = view.getUserInput();
            model.add(number1, number2);
            int result = model.getResult();
            view.displayResult(result);
        }
    }
    // Главный класс приложения
    public class Main {
        public static void main(String[] args) {
// Создание экземпляров модели, представления и презентера
            CalculatorModel model = new CalculatorModel();
            CalculatorView view = new CalculatorView();
            CalculatorPresenter presenter = new CalculatorPresenter(model, view);
// Обработка действия пользователя (например, нажатие кнопки "Сложить")
            presenter.onAddButtonClicked();
        }
    }

}
