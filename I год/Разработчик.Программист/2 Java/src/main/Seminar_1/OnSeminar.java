package main.Seminar_1;
import java.util.Scanner;
import java.time.LocalTime;
import java.util.Arrays;
import java.util.Scanner;
public class OnSeminar {
    public static void main(String[] args) {
    task0();
    }
    static void task0() {
            // В консоли запросить имя пользователя. В зависимости от текущего времени,
            // вывести приветствие вида////"Доброе утро, <Имя>!", если время от 05:00 до
            // 11:59
            // //"Добрый день, <Имя>!", если время от 12:00 до 17:59;////"Добрый вечер,
            // <Имя>!",
            // если время от 18:00 до 22:59;////"Доброй ночи, <Имя>!", если время от 23:00
            // до 4:59
        System.out.println("Как тебя зовут?");
        Scanner scanner = new Scanner(System.in);
        String name = scanner.nextLine();
        LocalTime time = LocalTime.now();
        int hour = time.getHour();
        if (hour >= 5 && hour < 12) {
            System.out.println("Доброе утро " + name);
            } else if (hour < 18 && hour >= 12) {
                System.out.println("Добрый день " + name);
            } else if (hour < 23 && hour >= 18) {
                System.out.println("Добрый вечер " + name);
            } else {
                System.out.println("Доброй ночи " + name);
            }
            scanner.close();
        }
    }


//        static void task1() {
//            // Дан массив двоичных чисел, например [1,1,0,1,1,1],
//            // вывести максимальное количество подряд идущих 1.
//            int[] arr = {1,1,0,1,1,1,0,1,1,1,1};
//            int maxOnes = 0;
//            int temp = 0;
//            for (int i = 0; i < arr.length; i++) {
//                if(arr[i] == 1){
//                    temp++;
//                } else {
//                    if (temp > maxOnes){
//                        maxOnes = temp;}
//                    temp = 0;
//                }
//            }
//            if(temp > maxOnes){
//                maxOnes = temp;
//            }
//            System.out.println(maxOnes);
//        }
//
//        static String task2(String str){
//            // Во фразе "Добро пожаловать на курс по Java" переставить слова в обратном порядке.
//            String[] strArr = str.split(" ");
//            StringBuilder stringBuilder = new StringBuilder();
//            for (int i = 0; i < strArr.length; i++) {
//                stringBuilder.append(strArr[strArr.length-i-1]).append(" ");
//            }
//            return stringBuilder.toString();
//        }
//
//        // Реализовать функцию возведения числа а в степень b. a, b из Z.
//        // Сводя количество выполняемых действий к минимуму.
//        // Пример 1: а = 3, b = 2, ответ: 9
//        // Пример 2: а = 2, b = -2, ответ: 0.25
//        // Пример 3: а = 3, b = 0, ответ: 1
//        static double task3(int a, int b){
//            double pow = 1;
//            if (a == 1 || b == 1){
//                pow = 1;
//            }
//            for (int i = 0; i < Math.abs(b); i++) {
//                pow = pow * a;
//            }
//            return b > 0 ? pow : 1 / pow;
//        }
//
//
//        // Дан массив nums = [3,2,5,3] и число val = 3.
//        // Если в массиве есть числа, равные заданному, нужно перенести эти
//        // элементы в конец массива.
//        // Таким образом, первые несколько (или все) элементов массива должны быть
//        // отличны от заданного, а остальные - равны ему.
//        static void task4(){
//            int val = 3;
//            int count = 0;
//            int[] nums = {3, 2, 5, 3};
//            // int[] nums2 = {3, 3, 3, 3};
//            int[] nums2 = new int[nums.length];
//            Arrays.fill(nums2, val);
//
//            for (int i = 0; i < nums.length; i++) {
//                if (nums[i] != val){
//                    nums2[count] = nums[i];
//                    count++;
//                }
//            }
//            System.out.println(Arrays.toString(nums2));
//
//        }
//    }



