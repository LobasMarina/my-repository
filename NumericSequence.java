/**
 * The program determines that the user-entered sequence of integers is non-decreasing.
 * The user can enter the sequence as a command-line argument.
 * If the user doesn't enter the sequence as a command-line argument,
 * the program requests a sequence from the console.
 */
public class NumericSequence {
  public static void main(String[] args) {
    Sequence sequence = new Sequence();
    ReadFromConsole read = new ReadFromConsole();
    SequenceProvider provider = new SequenceProvider();
    String[] consoleInput = args;
    while (!(provider.checkOnLetters(consoleInput)) || consoleInput.length < 2) {
      System.out.println("You have not entered enough numbers or wrong of values");
      consoleInput = read.splitLine();
    }
    if (sequence.sequenceCheck(consoleInput)) {
      System.out.println("Non-decreasing");
    } else {
      System.out.println("Decreasing");
    }
  }
}