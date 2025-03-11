// Не могу загрузить на гитхаб, грузит почему-то совсем не то.
package main.Seminar_6.HomeWork;

import java.util.HashSet;
import java.util.Scanner;
import java.util.Set;
import java.util.*;

public class Store {
    public static void main(String[] args) {
        Laptop lp1 = new Laptop(1, "ASUS", "AMD Ryzen 5 5600H", 8, 512, "без ОС", "черный");
        Laptop lp2 = new Laptop(2, "Apple", "Apple M1 7-core", 8, 256, "macOS", "черный");
        Laptop lp3 = new Laptop(3, "ASUS", "AMD Ryzen 5 5600H", 16, 512, "без ОС", "черный");
        Laptop lp4 = new Laptop(4, "HUAWEI", "Intel Core i7-12700H", 16, 512, "Windows 11", "черный");
        Laptop lp5 = new Laptop(5, "Xiaomi", "Intel Core i5-11320H", 8, 512, "Windows 11", "черный");
        Laptop lp6 = new Laptop(2, "Apple", "Apple M1 7-core", 8, 256, "macOS", "черный");
        Laptop lp7 = new Laptop(6, "Apple", "Apple M2", 8, 256, "macOS", "белый");
        Laptop lp8 = new Laptop(7, "MSI", "Intel Core i5-1235U", 16, 512, "Windows 11", "красный");
        Laptop lp9 = new Laptop(8, "MSI", "Intel Core i5-11400H", 8, 256, "без ОС", "красный");
        Laptop lp10 = new Laptop(9, "HUAWEI", "Intel Core i3-1115G4", 8, 256, "без ОС", "белый");

        Set<Laptop> lp = new HashSet<>();
        lp.add(lp1);
        lp.add(lp2);
        lp.add(lp3);
        lp.add(lp4);
        lp.add(lp5);
        lp.add(lp6);
        lp.add(lp7);
        lp.add(lp8);
        lp.add(lp9);
        lp.add(lp10);
        System.out.println(lp.equals(lp));
        System.out.println(lp);
        Scanner sc = new Scanner(System.in);
        System.out.println("Выберите необходимые/минимальные параметры для поиска:\n"+"Торговая марка (ASUS, Apple, HUAWEI, Xiaomi, MSI): ");
        String brandchoise = sc.nextLine();
        System.out.println("ОЗУ: ");
        Integer ramchoise = sc.nextInt();
        System.out.println("Объем ЖД: ");
        Integer ssdchoise = sc.nextInt();
        for(Laptop lap: lp) {
            if ((Objects.equals(lap.getBrand(), brandchoise)) && (lap.getRAM() >= ramchoise) && (lap.getSSD() >= ssdchoise)) {
                System.out.println(lap.toString());
            }
        }
        sc.close();
    }

}
