#include<iostream>
#include<conio.h>
#include<time.h>
#include<stdlib.h>

using namespace std;

int main() {
	srand((unsigned)time(0));

	int array[25] = {};
	for (int i = 0; i < 24; i++) {
		array[i] = i + 1;
	}


	array[24] = INT_MAX;
	int star = 24;

	
	int temp, idx1, idx2;
		

	for (int i = 0; i < 100; i++) {
		idx1 = rand() % 24;
		idx2 = rand() % 24;

		//temp = array[idx1];
		//array[idx1] = array[idx2];
		//array[idx2] = temp;
	}

		while (true) {
			system("cls");
			for (int i = 0; i < 5; i++) {
				for (int j = 0; j < 5; j++) {
					if (array[i * 5 + j] == INT_MAX) {
						cout << "*";
					}
					else
						cout << array[i * 5 + j] << "\t";

				}
				cout << endl;
			}

			bool win = true;
			
			for (int i = 0; i < 25; i++) {
				if (array[i] != i + 1)
					win = false;
					break;
			}


			if (win == true) {
				cout << "숫자를 모두 맞춤 " << endl;
				break;
			}

			cout << "w : 위 s : 아래 a : 왼쪽 d : 오른쪽 z : 종료";
		
			char push = _getch();
			if (push == 'z' || push == 'Z') {
				break;
			}

			switch (push)
			{
			case 'a':
			case 'A':
				if (star % 5 != 0) {
					array[star] = array[star - 1];
					array[star - 1] = INT_MAX;
					--star;
				}
				
				break;
			case 'w':
			case 'W':
				if (star > 4) {
					array[star] = array[star - 5];
					array[star - 5] = INT_MAX;
					star -= 5;
				}			
				break;
			case 'd':
			case 'D':
				if (star % 5 != 4) {
					array[star] = array[star + 1];
					array[star + 1] = INT_MAX;
					++star;
				}
				
				break;

			case 's':
			case 'S':
				if (star < 20) {
					array[star] = array[star + 5];
					array[star + 5] = INT_MAX;
					star += 5;
				}
				break;
			}
		}	
	cout << endl;
	cout << "게임을 종료합니다. " << endl;
	return 0;
}