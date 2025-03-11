package Task5;

class MyClass<T> {
    private T val;

    public MyClass() {
        // Пустой конструктор
    }

    public MyClass(T defaultValue) {
        this.val = defaultValue;
    }

    public void setValue(T value) {
        this.val = value;
    }

    public T getValue() {
        return val;
    }
}

public class Main {
    public static void main(String[] args) {
        // Создаем экземпляр MyClass с типом Integer
        MyClass<Integer> myInt = new MyClass<>();
        myInt.setValue(10);
        System.out.println(myInt.getValue()); // Выведет: 10

        // Создаем экземпляр MyClass с типом String и передаем значение по умолчанию
        MyClass<String> myString = new MyClass<>("Hello");
        System.out.println(myString.getValue()); // Выведет: Hello
    }
}