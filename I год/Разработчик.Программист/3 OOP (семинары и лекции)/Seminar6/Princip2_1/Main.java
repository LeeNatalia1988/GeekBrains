package Seminar6.Princip2_1;

// Решение через интерфейс, второй принцип выполняется

public class Main {
    public static void main(String[] args) {
        AnimalSoundManager soundManager = new AnimalSoundManager();
        IMakeSound dog = new Dog("Buddy");
        IMakeSound cat = new Cat("Whiskers");
        IMakeSound bird = new Bird("Polly");

        soundManager.playAnimalSound(dog); // Вывод: Woof!
        soundManager.playAnimalSound(cat); // Вывод: Meow!
        soundManager.playAnimalSound(bird); // Вывод: Chirp!
    }
}

interface IMakeSound {
    void makeSound();
}

class Dog implements IMakeSound {
    private String name;

    public Dog(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }

    @Override
    public void makeSound() {
        System.out.println("Woof!");
    }
}

class Cat implements IMakeSound {
    private String name;

    public Cat(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }

    @Override
    public void makeSound() {
        System.out.println("Meow!");
    }
}

class Bird implements IMakeSound {
    private String name;

    public Bird(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }

    @Override
    public void makeSound() {
        System.out.println("Chirp!");
    }
}

class AnimalSoundManager {
    public void playAnimalSound(IMakeSound animal) {
        animal.makeSound();
    }
}
