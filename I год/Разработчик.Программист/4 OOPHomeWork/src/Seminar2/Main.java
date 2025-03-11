package Seminar2;

import java.net.Socket;

import static Seminar2.Rectangle.*;

public class Main {
    public static void main(String[] args) {
        Rectangle rectangle = new Rectangle();
        Double Height = Rectangle.Height;

        System.out.println("Прямоугольник шириной: " + rectangle.getWidth() + ", высотой: " + Height + " и цветом: " + rectangle.getColor());
        System.out.println("Площадь прямоугольника: " + rectangle.calculateArea());
        System.out.println("Периметр прямоугольника: " + rectangle.calculatePerimeter());
    }
}
