package singleton;

public class Main {
    public static void main(String[] args) {
        // Попробуем получить экземпляр Singleton
        Singleton singleton1 = Singleton.getInstance();
        Singleton singleton2 = Singleton.getInstance();

        // Проверим, что это один и тот же объект
        if (singleton1 == singleton2) {
            System.out.println("singleton1 и singleton2 указывают на один и тот же объект");
        } else {
            System.out.println("singleton1 и singleton2 разные объекты");
        }

        // Вызовем метод showMessage()
        singleton1.showMessage(); // Вывод: Hello, I am a singleton!
        singleton2.showMessage(); // Вывод: Hello, I am a singleton!

        
    }
}
