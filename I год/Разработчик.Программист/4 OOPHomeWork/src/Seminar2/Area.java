package Seminar2;

public interface Area extends Width, Height {
    default Double calculateArea(){
        return 50.0;
    };

}
