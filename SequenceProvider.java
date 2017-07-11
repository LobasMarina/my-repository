public class SequenceProvider {
  /**
   * This method checks the sequence for the correctness of the entered elements
   *
   * @param args a sequence to be analyzed
   * @return false if the string contains the wrong item, true if the sequence contains only numbers
   */
  public boolean checkOnCorrectness(String[] args) {
    for (String currentElementOfMassive : args) {
      for (int i = 0; i < currentElementOfMassive.length(); i++) {
        if (!Character.isDigit(currentElementOfMassive.charAt(i))) {
          return false;
        }
      }
    }
    return true; 
  }
}
