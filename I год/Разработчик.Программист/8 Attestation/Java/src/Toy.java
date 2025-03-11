public class Toy {
    private Integer id;
    private String name;
    private Integer weight;

    public Toy(Integer id, String name, Integer weight) {
        this.id = id;
        this.name = name;
        this.weight = weight;
    }

    public Integer getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    public Integer getWeight() {
        return weight;
    }
}
