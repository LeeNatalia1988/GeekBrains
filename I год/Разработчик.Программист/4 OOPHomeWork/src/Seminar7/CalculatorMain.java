package Seminar7;

import java.io.IOException;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;

/**
 * Основной класс программы
 */
public class CalculatorMain {
    public static void main(String[] args) throws IOException {
        /**
         * Логирование
         */
        Logger logger = Logger.getLogger(CalculatorMain.class.getName());
        FileHandler fh = new FileHandler("log.txt");
        logger.addHandler(fh);
        SimpleFormatter sFormat = new SimpleFormatter();
        fh.setFormatter(sFormat);
        logger.log(Level.WARNING, "Ошибочка!");
        logger.info("Обрати внимание!");

        CalculatorModel model = new CalculatorModel();
        CalculatorView view = new CalculatorView();
        CalculatorPresenter presenter = new CalculatorPresenter(model, view);
        String operation = view.getOperation();
        Double number1 = view.getNumber();
        /**
         * @param number1 переменная для первого числа
         */
        Double number2 = view.getNumber();
        /**
         * @param number2 переменная для второго числа
         */

        /**
         * Обработка выбора операции пользователем
         * */
        presenter.performOperation(operation, number1, number2);
    }
}
