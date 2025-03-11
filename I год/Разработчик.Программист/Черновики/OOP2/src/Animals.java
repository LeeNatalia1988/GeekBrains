import java.text.SimpleDateFormat;
import java.util.Date;

abstract class Animals {
    public static String name;
    public static String birthDate;
    public static String getName() {
        return name;
    }


    public void setName(String name) {
        this.name = name;
    }

    public static String getBirthDate() {
        return birthDate;
    }

    public void setBirthDate(String birthDate) {
        this.birthDate = birthDate;
    }

}

class Cat extends Animals {
    public Cat(String name, String birthDate) {
        this.name = name;
        this.birthDate = birthDate;
    }

    public static String getType() {
        String type = "Кот";
        return type;
    }

    public static String getCommands() {
        return "Мяукает";
    }
}

class Dog extends Animals {
    public Dog(String name, String birthDate) {
        this.name = name;
        this.birthDate = birthDate;
    }

    public static String getType() {
        String type = "Собака";
        return type;
    }

    public static String getCommands() {
        return "Лает";
    }

}

class Hamster extends Animals {

    public Hamster(String name, String birthDate) {
        this.name = name;
        this.birthDate = birthDate;
    }

    public static String getType() {
        String type = "Хомячок";
        return type;
    }

    public static String getCommands() {
        return "Крутит колесо";
    }
}