package ru.geekbrains.lesson2;

public class MyArrayDataException extends CustomArrayException{
    public MyArrayDataException(String message, int x, int y) {
        super(message, x, y);
    }
}
