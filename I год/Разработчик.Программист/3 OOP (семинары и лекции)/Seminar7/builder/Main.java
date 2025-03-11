package builder;

// Продукт
class Car {
    private String brand;
    private String model;
    private int year;
    private String color;

    public void setBrand(String brand) {
        this.brand = brand;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public void setYear(int year) {
        this.year = year;
    }

    public void setColor(String color) {
        this.color = color;
    }

    @Override
    public String toString() {
        return "Car: " + brand + " " + model + " (" + year + "), color: " + color;
    }
}

// Строитель

class CarBuilder {
    private Car car;

    public CarBuilder() {
        this.car = new Car();
    }

    public CarBuilder setBrand(String brand) {
        car.setBrand(brand);
        return this;
    }

    public CarBuilder setModel(String model) {
        car.setModel(model);
        return this;
    }

    public CarBuilder setYear(int year) {
        car.setYear(year);
        return this;
    }

    public CarBuilder setColor(String color) {
        car.setColor(color);
        return this;
    }

    public Car build() {
        return car;
    }
}

public class Main {
    public static void main(String[] args) {
        // CarBuilder carBuilder = new CarBuilder();
        // Car car = carBuilder.setBrand("Toyota")
        //                     .setModel("Camry")
        //                     .setYear(2022)
        //                     .setColor("Red")
        //                     .build();

        // System.out.println(car);

        CarBuilder carBuilder1 = new CarBuilder();
        Car car1 = carBuilder1.setBrand("Toyota")
                              .setModel("Camry")
                              .setYear(2022)
                              .build();

        // Создаем вторую машину без указания цвета
        CarBuilder carBuilder2 = new CarBuilder();
        Car car2 = carBuilder2.setBrand("Honda")
                              .setModel("Accord")
                              .setYear(2023)
                              .build();

        System.out.println("Car 1: " + car1);
        System.out.println("Car 2: " + car2);

    }
}
