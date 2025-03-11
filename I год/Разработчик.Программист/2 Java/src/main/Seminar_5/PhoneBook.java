package main.Seminar_5;

import java.awt.*;
import java.security.Key;
import java.util.*;
import java.util.List;
import java.util.Map.Entry;
import java.util.stream.Stream;
import java.util.Comparator;

public class PhoneBook {
private static Map<String, List<String>> phone_book = new TreeMap<>();

    public static void add(String LastName, String Phone){
        if (phone_book.containsKey(LastName)){
            List<String> list = phone_book.get(LastName);
            list.add(Phone);
            phone_book.put(LastName, list);
        }
        else {
            phone_book.put(LastName, Collections.singletonList(Phone));
        }
        }
    }

    public static void print(){
        //Stream sorted = phone_book.entrySet().stream().sorted(Comparator.comparing(phone_book.get(Key)::size)).reversed();
        phone_book.entrySet().stream()
                .sorted(Map.Entry.<String, List<String>>comparingByValue().reversed())
                .forEach(System.out::println);
        System.out.println(phone_book);
    }
    public static void found(String LastName){
        if(phone_book.containsKey(LastName)){
            System.out.println(phone_book.get(LastName));
        }
    }
    public static void delete(String LastName){
        if(phone_book.containsKey(LastName)){
            phone_book.remove(LastName);
        }
    }

}
