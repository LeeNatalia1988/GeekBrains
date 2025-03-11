//package main.Seminar_4;
//
//public class OnSeminar {
//
//    import java.util.ArrayList;
//import java.util.LinkedList;
//import java.util.List;
//import java.util.Queue;
//
//    //**Текст задачи:**
////1) Замерьте время, за которое в ArrayList добавятся 10000 элементов.
////
////2) Замерьте время, за которое в LinkedList добавятся 10000 элементов. Сравните с предыдущим.
//
//        public static void main(String[] args) {
//            task0();
//        }
//
//        static void task0(){
//            List<Integer> list = new ArrayList<>();
//            Queue<Integer> linked = new LinkedList<>();
//
//            long start = System.currentTimeMillis();
//            for (int i = 0; i < 10000000; i++) {
//                list.add(i);
//            }
//            long end = System.currentTimeMillis();
//
//            long secondstart = System.currentTimeMillis();
//            for (int i = 0; i < 10000000; i++) {
//                linked.add(i);
//            }
//            long secondEnd = System.currentTimeMillis();
//            System.out.println((end-start));
//            System.out.println((secondEnd-end));
//
//
//        }
//    }
//    // Реализовать консольное приложение, которое:
////
////1. Принимает от пользователя строку вида
////text~num
////
////1. Нужно рассплитить строку по ~, сохранить text в связный список на позицию num.
////2. Если введено print~num, выводит строку из позиции num в связном списке и удаляет её из списка.
//    static void task0() {
//        List<String> linked = new LinkedList<>();
//        Scanner scanner = new Scanner(System.in);
//        boolean work = true;
//        while (work) {
//            System.out.println("Введи команду! ");
//            String line = scanner.nextLine();
//            String[] arr = line.split("~");
//            int num = Integer.parseInt(arr[1]);
//            String text = arr[0];
//            switch (text) {
//                case "print":
//                    System.out.println(linked.remove(num));
//                    break;
//                case "exit":
//                    System.out.println("До встречи!");
//                    work = false;
//                    break;
//                default:
//                    linked.add(num, text);
//            }
//        }
//    }
//}
//// Реализовать консольное приложение, которое:
////
////1. Принимает от пользователя и “запоминает” строки.
////2. Если введено print, выводит строки так, чтобы последняя введенная была первой в списке, а первая - последней.
////3. Если введено revert, удаляет предыдущую введенную строку из памяти.
//static void task0() {
//        LinkedList<String> linked = new LinkedList<>();
//        Scanner scanner = new Scanner(System.in);
//        boolean work = true;
//        while (work) {
//        System.out.println("Введите строку: ");
//        String text = scanner.nextLine();
//        text = text.trim();
//        switch (text) {
//        case "exit":
//        work = false;
//        break;
//        case "revert":
//        linked.removeLast();
//        break;
//        case "print":
//        ListIterator listIterator = linked.listIterator(linked.size());
//        while (listIterator.hasPrevious()) {
//        System.out.println(listIterator.previous());
//        }
//        break;
//default:
//        linked.add(text);
//        }
//        }
//        }
//        }
//// Работа со стеком и очередью
////1) Написать метод, который принимает массив элементов, помещает их в стэк и выводит на консоль
//// содержимое стэка.
////2) Написать метод, который принимает массив элементов, помещает их в очередь и выводит на консоль
//// содержимое очереди.
//
//static void task0 (){
//        Stack<Integer> stack = new Stack<>();
//        stack.push(1);
//        stack.push(2);
//        stack.push(3);
//        stack.push(4);
//        stack.push(5);
//        stack.add(6);
//        while (!stack.isEmpty()){
//        System.out.println(stack.pop());
//        }
//        Queue<Integer> queue = new LinkedList<>();
//        queue.offer(1);
//        queue.offer(2);
//        queue.offer(3);
//        queue.offer(4);
//        queue.offer(5);
//        while (!queue.isEmpty()){
//        System.out.println(queue.poll());
//        }
//        }
//        }
//
//        //// Реализовать стэк с помощью массива. Нужно реализовать методы:
//////
//////size(), empty(), push(), peek(), pop().
//
//static void stack(){
//        MyStack myStack = new MyStack();
//        myStack.push(1);
//        myStack.push(2);
//        myStack.push(3);
//        myStack.push(4);
//        myStack.push(5);
//        System.out.println(myStack.empty());
//        System.out.println(myStack.pop());
//        System.out.println(myStack.peek());
//        System.out.println(myStack.size());
//
//        }
//
//

//}
