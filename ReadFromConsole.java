import java.util.Scanner;

/**
 * Reads sequences from console.
 */
public class ReadFromConsole {
  /**
   * Requests a sequence of integers from the console.
   *
   * @return the entered sequence.
   */
  public String[] splitLine() {
    Scanner input = new Scanner(System.in);
    System.out.print("Enter the sequence of numbers separated by spaces: ");
    String inputText = input.nextLine();
    return inputText.split(" ");
  }
}