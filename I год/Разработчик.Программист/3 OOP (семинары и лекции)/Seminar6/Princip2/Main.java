package Seminar6.Princip1.Princip2;

// Решение через класс, но второй принцип не выполняется

public class Main {
    public static void main(String[] args) {
        AnimalSoundManager soundManager = new AnimalSoundManager();
        Animal dog = new Dog("Buddy");
        Animal cat = new Cat("Whiskers");

        soundManager.playAnimalSound(dog); // Вывод: Woof!
        soundManager.playAnimalSound(cat); // Вывод: Meow!
    }
}

class Animal {
    private String name;

    public Animal(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }

    public void makeSound() {
        System.out.println("Unknown sound");
    }
}

class Dog extends Animal {
    public Dog(String name) {
        super(name);
    }

    @Override
    public void makeSound() {
        System.out.println("Woof!");
    }
}

class Cat extends Animal {
    public Cat(String name) {
        super(name);
    }

    @Override
    public void makeSound() {
        System.out.println("Meow!");
    }
}

class AnimalSoundManager {
    public void playAnimalSound(Animal animal) {
        animal.makeSound();
    }
}