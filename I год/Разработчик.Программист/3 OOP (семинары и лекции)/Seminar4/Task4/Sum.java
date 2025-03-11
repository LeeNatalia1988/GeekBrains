package Task4;

public class Sum {
    
    private int sum;

    <T extends Number> Sum(T arg) {
        sum = 0;
        for (int i = 0; i <= arg.intValue(); i++) {
            sum += i;
        }    

    }

    int getSum() {
        return sum;
    }
}
