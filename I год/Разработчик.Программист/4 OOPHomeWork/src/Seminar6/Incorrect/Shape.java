package Seminar6.Incorrect;

/* Нарушение принципа открытости\закрытости, так как требует изменений для фигур, не имеющих длину\ширину, а, например,
только радиус (круг)
 */
/* Нарушение принципа инверсии зависимостей - отсутствуют абстракции.
* */
public class Shape {
    Double width = null;
    Double heigth = null;
    String type;
    String color;

    void getType(String type) {
        System.out.println("Тип фигуры " + type);
    }

    Double getWidth(Double width) {
        return width;
    }

    ;

    Double getHeight(Double heigth) {
        return heigth;
    }

    void getColor(String color) {
        System.out.println("Цвет фигуры " + color);
    }
}
