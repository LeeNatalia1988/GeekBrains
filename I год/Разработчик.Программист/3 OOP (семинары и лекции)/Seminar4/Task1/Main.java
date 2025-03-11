public class Main {
    
    public static void main(String[] args) {

        // Gen<Integer> iob = new Gen<Integer>(88);

        // iob.showType();

        // int v = iob.getOb();

        // System.out.println("Значение iob " + v);

        // Gen<String> sob = new Gen<>("Строка");

        // sob.showType();

        // String s = sob.getOb();

        // System.out.println("Значение sob " + s);

        Gen1<Integer, String> ob = new Gen1<>(88, "Тест");

        ob.showType();

        int v = ob.getOb1();

        System.out.println("Значение ob.v " + v);
        
        String str = ob.getOb2();

        System.out.println("Значение ob.str " + str);
    }
}
