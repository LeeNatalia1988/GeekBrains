package Seminar3.Task_6;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

public class Animal {
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

    public static void main(String[] args) {
        List<Animal> animals = new ArrayList<>();
        animals.add(new Animal("Cat", 5));
        animals.add(new Animal("Dog", 3));
        animals.add(new Animal("Elephant", 10));
        animals.add(new Animal("Lion", 7));

        // Создаем компаратор для сравнения по возрасту с помощью лямбда-выражения
        Comparator<Animal> ageComparator = (animal1, animal2) -> animal1.getAge() - animal2.getAge();

        // Сортируем список животных с помощью компаратора
        animals.sort(ageComparator);

        // Выводим отсортированный список животных
        for (Animal animal : animals) {
            System.out.println(animal);
        }
    }
}
