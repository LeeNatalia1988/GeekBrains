package Seminar2;

public class HeapSort {
    public static void main(String[] args) {
        int[] array = new int[] {1, 2, 5, 6, 8, 4, 10}; //Задаем массив
        System.out.println("Изначальный массив: " + toString(array));
        sort(array);
        System.out.println("Отсортированный массив: " + toString(array));
    }
    public static void sort(int[] array){
        //строим кучу
        for (int i = array.length / 2 -1; i >= 0 ; i--) {
            heapify(array, array.length, i);

        //извлекаем элементы из кучи по очереди
        for (i = array.length - 1; i > 0 ; i--) {
            //переместить корень в конец
            int temp = array[0];
            array[0] = array[i];
            array[i] = temp;

            //вызываем метод heapify на уменьшенной куче
            heapify(array, i, 0);
            }    
        }
    }

    private static void heapify(int[] array, int heapSize, int rootIndex){
        int largest = rootIndex; //наибольший элемент = корень = родитель
        int leftChild = 2 * rootIndex + 1; //левый ребенок
        int rightChild = 2 * rootIndex + 2; //правый ребенок

        //если левый ребенок больше родителя
        if (leftChild < heapSize && array[rightChild] > array[largest])
            largest = leftChild;

        //если правый ребенок больше большего значения
        if (rightChild < heapSize && array[rightChild] > array[largest])
            largest = rightChild;

        //если больший элемент до сих пор не родитель
        if (largest != rootIndex){
            int temp = array[rootIndex];
            array[rootIndex] = array[largest];
            array[largest] = temp;

            //рекурсия поддерева
            heapify(array, heapSize, largest);
        }
    }
    public static String toString(int[] array){
        String sout = "";
        for (int i = 0; i < array.length; i++) {
            sout = sout + (array[i]) + "   ";
        }
        return sout;
    }



}

