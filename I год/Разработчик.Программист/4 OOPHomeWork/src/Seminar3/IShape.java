package Seminar3;
/*
* Интерфейс для фигур с методами по умолчанию
* */
public interface IShape {
    Double width = 1.0;
    Double height = 1.0;
    String color = "Черный";

    public default double getWidth(){
        return width;
    };
    public default double getHeight() {
        return height;
    }
    public default String getColor(){
        return color;
    }
    public default Double calculateArea(){
        return getWidth()*getHeight();
    }
    public default Double calculatePerimeter(){ return 2 * (getWidth() + getHeight()); }
}
