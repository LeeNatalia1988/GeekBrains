package main.Seminar_3;
// Пусть дан произвольный список целых чисел.
//1) Нужно удалить из него чётные числа
//2) Найти минимальное значение
//3) Найти максимальное значение
//4) Найти среднее значение
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class Task_1 {
    public static void main(String[] args) {
        List<Integer> list = new ArrayList(Arrays.asList(1, 2, 3, 4, 5, 6, 7));
        System.out.println("Изначальный список:" + list);
        System.out.println("Максимальное значение:" + Collections.max(list));
        System.out.println("Минимальное значение:" + Collections.min(list));
        System.out.println("Среднее значение:" + average(list));
        even_delete(list);
        System.out.println("Список без четных чисел:" + list);
    }
    public static void even_delete(List<Integer> list){
        for (int i = 0; i < list.size(); i++) {
            if(list.get(i)%2 == 0)
                list.remove(i);
        }
    }
    static Integer average(List<Integer> list){
        int summa = 0;
        for (int i = 0; i < list.size(); i++) {
            summa += list.get(i);
        }
        return summa/list.size();
    }
}
