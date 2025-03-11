import jdk.internal.access.JavaNetHttpCookieAccess;

import java.io.File;
import java.io.IOException;
import java.text.ParseException;
import java.util.Scanner;
import java.util.stream.Stream;

public class Main {
    public static void main(String[] args) throws ParseException, IOException {
        show_menu();
    }

    static void show_menu() throws IOException {
        System.out.println("Выберете необходимое действие:\n" +
                "1) Вывести общий реестр зверушек на экран.\n" +
                "2) Добавить зверушку.\n" +
                "3) Узнать список команд, которые может выполнять зверушка.\n" +
                "4) Научить зверушку новым командам.\n");
        Scanner scanner = new Scanner(System.in);
        int menu = scanner.nextInt();
        switch (menu) {
            case 1:
                AnimalRegistry.printRegistry();
                show_menu();
                break;
            case 2:
                System.out.println("Как зовут зверушку?");
                String name = scanner.next();
                System.out.println("Когда у него день рождения? (день-месяц-год)");
                String birthDate = scanner.next();
                System.out.println("Кто эта зверушка?:\n" +
                        "1 - котик.\n" +
                        "2 - собачка.\n" +
                        "3 - хомячок.\n");
                int typeForAdd = scanner.nextInt();
                try {
                    Counter counter = new Counter();
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
                        default:
                            show_menu();
                            break;
                    }
                    show_menu();
                    break;
                } finally {
                    throw new IOException("Счетчик не закрыт.");
                }
            case 3:
                System.out.println("Назовите имя зверушки, набор команд которой хотите узнать?");
                String nameForCommands = scanner.next();
                AnimalRegistry.findCommandsByName(nameForCommands);
                show_menu();
                break;
            case 4:
                System.out.println("Назовите имя зверушки, которую хотите научить новой команде?");
                String nameForAddCommands = scanner.next();
                System.out.println("Какой команде хотите научить?");
                String commandsForAdd = scanner.next();
                AnimalRegistry.addCommandsByName(nameForAddCommands, commandsForAdd);
                show_menu();
                break;
            default:
                System.out.println("Вы ввели неправильную команду, перезапустите реестр.");
                break;
        }
    }
}

class Counter implements AutoCloseable {
    int temp;
    boolean closed = false;
    public Counter() {
        temp = 0;
    }

    public void add(String name, String birthDate, Integer typeForAdd) throws IOException {
        if (isClose(name, birthDate, typeForAdd)) {
            throw new IOException("Счетчик закрыт.");
        }
        temp++;
    }

    public boolean isClose(String name, String birthDate, Integer typeForAdd) {
        if (name != null && birthDate != null && (typeForAdd == 1 | typeForAdd == 2 | typeForAdd == 3)) {
            close();
        }
        if (closed) {
            return true;
        } else return false;
    }

    @Override
    public void close() {
        closed = true;
    }
}



