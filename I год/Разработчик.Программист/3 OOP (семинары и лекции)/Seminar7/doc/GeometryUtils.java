package doc;

/**
 * Утилитарный класс для работы с геометрическими фигурами.
 */
public class GeometryUtils {
    /**
     * Вычисляет сумму площадей двух фигур.
     *
     * @param shape1 Первая фигура.
     * @param shape2 Вторая фигура.
     * @return Сумма площадей фигур.
     */
    public static double sumAreas(Shape shape1, Shape shape2) {
        return shape1.getArea() + shape2.getArea();
    }
}