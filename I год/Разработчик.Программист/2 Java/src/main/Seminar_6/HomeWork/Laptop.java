package main.Seminar_6.HomeWork;

import java.util.Scanner;

public class Laptop {
    private Integer id;
    private String brand;
    private String cpu;
    private Integer ram;
    private Integer ssd;
    private String os;
    private String color;

    public Laptop(Integer id, String brand, String cpu, Integer ram, Integer ssd, String os, String color) {
        this.id = id;
        this.brand = brand;
        this.cpu = cpu;
        this.ram = ram;
        this.ssd = ssd;
        this.os = os;
        this.color = color;
    }

    @Override
    public String toString() {
        return "id: " + id + "  ТМ: " + brand + "  Процессор: " + cpu + "  ОЗУ: " + ram + "  ЖД: " + ssd + "  ОС: "
                + os + "  Цвет: " + color + "\n";
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof Laptop)) return false;
        Laptop laptop = (Laptop) o;
        return id.equals(laptop.id);
    }

    @Override
    public int hashCode() {
        return id.hashCode();
    }
//    public boolean filterTM(String TM){
//        if(this.trademark.equals(TM)) return true;
//        else return false;
//    }
    public String getBrand() {
        return brand;
    }
    public Integer getRAM() {
        return ram;
    }
    public Integer getSSD() {
        return ssd;
    }
    public String getOS() {
        return os;
    }
    public String getColor() {
        return color;
    }


}
