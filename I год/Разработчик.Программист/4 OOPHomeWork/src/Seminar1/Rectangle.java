package Seminar1;
/*
* Реализуйте класс "Прямоугольник" (Rectangle), который имеет свойства ширина (width) и высота (height).
* Класс должен обладать следующими методами:

Конструктор без параметров, который создает прямоугольник с шириной и высотой по умолчанию.
Конструктор, который принимает значения ширины и высоты и создает прямоугольник с заданными значениями.
Методы доступа (геттеры и сеттеры) для свойств ширины и высоты.
Метод "вычислить площадь" (calculateArea), который возвращает площадь прямоугольника (ширина * высота).
Метод "вычислить периметр" (calculatePerimeter), который возвращает периметр прямоугольника
* (2 * (ширина + высота)).*/
public class Rectangle {
    private Double width;
    private Double height;
    public void setWidth(Double width){
        this.width = width;
    }
    public void setHeight(Double height){
        this.height = height;
    }
    public double getWidth(){
        return width;
    }
    public double getHeight(){
        return height;
    }
    public Rectangle(){
        this.width = 10.0;
        this.height = 20.0;
    }
    public Rectangle(Double width, Double height){
        this.width = width;
        this.height = height;
    }
    public Double calculateArea(){
        return getWidth()*getHeight();
    }
    public Double calculatePerimeter(){
        return 2 * (getWidth() + getHeight());
    }
}
