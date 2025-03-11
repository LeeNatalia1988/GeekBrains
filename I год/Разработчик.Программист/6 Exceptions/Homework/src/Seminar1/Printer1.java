//package Seminar1;//
//////Реализуйте 3 метода, чтобы в каждом из них получить разные исключения.
//////
//////        Метод arrayOutOfBoundsException - Ошибка, связанная с выходом за пределы массива
//////
//////        Метод divisionByZero - Деление на 0
//////
//////        Метод numberFormatException - Ошибка преобразования строки в число
//////
//////        Важно: они не должны принимать никаких аргументов
////
////package Seminar1;
////
////public class Answer {
////    public static void arrayOutOfBoundsException() {
////        int[] ans = new int[4];
////        int res = ans[5];
////    }
////
////
////
////    public static void divisionByZero() {
////        int res = 1/0;
////    }
////
////    public static void numberFormatException() {
////        String str = "abcd";
////        int res = Integer.parseInt(str);
////    }
////}
//
//import java.util.Arrays;
//
//class Answer {
//    public int[] subArrays(int[] a, int[] b) {
//        if (a.length != b.length) {
//            int[] c = new int[1];
//            return c;
//        }
//        else {
//            int[] c = new int[a.length];
//            for(int i = 0; i < a.length; i++){
//                c[i] = a[i] - b[i];
//            }
//            return c;
//        }
//    }
//
//
//    }
//
//
//// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
//public class Printer1{
//    public static void main(String[] args) {
//        int[] a = {};
//        int[] b = {};
//
//        if (args.length == 0) {
//            // При отправке кода на Выполнение, вы можете варьировать эти параметры
//            a = new int[]{4, 5, 6};
//            b = new int[]{1, 2, 3, 5};
//        }
//        else{
//            a = Arrays.stream(args[0].split(", ")).mapToInt(Integer::parseInt).toArray();
//            b = Arrays.stream(args[1].split(", ")).mapToInt(Integer::parseInt).toArray();
//        }
//
//        Answer ans = new Answer();
//        String itresume_res = Arrays.toString(ans.subArrays(a, b));
//        System.out.println(itresume_res);
//    }
//}
//
