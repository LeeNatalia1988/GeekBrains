//TODO
package main.Seminar_4;

import java.util.*;

//Реализуйте очередь с помощью LinkedList со следующими методами:enqueue() - помещает элемент в конец очереди,
//        dequeue() - возвращает первый элемент из очереди и удаляет его, first() - возвращает первый элемент
//        из очереди, не удаляя.
// Пусть дан LinkedList с несколькими элементами. Реализуйте метод, который вернет “перевернутый” список.

public class Task_1 {
    public static void main(String[] args) {
        MyQueue list_1 = new MyQueue();
        list_1.enqueue(1);
        list_1.enqueue(45);
        list_1.enqueue(54);
        list_1.enqueue(65);
        list_1.enqueue(321);
        System.out.println("Исходный список: ");
        System.out.println(list_1);
        System.out.println("Помещаем элемент в конец очереди: ");
        list_1.enqueue(5);
        System.out.println(list_1);
        System.out.println("Возвращаем первый элемент очереди и удаляем его: " + list_1.dequeue());
        System.out.println("Возвращаем первый элемент очереди, не удаляя его: " + list_1.first());
        System.out.println("Перевернутый список: ");
        list_1.reverse();
        System.out.println(list_1);
    }
    }




