package Seminar1;
/*
* Задача 1:
Создайте класс "Кот" (Cat) со следующими свойствами:

Приватное поле "имя" (name) типа String для хранения имени кота.
Приватное поле "возраст" (age) типа int для хранения возраста кота.
Публичные методы доступа (геттеры и сеттеры) для полей "имя" и "возраст".
Публичный метод "приветствие" (greet), который выводит на консоль приветствие вида "Мяу! Меня зовут <имя>. Мне <возраст> года(лет).".
Дополнительное задание:
Создайте класс "Владелец" (Owner) со свойством "имя" (name) типа String.
* Добавьте соответствующее поле в классе "Кот" и методы доступа для него.
* Измените метод "приветствие" класса "Кот", чтобы он выводил приветствие вида
* "Мяу! Меня зовут <имя>. Мне <возраст> года(лет). Мой владелец - <имя владельца>.".*/
class Cat {
    private String name;
    private int age;
    private String owner;
    public void setName(String name) {
        this.name = name;
    }

    public void setAge(int age) {
        this.age = age;
    }
    public void setOwner(String owner){
        this.owner = owner;
    }
    public void GetName(){
        System.out.printf("Имя кота: %s", name);
    }
    public void GetAge(){
        System.out.printf("Возраст кота: %d", age);
    }
    public void getOwner(){
        System.out.printf("Владелец кота: %s", owner);
    }
    public void Greet(){
        System.out.printf("Мяу! Меня зовут %s. Мне %d года(лет). Мой владелец: %s\n", name, age, owner);
    }
}

    class Owner {
        private String owner;
}
