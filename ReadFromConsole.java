/**
* Reading the text and returning an array of strings
*/
import java.util.Scanner;

public class ReadFromConsole {

  Scanner input;
  String inputText;

  public String[] splitLine() {
    input = new Scanner(System.in);
    System.out.print("Enter the number");
    inputText = input.nextLine();
    return inputText.split(" ");
  }
}