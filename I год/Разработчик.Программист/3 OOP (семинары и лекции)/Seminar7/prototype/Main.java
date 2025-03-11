package prototype;

// Прототип
abstract class Shape implements Cloneable {
    private String type;

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    @Override
    protected Object clone() throws CloneNotSupportedException {
        return super.clone();
    }
}

// Конкретная реализация прототипа
class Circle extends Shape {
    
    public Circle() {
        setType("Circle");
    }
}

// Конкретная реализация прототипа
class Square extends Shape {
    public Square() {
        setType("Square");
    }
}

public class Main {
    public static void main(String[] args) {
        // Создаем оригинальные объекты
        Circle originalCircle = new Circle();
        Square originalSquare = new Square();

        try {
            // Клонируем оригинальные объекты
            Circle clonedCircle = (Circle) originalCircle.clone();
            Square clonedSquare = (Square) originalSquare.clone();

            // Проверим, что объекты скопировались правильно
            System.out.println("Original Circle Type: " + originalCircle.getType()); // Output: Original Circle Type: Circle
            System.out.println("Cloned Circle Type: " + clonedCircle.getType()); // Output: Cloned Circle Type: Circle

            System.out.println("Original Square Type: " + originalSquare.getType()); // Output: Original Square Type: Square
            System.out.println("Cloned Square Type: " + clonedSquare.getType()); // Output: Cloned Square Type: Square
        } catch (CloneNotSupportedException e) {
            e.printStackTrace();
        }
    }
}
