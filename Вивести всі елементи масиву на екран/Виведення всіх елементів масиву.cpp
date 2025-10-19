#include <iostream>
using namespace std;
int main() {
	int[] numbers = new int[10];
	numbers[0] = 2;
	numbers[1] = 4;
	numbers[2] = 6;
	numbers[3] = 8;
	numbers[4] = 10;
	numbers[5] = 12;
	numbers[6] = 14;
	numbers[7] = 16;
	numbers[8] = 18;
	numbers[9] = 20;
	for (int i = 0; i < 10; i++) {
		cout << numbers[i] << " ";
	}
	return 0;
}