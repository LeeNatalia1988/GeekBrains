public class Gen1<E1,E2> {
    
    E1 ob1;

    E2 ob2;

    public Gen1(E1 o1, E2 o2) {
        ob1 = o1;
        ob2 = o2;
    }

    public E1 getOb1() {
        return ob1;
    }

    public E2 getOb2() {
        return ob2;
    }


    public void showType() {
        System.out.println("Тип объекта 1 " + ob1.getClass().getName());
        System.out.println("Тип объекта 2 " + ob2.getClass().getName());
    }
} 