package Seminar6.Incorrect;

/* Нарушение принципа разделения интерфейса - данный интерфейс не нужен согласно поставленной задаче.
* */
interface Cat{
    void meow();
}

class Rectangle extends Shape {

    public void getType() {
        System.out.println("Тип фигуры прямоугольник.");
    }

    @Override
    public Double getWidth(Double width) {
        return width;
    }

    @Override
    public Double getHeight(Double height) {
        return height;
    }


    public void getColor() {
        System.out.println("Цвет всех прямоугольников черный.");
    }
}
/* Нарушение принципа единственной ответственности - есть много поводов внести изменение в данный класс, так как родительский
класс имеет методы, которые не свойственны данному классу.
 */

class Circle extends Shape {


    public void getType() {

    }

    @Override
    public Double getWidth(Double width) {
        return width;
    }

    @Override
    public Double getHeight(Double heigth) {
        return heigth;
    }


    public void getColor() {
        System.out.println("Цвет всех кругов красный.");

    }
}

public class MainIncorrect {
    public static void main(String[] args) {
        Shape rectangle = new Rectangle();
        Shape circle = new Circle();

        rectangle.getColor("черный");
        circle.getColor("красный");
/* Науршение LSP + различное поведение для getColor в зависимости от класса.
 */
        Rectangle rectangle1 = (Rectangle) rectangle;
        rectangle1.getColor();
        Circle circle1 = (Circle) circle;
        circle1.getColor();
    }
}

/* Исправленная версия в MainCorrect.
* */
