import java.io.File;
import java.text.SimpleDateFormat;
import java.util.*;

public class AnimalRegistry {
    private static Map<String, List<String>> petsRegistry = new HashMap<>();

    public static void printRegistry(){
        for (Map.Entry<String, List<String>> pair : petsRegistry.entrySet()) {
            System.out.println(pair.getKey()+", "+pair.getValue());
        }
    }

    public static void addAnimal(String name, String type, String birthDate, String commands){
        ArrayList<String> list = new ArrayList<String>(3);
        list.add(type);
        list.add(birthDate);
        list.add(commands);
        petsRegistry.put(name, list);
    }

    public static void findCommands(String name) {
        String[] dataAnimal = petsRegistry.get(name).toString().split(", ");
        System.out.println(dataAnimal[2].toString().replace("]",""));
    }


}

