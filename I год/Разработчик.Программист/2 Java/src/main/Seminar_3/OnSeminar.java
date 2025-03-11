//package main.Seminar_3;
//
//public class OnSeminar {
//
//    // Даны следующие строки, cравнить их с помощью == и метода equals() класса Object
////String s1 = "hello";
////String s2 = "hello";
////String s3 = s1;
////String s4 = "h" + "e" + "l" + "l" + "o";
////String s5 = new String("hello");
////String s6 = new String(new char[]{'h', 'e', 'l', 'l', 'o'});
//    public class Ex001 {
//        public static void main(String[] args) {
//            String s1 = "hello";
//            String s2 = "hello";
//            String s3 = s1;
//            String s4 = "h" + "e" + "l" + "l" + "o";
//            String s5 = new String("hello");
//            String s6 = new String(new char[]{'h', 'e', 'l', 'l', 'o'});
//
//            System.out.println(s1==s2);
//            System.out.println(s2==s3);
//            System.out.println(s3==s4);
//            System.out.println(s4==s5);
//            System.out.println(s5==s6);
//
//            System.out.println(s1.equals(s2));
//            System.out.println(s2.equals(s3));
//            System.out.println(s3.equals(s4));
//            System.out.println(s4.equals(s5));
//            System.out.println(s5.equals(s6));
//        }
//    }
//
//    // Текст задачи:
//// Заполнить список десятью случайными числами. Отсортировать
//// список методом sort() и вывести его на экран.
//
//import java.util.*;
//
//    public class Ex002 {
//
//        public static void main(String[] args) {
//            task1(createList(10, 0, 10));
//        }
//
//        static void task1(List<Integer> list) {
//            Collections.sort(list, Comparator.reverseOrder());
//            System.out.println(list);
//        }
//        static List<Integer> createList(int size, int min, int max){
//            List<Integer> list = new ArrayList<>(size);
//            for (int i = 0; i < size; i++) {
//                list.add((int) (Math.random() * (max - min) + min));
//            }
//            return list;
//        }
//
//    }
//
//    import java.util.ArrayList;
//import java.util.Iterator;
//import java.util.List;
//
//    // Создать список типа ArrayList<String>. Поместить в него как строки,
//// так и целые числа. Пройти по списку, найти и удалить целые числа.
//    public class Ex003 {
//        public static void main(String[] args) {
//            task2();
//
//        }
//        static  void task2(){
//            List list = new ArrayList();
//            list.add("list");
//            list.add(77);
//            list.add(66);
//            list.add("hello");
//            list.add(22);
//            list.add("word");
//
//            Iterator iterator = list.iterator();
//            while (iterator.hasNext()){
//                Object o = iterator.next();
//                if(o instanceof Integer){
//                    iterator.remove();
//                }
//            }
//            System.out.println(list);
//        }
//
//    }
//
//    //Каталог товаров книжного магазина сохранен в виде двумерного списка List<ArrayList<String>> так,
//// что на 0й позиции каждого внутреннего списка содержится название жанра, а на остальных позициях
//// - названия книг. Напишите метод для заполнения данной структуры.
//// фантастика, наименование_книги, ...
//// приключения, наименование_книги, ...
//// классика, наименование_книги, ...
//// детектив, наименование_книги, ...
//
//import java.util.ArrayList;
//import java.util.List;
//
//    public class Ex004 {
//        public static void main(String[] args) {
//            task04();
//        }
//
//        public static void task04() {
//            List<ArrayList<String>> catalog = new ArrayList<>();
//            addBook("Фантастика", "Марсианин", catalog);
//            addBook("Жанр2", "Книга21", catalog);
//            addBook("Жанр2", "Книга22", catalog);
//            addBook("Жанр3", "Книга31", catalog);
//            addBook("Жанр4", "Книга31", catalog);
//            System.out.println(catalog);
//        }
//        public static void addBook(String type, String name, List<ArrayList<String>> catalog){
//            for (int i = 0; i < catalog.size(); i++) {
//                if (catalog.get(i).get(0).equals(type)) {
//                    catalog.get(i).add(name);
//                    return;
//                }
//            }
//            ArrayList<String> t = new ArrayList<>();
//            t.add(type);
//            t.add(name);
//            catalog.add(t);
//        }
//    }
//}
