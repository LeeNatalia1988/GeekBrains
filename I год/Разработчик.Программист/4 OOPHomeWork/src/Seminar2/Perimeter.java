package Seminar2;

public interface Perimeter extends Width, Height {
    default Double calculatePerimeter(){
        return 50.0;
    }
}
