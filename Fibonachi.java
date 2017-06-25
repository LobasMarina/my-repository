import java.util.Scanner;

public class Fibonachi {
  public static void main(String[] args) {
    System.out.print("Enter the number: ");
    Scanner in = new Scanner(System.in); 
    int input_number = in.nextInt();
    boolean flag = true;
    int fib1 = 0;
    int fib2 = 1;
    int sum = 0;
    for (int i = 0; sum < input_number; i++) {
      sum = fib1 + fib2;
      fib1 = fib2;
      fib2 = sum;
      if (input_number == sum) {
        System.out.print("Is a Fibonachi number");
        flag = false;
        break;
        }
      }
      if (flag) {
        System.out.print("This is not a Fibonachi number");
      }
    }
  }
