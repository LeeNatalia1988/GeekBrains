import java.io.FileWriter;
import java.io.IOException;
import java.util.PriorityQueue;
import java.util.Random;

public class ToysStore {

    public static void main(String[] args) {
        String first = "1 2 Конструктор";
        String second = "2 2 Робот";
        String third = "3 6 Кукла";
        PriorityQueue<Toy> toysQueue = new PriorityQueue<>((toy1, toy2) -> Double.compare(toy2.getWeight(), toy1.getWeight()));
        put(first, toysQueue);
        put(second, toysQueue);
        put(third, toysQueue);
//        for (Toy s : toysQueue) {
//            System.out.println(String.valueOf(s.getId()) + " " + s.getName() + " " + s.getWeight());
//        }
        writeToFile(toysQueue);
    }

    public static void put(String string, PriorityQueue<Toy> toysQueue) {
        String[] inputData = string.split(" ");
        int id = Integer.parseInt(inputData[0]);
        int weight = Integer.parseInt(inputData[1]);
        String name = inputData[2];
        Toy toy = new Toy(id, name, weight);
        toysQueue.add(toy);
    }

    public static String get(PriorityQueue<Toy> toysQueue) {
        int allWeight = toysQueue.stream().mapToInt(toy -> toy.getWeight()).sum();
        Random random = new Random();
        int count = random.nextInt(allWeight);
        int neededWeight = 0;
        String neededToy = "";
        for (Toy toy : toysQueue) {
            neededWeight += toy.getWeight();
            if (count < neededWeight) {
                neededToy = String.valueOf(toy.getId()) + " " + toy.getName();
                return neededToy;
            }
        }
        return "Ой...";
    }

    public static void writeToFile(PriorityQueue<Toy> toysQueue) {
        try (FileWriter fileWriter = new FileWriter("ToyStore.csv")) {
            for (int i = 0; i < 10; i++) {
                String toysList = get(toysQueue);
                fileWriter.write(toysList + "\n");
            }
        } catch (IOException e) {
            e.printStackTrace();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}



