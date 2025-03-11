// package main.Seminar_2;
// import java.io.FileWriter;
// import java.io.IOException;
// import java.util.logging.FileHandler;
// import java.util.logging.Level;
// import java.util.logging.Logger;
// import java.util.logging.SimpleFormatter;
// import java.util.Arrays;
// public class OnSeminar {
//     public static void main(String[] args) {
//         StringBuilder string = new StringBuilder();
//         for(int i=0; i<7; i++)
//         {
//             string.append("#");
//             System.out.println(string);

//         }
//     }
// }

    //     Текст задачи:
//     Дано четное число N (>0) и символы c1 и c2. Написать метод, который вернет строку длины N,
//     которая состоит из чередующихся символов c1 и c2, начиная с c1.
//     static String task0 (int n, char c1, char c2){
//         if(n%2==0){
//             StringBuilder stringBuilder = new StringBuilder();
//             for (int i = 0; i < n/2; i++) {
//                 stringBuilder.append(c1).append(c2);
//             }
//             return stringBuilder.toString();
//         } else {
//             System.out.println("N is not even number! ");
//             return null;
//         }

//     }
// }

// System.out.println(task1("aaaaaaaaabbbbbbbbbbbbbbbbcdddddddd"));
// Напишите метод, который сжимает строку. Пример: вход aaaabbbcdd. Ds[jl a4b3c1d2
//static String task1(String str){
        /* Напишите метод, который сжимает строку. Пример: вход aaaabbbcdd. Выход: a4b3c1d2*/
        // char[] chars = str.toCharArray();
        // Arrays.sort(chars);
        // int count = 0;
        // StringBuilder stringBuilder = new StringBuilder();

        // for (int i = 1; i < chars.length ; i++) {
        // if(chars[i] == chars[i-1]) count++;
        // else {
        // stringBuilder.append(chars[i-1]).append(count+1);
        // count = 0;
        // }
        // }
        // stringBuilder.append(chars[chars.length-1]).append(count+1);
        // return stringBuilder.toString();
        // }
        // }

        // task3(wordRepeat("Test", 20));
        // }

//     Напишите метод, который составит строку, состоящую из 100 повторений слова TEST и метод,
// который запишет эту строку в простой текстовый файл, обработайте исключения.

//static String wordRepeat(String word, int n){
//        StringBuilder stringBuilder = new StringBuilder();
//        for (int i = 0; i < n; i++) {
//            stringBuilder.append(word);
//        }
//        System.out.println(stringBuilder.toString());
//        return stringBuilder.toString();
//         return word.repeat(n);
//         }

// static void task3(String str) {
//         String path = "log.txt";



//         Logger logger = Logger.getAnonymousLogger();
//         FileHandler fileHandler = null;
//         try {
//         fileHandler = new FileHandler(path, true);
//         } catch (IOException e){
//         e.printStackTrace();
//         }
//         logger.addHandler(fileHandler);
//         SimpleFormatter simpleFormatter = new SimpleFormatter();
//         fileHandler.setFormatter(simpleFormatter);

//         try (FileWriter fileWriter = new FileWriter("g/g/g//g/g/text.txt", true);){
//         fileWriter.write(str);
//         fileWriter.flush();
//         } catch (Exception e){
//         e.printStackTrace();
//         logger.log(Level.WARNING, e.getMessage());
//         }

//         fileHandler.close();
//         logger.getHandlers()[0].close();

//         }
//         }

//         System.out.println(Task05("1 232 21"));
//         }

/**
 * Напишите метод, который принимает на вход строку (String)
 * и определяет является ли строка палиндромом (возвращает boolean значение).
 */

// public static boolean Task05(String text) {
//         StringBuilder stringBuilder = new StringBuilder(text);
//         String newText = stringBuilder.reverse().toString();
//         return newText.equals(text);
//         }
//         }



