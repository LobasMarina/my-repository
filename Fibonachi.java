import java.util.Scanner;

public class Fibonachi {
  public static void main(String[] args) {
    final int INT_LENGHT = 2147483647;
    System.out.print("Enter the number: ");
    Scanner in = new Scanner(System.in); 
    boolean flag = true;
    int a = 0;
    int b = 1;
    int x = 0;
    int fib = in.nextInt();
    for (int i = 0; x < INT_LENGHT; i++) {
      x = a + b;
      a = b;
      b = x;
      if (fib == x) {
        System.out.print("Is a Fibonacci number");
        flag = false;
        break;
        }
      }
      if (flag) {
        System.out.print("This is not a Fibonacci number");
      }
    }
  }