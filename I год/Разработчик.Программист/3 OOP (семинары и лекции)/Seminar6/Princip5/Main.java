package Seminar6.Princip5;

// Принцип инверсии зависимости

class Dog {
    public void bark() {
        System.out.println("Dog barks.");
    }
}

class DogOwner {
    private Dog dog;

    public DogOwner() {
        this.dog = new Dog();
    }

    public void makeDogBark() {
        dog.bark();
    }
}

public class Main {
    public static void main(String[] args) {
        DogOwner dogOwner = new DogOwner();
        dogOwner.makeDogBark(); // Вывод: Dog barks.
    }
}
