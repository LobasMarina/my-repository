/**
 * The program determines that the user has entered a sequence of integers 
 * is non-decreasing. the argument array a sequence to be analyzed, if the user 
 * has not transferred the sequence in the form of a command-line argument,
 * then a warning will be displayed
 */
public class Sequence {
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