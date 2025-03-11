package Seminar3.Task_3;

import java.util.Arrays;
import java.util.List;

public class Main2 {
    public static void main(String[] args) {
        List<Integer> numbers = Arrays.asList(5, 2, 8, 1, 3);

        numbers.sort((num1, num2) -> num1 - num2);

        System.out.println(numbers); // Вывод: [1, 2, 3, 5, 8]
    }
}
