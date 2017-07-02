/**
 * Sequence analysis.
 */

public class Sequence {
  /**
   * Defines the input sequence and writes the result to the console.
   *
   * @param array a sequence to be analyzed
   * @return a string with information which is the sequence
   */
  String result;

  public String sequenceChek(String[] array) {
    for (int i = 0; i < array.length - 1; i++) {
      if (Integer.parseInt(array[i + 1]) > Integer.parseInt(array[i])) {
        result = "The sequence is non-decreasing";
      } else {
        result = "The sequence is decreasing";
      }
    }
    return result;
  }
}