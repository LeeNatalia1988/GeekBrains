package Task4;

public class Test4main {
    
    public static void main(String[] args) {
        
        Test4 t4 = new Test4();

        System.out.println("Админ " + t4.getAdminID());

        System.out.println("Пользователь " + t4.getUserID());

        System.out.println(MyIf.getUniqueID());
    }
}
