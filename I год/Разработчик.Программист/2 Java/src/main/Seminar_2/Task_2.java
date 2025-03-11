//2)* Реализуйте алгоритм сортировки пузырьком числового массива, результат после каждой итерации запишите в лог-файл.
package main.Seminar_2;
import java.io.IOException;
import java.util.Arrays;
import java.util.logging.*;
public class Task_2 {
    public static void main(String[] args) throws IOException{
        int [] array = {-8, 90, 1, 4, 34};
        System.out.printf("\n исходный массив: \n");
        System.out.println(Arrays.toString(array));
        int[] array_1 = listSort(array);
        System.out.printf("\n Итоговый массив: \n");
        System.out.println(Arrays.toString(array_1));

    }
    public static int[] listSort(int [] array) throws IOException{
        Logger logger = Logger.getLogger(Task_2.class.getName());
        FileHandler fh = new FileHandler("Task_2.xml");
        logger.addHandler(fh);
        XMLFormatter xml = new XMLFormatter();
        fh.setFormatter(xml);
        logger.info("Sort Array");
        for(int k = 0; k < array.length-1; k++) {
            logger.info("Итерация: " + k + "; " + "Массив: " + Arrays.toString(array) + "\n");
            for (int i = 0; i < array.length - k-1; i++){
                if (array[i] > array[i+1]) {
                    int temp = array[i];
                    array[i] = array[i+1];
                    array[i+1] = temp;
                }
            }
        }
        return array;
    }
}
