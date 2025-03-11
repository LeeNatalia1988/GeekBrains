package main.Seminar_4;

import java.util.Collections;
import java.util.LinkedList;
import java.util.List;
import java.util.Objects;

public class MyQueue {
    int first;
    private LinkedList<Integer> list_1 = new LinkedList<Integer>();
    public static void main(String[] args) {
    }
    void enqueue(int element) {
        list_1.addLast(element);
    }
    int dequeue(){
        first = list_1.getFirst();
        list_1.removeFirst();
        return first;
    }
    int first(){
        return list_1.getFirst();
    }
    void reverse() {
        int size = list_1.size();
        for (int i = 0; i < size; i++) {
            list_1.addLast(list_1.get(size-i-1));
            list_1.remove(size-i-1);
        }
    }
    }


