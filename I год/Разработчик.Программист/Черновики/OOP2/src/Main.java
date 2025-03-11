import jdk.internal.access.JavaNetHttpCookieAccess;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Stream;

public class Main {
    public static void main(String[] args) throws ParseException {
        show_menu();
    }

    static void show_menu() {
        System.out.println("Выберете необходимое действие:\n" +
                "1) Вывести общий реестр зверушек на экран.\n" +
                "2) Добавить зверушку.\n" +
                "3) Узнать список команд, которые может выполнять зверушка.\n" +
                "4) Научить зверушку новым командам.\n" +
                "5) Вывести количество зверушек на экран.");
        Scanner scanner = new Scanner(System.in);
        int menu = scanner.nextInt();
        switch (menu) {
            case 1:
                AnimalRegistry.printRegistry();
                show_menu();
            case 2:
                System.out.println("Кого вы хотите добавить?:\n" +
                        "1 - котик.\n" +
                        "2 - собачка.\n" +
                        "3 - хомячок.\n" +
                        "0 - вернуться в главное меню.");
                int typeForAdd = scanner.nextInt();
                System.out.println("Как зовут зверушку?");
                String name = scanner.next();
                System.out.println("Когда у него день рождения? (день-месяц-год)");
                String birthDate = scanner.next();
                switch (typeForAdd) {
                    case 1:
                        Cat cat = new Cat(name, birthDate);
                        AnimalRegistry.addAnimal(name, Cat.getType(), birthDate, Cat.getCommands());
                        break;
                    case 2:
                        Dog dog = new Dog(name, birthDate);
                        AnimalRegistry.addAnimal(name, Dog.getType(), birthDate, Dog.getCommands());
                        break;
                    case 3:
                        Hamster hamster = new Hamster(name, birthDate);
                        AnimalRegistry.addAnimal(name, Hamster.getType(), birthDate, Hamster.getCommands());
                        break;
                    case 0:
                        show_menu();
                default:
                    break;
                }
            show_menu();
            case 3:
                System.out.println("Назовите имя зверушки, набор команд которой хотите узнать?");
                String nameForCommands = scanner.next();
                AnimalRegistry.findCommands(nameForCommands);
                show_menu();
        default:
            System.out.println("Вы ввели неправильную команду, перезапустите реестр.");
        }
    }
}



