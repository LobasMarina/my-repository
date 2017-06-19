public class main {
    public static void main(String[] args) {

        for (int a=0; a<100; a++) {
            if (a%3==0 && a!=0){
                int N = a / 3;
                System.out.print(" 3*" + N);
            }
            else
                System.out.print(" "+a);
        }

    }
}
