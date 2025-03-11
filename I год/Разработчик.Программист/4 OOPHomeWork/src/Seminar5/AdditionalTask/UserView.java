package Seminar5.AdditionalTask;

import java.util.Scanner;

public class UserView {
    Scanner scanner = new Scanner(System.in);

    public String getOperation() {
        System.out.println("Введите опeрацию:\n" +
                "1. Ввод данных для регистрации пользователя.\n" +
                "2. Вход.\n" +
                "3. Изменить пароль.\n" +
                "4. Отобразить данные пользователя.\n");
        return scanner.nextLine();
    }
}
