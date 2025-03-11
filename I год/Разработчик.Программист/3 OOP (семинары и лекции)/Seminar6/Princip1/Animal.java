package Seminar6.Princip1;

// Все мотоды были в одном классе, разбили их на два класса

public class Animal {
    private String name;
    private int age;

    public Animal(String name, int age) {
        this.name = name;
        this.age = age;
    }

    // Не важные действия для жизни
    public void move() {
        // Код для перемещения животного
    }

    public void makeSound() {
        // Код для издания звука
    }

}

// Жизнено важные действия
class AnimalActions {

    public void eat() {
        // Код для питания животного
    }

    public void sleep() {
        // Код для сна животного
    }

    public void reproduce() {
        // Код для размножения животного
    }

}