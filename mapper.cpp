/*
This program demonstrates the use of the map container in C++.
The program implements an auto-correct feature that corrects the spelling of words.
The program initializes a map that maps incorrect words to their correct versions.
The program then tests the auto-correct feature by calling the FindAutoCorrect function with some words.
*/

#include <algorithm> // std::transform
#include <map> // std::map
#include <iostream> // std::cout, std::endl
#include <string> // std::string

// include the header for asserts
#include <cassert>

using std::cout, std::endl, std::string, std::map, std::less;

std::map<string, string , less<string>> AutoCorrect;

/*
Create a function 'InitializeAutoCorrectTable' that initializes the AutoCorrect table with random corrections.
details:
- AutoCorrect table is a map that maps a string to another string.
- The key is the incorrect word and the value is the correct word.
- The table should have at least 3 entries.
- The table should be initialized with the following entries:
	- "abouta" -> "about a"
	- "agian" -> "again"
	- "towrad" -> "toward"
    - "the the" -> "the"
    - "a a" -> "a"
 */
void InitializeAutoCorrectTable()
{
    AutoCorrect["abouta"] = "about a";
    AutoCorrect["agian"] = "again";
    AutoCorrect["towrad"] = "toward";
    AutoCorrect["the the"] = "the";
    AutoCorrect["a a"] = "a";
}

/*
 Create a function 'FindAutoCorrect' that finds the auto-corrected version of a word.
 details:
 - The function should take a string 'word' as an argument.
 - The function should return the auto-corrected version of the word.
 - If the word is not found in the AutoCorrect table, the function should return the word itself.

 Example:
 - FindAutoCorrect("abouta") should return "about a"
 */
string FindAutoCorrect(string word)
{
	auto it = AutoCorrect.find(word);
	if (it != AutoCorrect.end())
	{
		return it->second;
	}
	return word;
}

/*
Create a function 'testAutoCorrect' that tests the 'FindAutoCorrect' function.
details:
- The function should call the 'FindAutoCorrect' function with the following words:
	- "abouta"
	- "towrad"
- The function should assert that the returned values are correct.
- Print a message to the console indicating that the test has passed.
*/
void testAutoCorrect()
{
    assert(FindAutoCorrect("abouta") == "about a");
    assert(FindAutoCorrect("towrad") == "toward");
    cout << "Test passed!" << endl;
}



int main()
{
	InitializeAutoCorrectTable();

	string word;
	string result;
	
	word = "abouta";
	result = FindAutoCorrect(word);
	cout << result << endl;
	
	word = "towrad";
	result = FindAutoCorrect(word);
	cout << result << endl;
}
