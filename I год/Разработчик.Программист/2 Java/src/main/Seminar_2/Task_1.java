//1) Дана строка sql-запроса "select * from students where ". Сформируйте часть WHERE этого запроса,
//// используя StringBuilder. Данные для фильтрации приведены ниже в виде json-строки.
////Если значение null, то параметр не должен попадать в запрос.
//// Параметры для фильтрации: {"name":"Ivanov", "country":"Russia", "city":"Moscow", "age":"null"}
//// select * from students where 'name=Ivanov' and 'country=Russia' and...
package main.Seminar_2;

public class Task_1 {
    public static void main(String[] args) {
        String list = "\"name\":\"Ivanov\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"";
        System.out.println("Строка:");
        System.out.println(list);
        StringBuilder resultSelect = request(list);
        System.out.println(resultSelect);
    }
    public static StringBuilder request(String line) {
        String line_1 = line.replace("{", "");
        String line_2 = line_1.replace("}", "");
        String line_3 = line_2.replaceAll("\"", "");
        StringBuilder result = new StringBuilder("select * from students where ");

        String [] array = line_3.split(", ");
        for (int i =0; i < array.length; i++) {
            String[] array_1 = array[i].split(":");
            if(array_1[1].equals("null") == false) {
                if (i != 0) {
                    result.append(", ");
                    result.append(array_1[0]);
                    result.append(" = ");
                    result.append(array_1[1]);
                } else {
                    result.append(array_1[0]);
                    result.append(" = ");
                    result.append(array_1[1]);
                }
            }

        }
        return result;
    }
}
