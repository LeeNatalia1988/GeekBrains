package Seminar3;

/*
* Класс для прямоугольников*/
public class Rectangle implements IShape {
    /*
    * Задаем необходимые параметры для создания класса и задаем конструктор*/

    private Double width;
    private Double height;
    private String color;

    private Double area;
    private Double perimeter;

    public Rectangle(Double width, Double height, String color){
        this.width = width;
        this.height = height;
        this.color = color;
        this.area = calculateArea();
        this.perimeter = calculatePerimeter();

    }

    /*
    * Перегрузка методов по умолчанию для прямоугольника*/
    @Override
    public double getWidth(){
        return width;
    };
    @Override
    public double getHeight() {
        return height;
    }
    @Override
    public String getColor(){
        return color;
    }

    /*
    * Перегрузка методов для расчета площади и периметра прямоугольника*/
    @Override
    public Double calculateArea(){
        return getWidth()*getHeight();
    }
    @Override
    public Double calculatePerimeter(){ return 2 * (getWidth() + getHeight()); }
    @Override
    /*
    * Перегрузка метода для распечатки всех необходимых параметров, включая площадь и периметр*/
    public String toString() {
        return "Прямоугольник: {" +
                "шириной = " + width +
                ", высотой = " + height +
                ", цветом = " + color +
                ", площадью = " + area +
                ", периметром = " + perimeter +
                '}';
    }
    /*
    * Метод для получения площади (понадобится для компаратора)*/
    public double getArea() {
        return area;
    }
}

