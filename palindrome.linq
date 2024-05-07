<Query Kind="Statements" />

bool IsPalindrome(string input) {
	if(input?.Length <= 1) return true;
	
	if(input != null && input.First() == input.Last()) {
		return IsPalindrome(input.Substring(1, input.Length - 2));
	}
	
	return false;
}

IsPalindrome("").Dump(); 					// true
IsPalindrome("a").Dump(); 					// true
IsPalindrome("abba").Dump(); 				// true
IsPalindrome("erra").Dump(); 				// false
IsPalindrome("tenet").Dump(); 				// true
IsPalindrome("jelenovipivonelej").Dump(); 	// true
IsPalindrome("ahoj").Dump(); 				// false
IsPalindrome("janko").Dump(); 				// false
IsPalindrome(null).Dump(); 					// false

