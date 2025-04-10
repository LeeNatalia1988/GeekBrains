package Seminar1;//package Seminar1;
//
//public class Printer {
//    public static void main(String[] args) {
//        Answer ans = new Answer();
//        try {
//            ans.arrayOutOfBoundsException();
//        } catch (ArrayIndexOutOfBoundsException e) {
//            System.out.println("Выход за пределы массива");
//        }
//
//        try {
//            ans.divisionByZero();
//        } catch (ArithmeticException e) {
//            System.out.println("Деление на ноль");
//        }
//
//        try {
//            ans.numberFormatException();
//        } catch (NumberFormatException e) {
//            System.out.println("Ошибка преобразования строки в число");
//        }
//    }
//}
import java.util.Arrays;

class Answer {
    /**
     *
     * @param a
     * @param b
     * @return
     */
    public int[] divArrays(int[] a, int[] b){
        if (a.length != b.length) {
           int[] c = new int[1];
           return c;
        }
        else {
            int[] c = new int[a.length];
            for(int i = 0; i < a.length; i++){
                c[i] = a[i]/b[i];
            }
            return c;
        }


    }
}

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Printer{
    public static void main(String[] args) {
        int[] a = {};
        int[] b = {};

        if (args.length == 0) {
            // При отправке кода на Выполнение, вы можете варьировать эти параметры
            a = new int[]{12, 8, 16, 25};
            b = new int[]{4, 2, 4};
        }
        else{
            a = Arrays.stream(args[0].split(", ")).mapToInt(Integer::parseInt).toArray();
            b = Arrays.stream(args[1].split(", ")).mapToInt(Integer::parseInt).toArray();
        }

        Answer ans = new Answer();
        String itresume_res = Arrays.toString(ans.divArrays(a, b));
        System.out.println(itresume_res);
    }
}