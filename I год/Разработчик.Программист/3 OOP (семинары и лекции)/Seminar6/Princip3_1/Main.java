package Seminar6.Princip3_1;

interface Fetchable {
    void fetch();
}

interface Scratchable {
    void scratch();
}

abstract class Animal {
    public abstract void makeSound();
}

class Dog extends Animal implements Fetchable {
    @Override
    public void makeSound() {
        System.out.println("Dog barks.");
    }

    @Override
    public void fetch() {
        System.out.println("Dog fetches.");
    }
}

class Cat extends Animal implements Scratchable {
    @Override
    public void makeSound() {
        System.out.println("Cat meows.");
    }

    @Override
    public void scratch() {
        System.out.println("Cat scratches.");
    }
}

public class Main {
    public static void main(String[] args) {
        Animal animal1 = new Dog();
        Animal animal2 = new Cat();

        animal1.makeSound(); // Вывод: Dog barks.
        animal2.makeSound(); // Вывод: Cat meows.

        if (animal1 instanceof Fetchable) {
            Fetchable dog = (Fetchable) animal1;
            dog.fetch(); // Вывод: Dog fetches.
        }

        if (animal2 instanceof Scratchable) {
            Scratchable cat = (Scratchable) animal2;
            cat.scratch(); // Вывод: Cat scratches.
        }
    }
}



// abstract class Animal {
//     public abstract void makeSound();
// }

// class Dog extends Animal {
//     @Override
//     public void makeSound() {
//         System.out.println("Dog barks.");
//     }

//     public void fetch() {
//         System.out.println("Dog fetches.");
//     }
// }

// class Cat extends Animal {
//     @Override
//     public void makeSound() {
//         System.out.println("Cat meows.");
//     }

//     public void scratch() {
//         System.out.println("Cat scratches.");
//     }
// }

// public class Main {
//     public static void main(String[] args) {
//         Dog dog = new Dog();
//         Cat cat = new Cat();

//         dog.makeSound();
//         cat.makeSound();
//     }
// }




// abstract class Animal {
//     public abstract void makeSound();
// }

// class Dog extends Animal {
//     @Override
//     public void makeSound() {
//         System.out.println("Dog barks.");
//     }

//     public void fetch() {
//         System.out.println("Dog fetches.");
//     }
// }

// class Cat extends Animal {
//     @Override
//     public void makeSound() {
//         System.out.println("Cat meows.");
//     }

//     public void scratch() {
//         System.out.println("Cat scratches.");
//     }
// }

// public class Main {
//     public static void main(String[] args) {
//         Animal[] animals = new Animal[2];
//         animals[0] = new Dog();
//         animals[1] = new Cat();

//         for (Animal animal : animals) {
//             animal.makeSound();
//         }
//     }
// }



// abstract class Animal {
//     public abstract void makeSound();
// }

// class Dog extends Animal {
//     @Override
//     public void makeSound() {
//         System.out.println("Dog barks.");
//     }

//     public void fetch() {
//         System.out.println("Dog fetches.");
//     }
// }

// class Cat extends Animal {
//     @Override
//     public void makeSound() {
//         System.out.println("Cat meows.");
//     }

//     public void scratch() {
//         System.out.println("Cat scratches.");
//     }
// }

// public class Main {
//     public static void main(String[] args) {
//         Animal animal1 = new Dog();
//         Animal animal2 = new Cat();

//         animal1.makeSound(); // Вывод: Dog barks.
//         animal2.makeSound(); // Вывод: Cat meows.

//         // Теперь нет нарушения принципа LSP
//         if (animal1 instanceof Dog) {
//             Dog dog = (Dog) animal1; // Преобразование типа
//             dog.fetch(); // Вывод: Dog fetches.
//         }
//     }
// }
