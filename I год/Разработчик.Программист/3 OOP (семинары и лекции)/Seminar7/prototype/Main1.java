package prototype;

class Address {
    private String city;
    private String street;

    public Address(String city, String street) {
        this.city = city;
        this.street = street;
    }

    // Конструктор копирования для не глубокого клонирования
    public Address(Address other) {
        this.city = other.city;
        this.street = other.street;
    }

    // Геттеры и сеттеры
    public String getCity() {
        return city;
    }

    public void setCity(String city) {
        this.city = city;
    }

    public String getStreet() {
        return street;
    }

    public void setStreet(String street) {
        this.street = street;
    }
}

class Person {
    private String name;
    private int age;
    private Address address;

    public Person(String name, int age, Address address) {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    // Конструктор копирования для не глубокого клонирования
    public Person(Person other) {
        this.name = other.name;
        this.age = other.age;
        // Производим клонирование Address с помощью конструктора копирования
        this.address = new Address(other.address);
    }

    // Геттеры и сеттеры
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public Address getAddress() {
        return address;
    }

    public void setAddress(Address address) {
        this.address = address;
    }

    // Метод копирования
    public Person copy() {
        return new Person(this);
    }

    @Override
    public String toString() {
        return "Person: " + name + ", age: " + age + ", address: " + address.getCity() + ", " + address.getStreet();
    }
}

public class Main1 {
    public static void main(String[] args) {
        Address address = new Address("CityA", "StreetA");
        Person person1 = new Person("Alice", 30, address);

        // Копируем объект person1
        Person person2 = person1.copy();

        // Изменяем поле в скопированном объекте
        person2.setName("Bob");
        person2.getAddress().setCity("CityB");

        // Выводим информацию об объектах
        System.out.println("Person 1: " + person1);
        System.out.println("Person 2: " + person2);
    }
}
