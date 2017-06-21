public class Dev1 {
    public static void main(String[] args) {
        for (int a = 0; a <= 100; a++) {
            if (a % 3 == 0 && a % 5 == 0) {
                System.out.println("Tutti-Frutti");
            } else if (a % 3 == 0) {
                System.out.println("Tutti");
            } else if (a % 5 == 0) {
                System.out.println("Frutti");
            } else {
                System.out.println(a);
            }
        }
    }
}