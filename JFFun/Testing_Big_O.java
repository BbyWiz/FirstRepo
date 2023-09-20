public class Testing_Big_O {

    public static void main(String[] args) {
        int[] numbers = {1, 2, 3, 4, 5};
        foo(numbers);
    }

    static void foo(int[] array) {
        int sum = 0;
        int product = 1;
        for (int i = 0; i < array.length; i++) {
            sum += array[i];
        }
        for (int i = 0; i < array.length; i++) {
            product *= array[i];
        }
        System.out.println(sum + "," + product);
    }
}
