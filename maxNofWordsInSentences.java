package hello.zii;

/* Java program to count no of words 
from given input string. */
public class main {
	static final int OUT = 0;
	static final int IN = 1;

	static int countWords(String str) {
		int state = OUT;
		int wc = 0; // word count
		int i = 0;

		// Scan all characters one by one
		while (i < str.length()) {
			// If next character is a separator, set the
			// state as OUT
			if (str.charAt(i) == ' ' || str.charAt(i) == '\n' || str.charAt(i) == '\t')
				state = OUT;

			// If next character is not a word separator
			// and state is OUT, then set the state as IN
			// and increment word count
			else if (state == OUT) {
				state = IN;
				++wc;
			}

			// Move to next character
			++i;
		}
		return wc;
	}

	public static void main(String[] args) {
		String str = "We test coders. Give us a try?  ";
		//str = "Forget Cvs..Save time . x x";
		String[] sentenceList = str.split("[!?.]+");
		int max = 1;
		for (int i = 0; i < sentenceList.length; i++) {
			int c = countWords(sentenceList[i]);
			if (max < c)
				max = c;
		}

		System.out.println("No of words : " + max);
	}
}