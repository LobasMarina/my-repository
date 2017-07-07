/**
 * Analyzes integer sequences.
 */
public class Sequence {
  /**
   * Defines the input sequence and writes the result to the console.
   *
   * @param args a sequence to be analyzed
   * @return true if sequence is non-decreasing, false if sequence is decreasing
   */
  public boolean sequenceCheck(String[] args) {
    for (int i = 0; i < args.length - 1; i++) {
      if (Integer.parseInt(args[i]) > Integer.parseInt(args[i + 1])) {
        return false;
      }
    }
    return true;
  }
}