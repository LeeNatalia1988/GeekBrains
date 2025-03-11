package Seminar5.AdditionalTask;

import java.util.*;

public class UserModel {
    private ArrayList<List> users = new ArrayList<>(10);
    private String name;
    private String login;
    private String password;
    private String result;
    Scanner scanner = new Scanner(System.in);

    public void setName(String name) {
        this.name = name;
    }

    public String getName(String name) {
        return name;
    }

    public void setLogin(String login) {
        this.login = login;
    }

    public String getLogin(String login) {
        return login;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getPassword(String password) {
        return password;
    }

    public void registration() {
        System.out.println("Введите имя пользователя: ");
        setName(scanner.nextLine());
        System.out.println("Введите логин пользователя: ");
        setLogin(scanner.nextLine());
        System.out.println("Введите пароль: ");
        setPassword(scanner.nextLine());
        for (List<String> user : users) {
            if (user.get(1).equals(login)) {
                System.out.println("Пользователь с таким логином уже существует!");
                return; // Выход из метода, чтобы не добавлять дубликат
            }
        }

        List<String> logpass = new ArrayList<>(Arrays.asList(name, login, password));
        users.add(logpass);
    }


    public void entrance() {
        System.out.println("Введите логин пользователя: ");
        login = scanner.nextLine();
        System.out.println("Введите пароль: ");
        password = scanner.nextLine();
        boolean userFound = false;
        for (List<String> user : users) {
            if (user.get(1).equals(login) && user.get(2).equals(password)) {
                userFound = true;
                break;
            }
        }

        if (userFound) {
            System.out.println("Ок!");
        } else {
            System.out.println("Такого пользователя не существует!");
        }
    }


    public void changePassword() {
        System.out.println("Введите имя пользователя, у которого хотите сменить пароль: ");
        String name = scanner.nextLine();
        if (users.contains(name)) {
            System.out.println("Введите старый пароль: ");
            String oldPassword = scanner.nextLine();
            if (oldPassword.equals(password)) {
                System.out.println("Введите новый пароль: ");
                String newPassword = scanner.nextLine();
                setPassword(newPassword);
            } else {
                System.out.println("Вы ввели некорректный старый пароль!");
            }
        } else {
            System.out.println("Такого пользователя не существует!");
        }
    }


    public void getResult() {
        System.out.println("Введите имя пользователя: ");
        String name = scanner.nextLine();
        for (List user : users
        ) {
            if (user.contains(name)) {
                System.out.println("Имя пользователя: " + name + "\n" + "Логин: " + login + "\n" + "Пароль: " + password + ".");
            } else {
                System.out.println("Такого пользователя не существует!");
                ;
            }
        }
    }
}

