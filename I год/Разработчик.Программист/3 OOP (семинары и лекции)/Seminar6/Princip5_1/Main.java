package Seminar6.Princip5_1;

interface Animal {
    void makeSound();
}

class Dog implements Animal {
    @Override
    public void makeSound() {
        System.out.println("Dog barks.");
    }
}

class Cat implements Animal {
    @Override
    public void makeSound() {
        System.out.println("Cat meows.");
    }
}

class PetOwner {
    private Animal pet;

    public PetOwner(Animal pet) {
        this.pet = pet;
    }

    public void makePetSound() {
        pet.makeSound();
    }
}

public class Main {
    public static void main(String[] args) {
        Dog dog = new Dog();
        PetOwner dogOwner = new PetOwner(dog);
        dogOwner.makePetSound(); // Вывод: Dog barks.

        Cat cat = new Cat();
        PetOwner catOwner = new PetOwner(cat);
        catOwner.makePetSound(); // Вывод: Cat meows.
    }
}