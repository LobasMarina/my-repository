import java.util.Scanner;

public class NumericSequence {
  public static void main(String[] args) {
    System.out.println("Enter a sequence of numbers separated by spaces: ");
    Scanner input = new Scanner(System.in);
    String inputNumber = input.nextLine();
    String array[] = inputNumber.split(" ");
      for (int i = 0; i < array.length-1; i++) {
        if (Integer.parseInt( array[i+1]) > Integer.parseInt( array[i])) {
          System.out.println("The sequence is non-decreasing.");
          return;
        }
      }  
    System.out.println("The sequence is decreasing.");
  }
}