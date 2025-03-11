package Seminar3.Task_4;

import java.util.ArrayList;
import java.util.List;

public class Animal implements Comparable<Animal> {
    private String name;
    private int age;

    public Animal(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public String getName() {
        return name;
    }

    public int getAge() {
        return age;
    }

    @Override
    public String toString() {
        return "Animal{" +
                "name='" + name + '\'' +
                ", age=" + age +
                '}';
    }

    @Override
    public int compareTo(Animal otherAnimal) {
        return this.age - otherAnimal.age;
    }

    public static void main(String[] args) {
        List<Animal> animals = new ArrayList<>();
        animals.add(new Animal("Cat", 5));
        animals.add(new Animal("Dog", 3));
        animals.add(new Animal("Elephant", 10));
        animals.add(new Animal("Lion", 7));

        // Список животных будет автоматически отсортирован по возрасту
        animals.sort(null);

        // Выводим отсортированный список животных
        for (Animal animal : animals) {
            System.out.println(animal);
        }
    }
}
