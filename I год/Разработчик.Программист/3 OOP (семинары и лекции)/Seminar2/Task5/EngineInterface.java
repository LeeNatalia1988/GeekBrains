package Task5;

public interface EngineInterface {
    void start();
    void stop();
}

public class Engine implements EngineInterface {
    public void start() {
        System.out.println("Engine started");
    }

    public void stop() {
        System.out.println("Engine stopped");
    }
}

public class ElectricEngine implements EngineInterface {
    public void start() {
        System.out.println("Electric engine started");
    }

    public void stop() {
        System.out.println("Electric engine stopped");
    }
}


public class Car {
    private EngineInterface engine;

    public Car(EngineInterface engine) {
        this.engine = engine;
    }

    public void startCar() {
        engine.start();
    }

    public void stopCar() {
        engine.stop();
    }
}

class Main {
    
    public void foo() {
        Engine e = new Engine();
        ElectricEngine ee = new ElectricEngine();
        Car car1 = new Car(e);
        Car car2 = new Car(ee);

    }
}
