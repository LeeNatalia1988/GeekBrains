//class ToShape {
//
//    private double width;
//
//    private double height;
//
//    public ToShape(double width, double height) {
//        this.width = width;
//        this.height = height;
//    }
//
//    public ToShape() {
//        this.width = 0;
//        this.height = 0;
//    }
//
//    public ToShape(double size) {
//        this.width = size;
//        this.height = size;
//    }
//
//    public void setWidth(double width) {
//        this.width = width;
//    }
//
//    public void setHeight(double height) {
//        this.height = height;
//    }
//
//    public double getWidth() {
//        return width;
//    }
//
//    public double getHeight() {
//        return height;
//    }
//
//    public void showDim() {
//        System.out.printf("Ширина %.2f, высота %.2f \n", width, height);
//    }
//}
//
//class Triangle extends ToShape {
//
//    String style;
//
//    public Triangle(double height, double width, String style) {
//        super(width, height);
//        this.style = style;
//    }
//
//    public Triangle(double size, String style) {
//        super(size);
//        this.style = style;
//    }
//
//    public Triangle() {
//        super();
//        this.style = "";
//    }
//
//
//    public double area() {
//        return getHeight() * getWidth() / 2;
//    }
//
//    public void showStyle() {
//        System.out.printf("Треугольник %s \n", style);
//    }
//}
