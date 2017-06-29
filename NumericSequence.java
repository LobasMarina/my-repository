import java.util.Scanner;

public class NumericSequence {
  public static void main(String[] args) {
    if (args.length != 0) {
      sequence(args);
    } else {
    System.out.println("Enter a sequence of numbers separated by spaces: ");
    Scanner input = new Scanner(System.in);
    String inputNumber = input.nextLine();
    String array[] = inputNumber.split(" ");
    sequence(array);
    }
  }
    public static void sequence(String[] array) {
      for (int i = 0; i < array.length-1; i++) {
        if (Integer.parseInt( array[i+1]) > Integer.parseInt( array[i])) {
          System.out.println("The sequence is non-decreasing.");
          return;
        }
      }  
      System.out.println("The sequence is decreasing.");
    }
}
