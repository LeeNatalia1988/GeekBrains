package Seminar6.Correct;
/* Создаем абстрактный класс, содержащий минимальное количество методов, которые свойственны всем наследуемым классам
согласно условию (тип и цвет).
* */
abstract class Shape {
    public abstract void getType();

    public abstract void getColor();
}
/* Создаем класс для прямоугольника, наследуемый от класса фигур, добавляем новые свойства, которые необходимы для
описания прямоугольников, не внося изменений в родительский класс
* */
class Rectangle extends Shape {
    Double width;
    Double height;

    @Override
    public void getType() {
        System.out.println("Тип фигуры прямоугольник.");
    }

    @Override
    public void getColor() {
        System.out.println("Цвет всех прямоугольников черный");
    }

    Double getWidth(Double width) {
        return width;
    }

    Double getHeight(Double heigth) {
        return heigth;
    }
}
/* Создаем класс для круга, наследуемый от класса фигур, добавляем новые свойства, которые необходимы для
описания круга, не внося изменений в родительский класс
* */
class Circle extends Shape {
    Double radius;

    @Override
    public void getType() {
        System.out.println("Тип фигуры круг.");
    }

    @Override
    public void getColor() {
        System.out.println("Все круги красные.");
    }
    Double getRadius(Double radius){
        return radius;
    }
}

public class MainCorrect {
    public static void main(String[] args) {
        Shape rectangle = new Rectangle();
        Shape circle = new Circle();
        rectangle.getColor();
        circle.getColor();

        /* Как можно видеть после запуска - данное условие true (LSP) */
        if (rectangle instanceof Rectangle) {
            Rectangle rectangle1 = (Rectangle) rectangle;
            rectangle1.getColor();
        }

        /* Как можно видеть после запуска - данное условие false (LSP) */
        if (rectangle instanceof Circle) {
            Circle rectangle1 = (Circle) rectangle;
            rectangle1.getColor();
        }
        /* Как можно видеть после запуска - данное условие true (LSP) */
        if (circle instanceof Circle) {
            Circle circle1 = (Circle) circle;
            circle1.getColor();
        }
    }
}
