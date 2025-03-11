package Seminar2;

public class Rectangle implements Width, Height, Color, Area, Perimeter {
    private Double width = getWidth();
    @Override
    public Double calculateArea(){
        return getWidth()*Height;
    }
    @Override
    public Double calculatePerimeter(){ return 2 * (getWidth() + Height); }
}
