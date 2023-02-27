#include <iostream>

using namespace std;

bool is_even(int num) {
	return !(num & 1);
}

int main() {
	int num, divs = 2, even_divs = 0;

	cout << "Input one natural number\n";
	cin >> num;
	if (num < 1) {
		cout << "Incorrect input";
		return -1;
	}

	if (num > 1) {
		if (is_even(num))
			even_divs++;
		int buf;
		for (int d = 2; d < num; d++) {
			if (num % d == 0) {
				divs++;
				if (is_even(d))
					even_divs++;
			}
		}
	}
	else {
		divs = 1;
	}

	cout << "Result: " << divs << " divisors, " << even_divs << " even divisors.";

	return 0;
}
