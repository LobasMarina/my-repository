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
    String[] arr = read.splitLine();
    if (args.length == 0) {
      System.out.print(sequence.sequenceChek(arr));
    } else {
      System.out.print(sequence.sequenceChek(args));
    }
  }
}