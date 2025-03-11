package doc;

/**
 * Класс, представляющий прямоугольник.
 */
public class Rectangle {
    private int width;
    private int height;

    /**
     * Создает новый прямоугольник с заданными шириной и высотой.
     *
     * @param width  Ширина прямоугольника.
     * @param height Высота прямоугольника.
     */
    public Rectangle(int width, int height) {
        this.width = width;
        this.height = height;
    }

    /**
     * Вычисляет площадь прямоугольника.
     *
     * @return Площадь прямоугольника.
     */
    public int getArea() {
        return width * height;
    }

    // Геттеры и сеттеры для ширины и высоты
    // ...
}
