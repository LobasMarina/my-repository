public class Dev1 {
    public static void main(String[] args) {
        for (int a = 0; a <= 100; a++) {
            if (a % 3 == 0) {
                int n = a / 3;
                System.out.println("3*" + n);
            } else {
                System.out.println(a);
            }
        }
    }
}