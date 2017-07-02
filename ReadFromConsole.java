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

  Scanner input;
  String inputText;

  public String[] splitLine() {
    input = new Scanner(System.in);
    System.out.print("Enter the number: ");
    inputText = input.nextLine();
    return inputText.split(" ");
  }
}