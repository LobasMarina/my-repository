import java.util.Scanner;

public class Numeric_sequence {
  public static void main(String[] args) {
    Scanner in = new Scanner(System.in);
    System.out.print("Enter a sequence of numbers: ");
    boolean flag = true;
    String input_number = in.nextLine();
    String array[] = input_number.split(" ");
    int sequence[] = new int[array.length];
      for (int i = 0; i < array.length; i++) {
        sequence[i] = Integer.parseInt(array[i]);
      }
      for (int i = 1; i < sequence.length; i++) {
        if (sequence[i] >= sequence[i - 1]) {
          flag = true;
          System.out.println("The numerical sequence is non-decreasing");
          break;
        } else {
          System.out.println("A numeric sequence is decreasing");
          flag = false;
          break;
      }
    }
  }
}
