package Seminar3;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        /*
        * Создаем новый список прямоугольников согласно классу Rectangle*/
        List<Rectangle> rectangles = new ArrayList<>();
        rectangles.add(new Rectangle(5.0, 5.0, "Черный"));
        rectangles.add(new Rectangle(10.0,10.0,"Красный"));
        rectangles.add(new Rectangle(8.0,2.0,"Белый"));
        rectangles.add(new Rectangle(2.0,4.0,"Фиолетовый"));
        rectangles.add(new Rectangle(20.0,10.0, "Синий"));

        /*
        * Распечатываем изначальный список прямоугольников*/
        for (Rectangle rectangle : rectangles) {
            System.out.println(rectangle);
        }
        /*
        * Сортируем по площади (по периметру дополнительно сортировать смысла никакого).
        * Для этого сначала создам компаратор*/
        Comparator<Rectangle> areaComparator = new Comparator<Rectangle>() {
            @Override
            public int compare(Rectangle rectangle1, Rectangle rectangle2) {
                return (int)(rectangle1.getArea() - rectangle2.getArea());
            }
        };
        rectangles.sort(areaComparator);
        /*
        * Распечатываем отсортированный список (вставляем парочку пустых строк, чтоб нагляднее видно было)*/
        System.out.println();
        System.out.println();
        for (Rectangle rectangle : rectangles) {
            System.out.println(rectangle);
        }



    }
}
