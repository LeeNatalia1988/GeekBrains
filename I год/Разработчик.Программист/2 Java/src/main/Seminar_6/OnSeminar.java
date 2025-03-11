//package main.Seminar_6;
//
//public class OnSeminar {
//
//    import java.util.*;
//
//    //1. Создайте HashSet, заполните его следующими числами: {1, 2, 3, 2, 4, 5, 6, 3}.
//// Распечатайте содержимое данного множества.
////2. Создайте LinkedHashSet, заполните его следующими числами: {1, 2, 3, 2, 4, 5, 6, 3}.
//// Распечатайте содержимое данного множества.
////3. Создайте TreeSet, заполните его следующими числами: {1, 2, 3, 2, 4, 5, 6, 3}.
//// Распечатайте содержимое данного множества.
//    public class Ex001 {
//        public static void main(String[] args) {
//            programm();
//        }
//
//        static void programm(){
//            Integer[] arr = new Integer[]{1, 2, 3, 11, 2, 9, 4, 5, 6, 3};
//            Set<Integer> set1 = new HashSet<>(Arrays.asList(arr));
//            Set<Integer> set2 = new LinkedHashSet<>(Arrays.asList(arr));
//            Set<Integer> set3 = new TreeSet<>(Arrays.asList(arr));
//
//            System.out.println(set1);
//            System.out.println(set2);
//            System.out.println(set3);
//        }
//    }
//
//    // 1. Напишите метод, который заполнит массив из 1000 элементов случайными цифрами от 0 до 24.
////2. Создайте метод, в который передайте заполненный выше массив и с помощью Set вычислите процент
//// уникальных значений в данном массиве и верните его в виде числа с плавающей запятой.
////Для вычисления процента используйте формулу:
////процент уникальных чисел = количество уникальных чисел * 100 / общее количество чисел в массиве.
//    public class Ex002 {
//        public static void main(String[] args) {
//            task();
//        }
//        static void task(){
//            System.out.println(unicPercent(createArr(100,0,24)));
//        }
//        static Integer[] createArr(int size, int min, int max){
//            Integer[] arr = new Integer[size];
//            for (int i = 0; i < arr.length; i++) {
//                arr[i] = (int)(Math.random()*(max-min+1)+min);
//            }
//            return arr;
//        }
//
//        static double unicPercent(Integer[] arr){
//            Set<Integer> set = new HashSet<>(Arrays.asList(arr));
//            double percent = set.size() + 100.0 / arr.length;
//            return percent;
//        }
//
//    }
//
//    //  1. Продумайте структуру класса Кот. Какие поля и методы будут актуальны для приложения, которое является
////а) информационной системой ветеринарной клиники
////б) архивом выставки котов
////в) информационной системой Театра кошек Ю. Д. Куклачёва
////Можно записать в текстовом виде, не обязательно реализовывать в java.
//
//// 1. Реализуйте 1 из вариантов класса Cat из предыдущего задания, можно использовать не все придуманные
//// поля и методы. Создайте несколько экземпляров этого класса, выведите их в консоль.
////2. Добейтесь того, чтобы при выводе в консоль объекта типа Cat, выводилась его кличка, цвет и возраст
//// (или другие параметры на ваше усмотрение).
//
//import java.util.HashSet;
//import java.util.Set;
//
//    //1. Создайте множество, в котором будут храниться экземпляры класса Cat - HashSet<Cat>.
//// Поместите в него некоторое количество объектов.
////
////2. Создайте 2 или более котов с одинаковыми параметрами в полях. Поместите их во множество.
//// Убедитесь, что все они сохранились во множество.
////
////3. Создайте метод
////**public boolean**
////equals(Object o)
////
////Пропишите в нём логику сравнения котов по параметрам, хранимым в полях.
//// То есть, метод должен возвращать true, только если значения во всех полях сравниваемых объектов равны.
////
////4. Создайте метод
////**public int hashCode()**
////который будет возвращать hash, вычисленный на основе полей класса Cat.
//// (Можно использовать Objects.hash(...))
////
////5. Выведите снова содержимое множества из пункта 2, убедитесь, что дубликаты удалились.
//    public class Ex003 {
//        public static void main(String[] args) {
//            Cat cat1 = new Cat("Муся", "Иванов", "Персидская", 5);
//            Cat cat2 = new Cat("Барсик", "Петров", "Британская", 2);
//            Cat cat3 = new Cat("Мурка", "Василий", "Майкун", 8);
//            Cat cat4 = new Cat("Мурка", "Василий", "Майкун", 8);
//
//            Set<Cat> set = new HashSet<>();
//            set.add(cat1);
//            set.add(cat2);
//            set.add(cat3);
//            set.add(cat4);
//
////        System.out.println(cat1.getName());
////        System.out.println(cat2.getName());
////        System.out.println(cat1.toString());
//
////        System.out.println(cat1);
////        System.out.println(cat2);
////        System.out.println(cat3);
//
//            System.out.println(set);
//
//        }
//
//
//    }
//}
