import java.util.Scanner;

public class NumericSequence {
  public static void main(String[] args) {
    System.out.println("Enter a sequence of numbers separated by spaces: ");
    Scanner input = new Scanner(System.in);
    String inputNumber = input.nextLine();
    String array[] = inputNumber.split(" ");
    int i;
      for (i = 0; i < array.length-1; i++) {
        if (Integer.parseInt( array[i]) > Integer.parseInt( array[i+1])) {
          continue;
        } else {
            System.out.println("The sequence is non-decreasing.");
            break;
          }
      }
      if (i ==  array.length-1) {
        System.out.println("The sequence is decreasing.");
      }
  }
}