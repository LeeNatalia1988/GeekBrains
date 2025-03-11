package Seminar3;

import java.io.*;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Objects;
import java.util.Scanner;

public class UserData {
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите данные через пробел:\nПодсказка: Фамилия Имя Отчество, дата рождения (в формате дд.мм.ггг), номер телефона (целое беззнаковое число без форматирования), пол (символ f или m)");
        Object[] userData = scanner.nextLine().split(" ");
        switch (CheckCount(userData)) {
            case -1 -> System.out.println("Вы ввели меньше данных, чем необходимо по условию.");
            case 1 -> System.out.println("Вы ввели больше данных, чем необходимо по условию.");
        }
        CheckFormatData(userData);
        CreateFile(userData);
    }

    /**
     * Функция проверки количества введенных пользователем данных.
     * @param userData - массив данных, которых ввел пользователь.
     * @return возвращает -1 если введено меньше данных, чем необходимо и 1, если введено больше данных, чем необходимо.
     */
    public static int CheckCount(Object[] userData) {
        if (userData.length < 6) {
            return -1;
        }
        if (userData.length > 6) {
            return 1;
        }
        return 2;
    }

    /**
     * Функция для проверки корректности форматов данных, которые ввел пользователь.
     * @param userData - массив данных, которых ввел пользователь.
     */
    static void CheckFormatData(Object[] userData) {
        for (int i = 0; i < 3; i++) {
            if (!(userData[i] instanceof String)) {
                System.out.printf("Неверный формат данных в %d", userData[i]);
            }
        }
        String dateFormat = "dd.mm.yyyy";
        try {
            SimpleDateFormat sdf = new SimpleDateFormat(dateFormat);
            sdf.setLenient(false);
            Date parsedDate = sdf.parse((String) userData[3]);
        } catch (Exception e) {
            System.out.println("Неверный формат даты рождения");
        }

        try {
            Long.parseLong((String) userData[4]);

        } catch (Exception e) {
            System.out.println("Неверный формат номера телефона.");
        }
        if (!(userData[5].equals("f") | userData[5].equals("m"))) {
            System.out.println(userData[5]);
            System.out.println("Неверный формат данный 'пол'.");
        }
    }

    /**
     * Функция для создания файла с данными, которые ввел пользователь.
     * Проверяет существует ли файл с имя=фамилия, если существует, то записывает новые данные в него, если не существует,
     * то создает новый файл.
     * @param userData - массив данных, которых ввел пользователь.
     */
    static void CreateFile(Object[] userData) {
        File file = new File((String) userData[0] + ".txt");
        if (file.isFile()) {
            try (FileWriter fileWriter = new FileWriter(((String) userData[0]) + ".txt", true)) {
                fileWriter.write("<" + userData[0] + "> " + "<" + userData[1] + "> " + "<" + userData[2] + "> " + "<"
                        + userData[3] + "> " + "<" + userData[4] + "> " + "<" + userData[5] + ">\n");

            } catch (IOException e) {
                e.printStackTrace();
            } catch (Exception e) {
                e.printStackTrace();
            }
        } else {
            try (FileWriter fileWriter = new FileWriter(((String) userData[0]) + ".txt", false)) {
                fileWriter.write("<" + userData[0] + "> " + "<" + userData[1] + "> " + "<" + userData[2] + "> " + "<"
                        + userData[3] + "> " + "<" + userData[4] + "> " + "<" + userData[5] + ">\n");

            } catch (IOException e) {
                e.printStackTrace();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }
}





