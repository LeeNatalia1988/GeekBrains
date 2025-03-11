//package main.Seminar_6;
//
//public class Cat {
//
//    import java.util.List;
//
////  1. Продумайте структуру класса Кот. Какие поля и методы будут актуальны для приложения, которое является
////а) информационной системой ветеринарной клиники
////б) архивом выставки котов
////в) информационной системой Театра кошек Ю. Д. Куклачёва
////Можно записать в текстовом виде, не обязательно реализовывать в java.
//
//// 1. Реализуйте 1 из вариантов класса Cat из предыдущего задания, можно использовать не все придуманные
//// поля и методы. Создайте несколько экземпляров этого класса, выведите их в консоль.
////2. Добейтесь того, чтобы при выводе в консоль объекта типа Cat, выводилась его кличка, цвет и возраст
//// (или другие параметры на ваше усмотрение).
//
//    public class Cat {
//        private String name;
//
//        private String owner;
//
//        private String breed;
//
//        private int age;
//
//        private List<String> healthHistory;
//        //    public Cat(String name, String owner, String breed, int age){
//        public Cat(String name, String owner, String breed, int age){
//            this.name = name;
//            this.owner = owner;
//            this.breed = breed;
//            this.age = age;
//        }
//        public String getName(){
//            return name;
//        }
//        public int getAge(){
//            return age;
//        }
//
//        @Override
//        public String toString(){
//            return "name: " + name + ", owner: " + owner + ", breed: " + breed + ", age: " + age;
//        }
//
//        @Override
//        public boolean equals(Object o){
//            if (this == o) return true;
//            if (!(o instanceof Cat)) return false;
//            Cat cat = (Cat)o;
//            return name.equals(cat.name) && owner.equals(cat.owner) && breed.equals(cat.breed) && age == cat.age;
//        }
//
//        @Override
//        public int hashCode(){
//            return 3*name.hashCode() + 12*age + 5*breed.hashCode() + 8*owner.hashCode();
//        }
//
//    }
//}
