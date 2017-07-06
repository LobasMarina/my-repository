public class SequenceProvider {
  /**
   * Checks sequences for entered letters
   *
   * @param args a sequence to be analyzed
   * @return false if the string contains a letter, true if the sequence does not contain letter
   */
  public boolean checkOnLetters(String[] args) {
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
