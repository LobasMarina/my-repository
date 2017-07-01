/**
* Reading the entered numbers and forming an array
*/
public class NumericSequence {
  public static void main(String[] args) {
    Sequence sequence = new Sequence();
    ReadFromConsole read = new ReadFromConsole();
    String[] arr = read.splitLine();
    if (args.length == 0) {
      System.out.print(sequence.sequenceChek(arr));
      System.out.print("true");
    } else {
      System.out.print(sequence.sequenceChek(args));
    }
  }
}