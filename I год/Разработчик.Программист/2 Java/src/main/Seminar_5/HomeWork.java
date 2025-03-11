package main.Seminar_5;

import java.util.Scanner;
//Реализуйте структуру телефонной книги с помощью HashMap.
//Программа также должна учитывать, что во входной структуре будут повторяющиеся имена с разными телефонами,
//их необходимо считать, как одного человека с разными телефонами. Вывод должен быть отсортирован по убыванию числа телефонов.
public class HomeWork {
    public static void main(String[] args) {
    show_menu();
    }
    static void show_menu(){
        System.out.println("Выберете необходимое действие:\n1) Вывести справочник на экран.\n2) Добавить абонента.\n3) Найти по фамилии.\n4) Удалить абонента.\n");
        Scanner scanner = new Scanner(System.in);
        int menu = scanner.nextInt();
        switch (menu){
            case 1:
                PhoneBook.print();
                break;
            case 2:
                System.out.println("Введите фамилию и телефон через пробел:");
                String list_1 = scanner.nextLine();
                String[] list_2 = list_1.split(" ");
                PhoneBook.add(list_2[0], list_2[1]);
                break;
            case 3:
                System.out.println("Введите фамилию:");
                String LastName1 = scanner.nextLine();
                PhoneBook.found(LastName1);
                break;
            case 4:
                System.out.println("Введите фамилию:");
                String LastName2 = scanner.nextLine();
                PhoneBook.delete(LastName2);
                break;
            default: show_menu();
        }
    }
}
