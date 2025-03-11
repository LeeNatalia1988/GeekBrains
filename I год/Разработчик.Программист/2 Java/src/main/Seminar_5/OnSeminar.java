//package main.Seminar_5;
//
//public class OnSeminar {

//
//    //Создать структуру для хранения Номеров паспортов и Фамилий сотрудников организации.
////123456 Иванов
////321456 Васильев
////234561 Петрова
////234432 Иванов
////654321 Петрова
////345678 Иванов
////Вывести данные по сотрудникам с фамилией Иванов.
//
//        public static void main(String[] args) {
//            task();
//        }
//
//        static void task(){
//            Ex001_Passport passport = new Ex001_Passport();
//            passport.add("123456", "Иванов");
//            passport.add("321456", "Васильев");
//            passport.add("234561", "Петрова");
//            passport.add("234432", "Иванов");
//            passport.add("654321", "Петрова");
//            passport.add("345678", "Иванов");
//
//            System.out.print(passport.getByLastName("Иванов"));
//            System.out.println(passport.getByPassNum("321456"));
//            System.out.println(passport.getAll_2());
//
//        }
//
//
//    }
//}
//
//private Map<String, String> map = new HashMap<>();
//
//        void add(String passNum, String lastName){
//        map.put(passNum, lastName);
//        }
//
//        String getByPassNum(String passNum){
//        return passNum + " : " + map.get(passNum);
//        }
//
//        String getByLastName(String lastName){
//        StringBuilder stringBuilder = new StringBuilder();
//        for (Map.Entry entry:
//        map.entrySet()) {
//        if (entry.getValue().equals(lastName)) {
//        stringBuilder.append(entry.getKey());
//        stringBuilder.append(" : ");
//        stringBuilder.append(entry.getValue());
//        stringBuilder.append(" \n ");
//
//        }
//        }
//        return stringBuilder.toString();
//        }
//
//        String getAll_1(String lastName){
//        StringBuilder stringBuilder = new StringBuilder();
//        for (Map.Entry entry:
//        map.entrySet()) {
//        stringBuilder.append(entry.getKey());
//        stringBuilder.append(" : ");
//        stringBuilder.append(entry.getValue());
//        stringBuilder.append("\n");
//
//        }
//        return stringBuilder.toString();
//        }
//        String getAll_2(){
//        return map.toString();
//        }
//
//
//
//        }
//
////Даны 2 строки, написать метод, который вернет true, если эти строки являются изоморфными и false,
//// если нет. Строки изоморфны, если одну букву в первом слове можно заменить на некоторую букву
//// во втором слове, при этом
////  1. повторяющиеся буквы одного слова меняются на одну и ту же букву с сохранением порядка следования.
////  (Например, add - egg изоморфны)
////  2. буква может не меняться, а остаться такой же. (Например, note - code)
////Пример 1:
////Input: s = "foo", t = "bar"
////Output: false
////Пример 2:
////Input: s = "paper", t = "title"
////Output: true
//
//public class Ex002 {
//    public static void main(String[] args) {
//        String str1 = "foo";
//        String str2 = "bar";
//        System.out.println(task(str1, str2));
//    }
//
//    static boolean task(String str1, String str2){
//
//        if (str1.length() != str2.length()) return false;
//        char[] c1 = str1.toCharArray();
//        char[] c2 = str2.toCharArray();
//        Map<Character,Character> map = new HashMap<>();
//
//        for (int i = 0; i < c1.length; i++) {
//            if(map.containsKey(c1[i])){
//                if(c2[i] != map.get(c1[i])) return false;
//            } else {
//                map.put(c1[i],c2[i]);
//            }
//        }
//        return true;
//    }
//}
//
//// Написать программу, определяющую правильность расстановки скобок в выражении.
////Пример 1: a+(d*3) - истина
////Пример 2: [a+(1*3) - ложь
////Пример 3: [6+(3*3)] - истина
////Пример 4: {a}[+]{(d*3)} - истина
////Пример 5: <{a}+{(d*3)}> - истина
////Пример 6: {a+]}{(d*3)} - ложь
//
//System.out.println(task2("{a+]}{(d*3)}"));
//        System.out.println(task2("{a}+{(d*3)}"));
//
//        }
//
//static boolean task2(String str){
//        Stack<Character> stack = new Stack<>();
//        char[] c = str.toCharArray();
//        Map<Character,Character> map = new HashMap<>();
//        map.put('(',')');
//        map.put('{','}');
//        map.put('<','>');
//        map.put('[',']');
//        for (int i = 0; i < c.length; i++) {
//        if(map.containsKey(c[i])) stack.push(c[i]);
//        if (map.containsValue(c[i])){
//        if (stack.isEmpty() || map.get(stack.pop()) != c[i]) return false;
//        }
//        }
//        if (!stack.isEmpty()) return false;
//        return true;
//        }
//        }
//
//// Взять набор строк, например,
////
//// Мороз и солнце день чудесный
//// Еще ты дремлешь друг прелестный
//// Пора красавица проснись.
////
//// Написать метод, который отсортирует эти строки по длине с помощью TreeMap.
//// Строки с одинаковой длиной не должны “потеряться”.
//
//        System.out.println(task(" Мороз и солнце день чудесный\n" +
//        "Еще ты дремлешь друг прелестный\n" +
//        "Пора красавица проснись."));
//        }
//
//static String task(String str){
//
//        str = str.replace("/n", " ");
//        str = str.replace(".", " ");
//        String[] words = str.split(" ");
//        Map<Integer, List<String>> map = new TreeMap<>();
//
//        for (String word:
//        words) {
//        int len = word.length();
//        if (map.containsKey(len)){
//        List<String> list = map.get(len);
//        list.add(word);
//        }
//        else {
//        List<String> list = new ArrayList<>();
//        list.add(word);
//        map.put(len, list);
//        }
//
//        }
//        return map.toString();
//        }
//        }


