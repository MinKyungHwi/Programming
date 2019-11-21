#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;

int main()
{
	srand((unsigned)time(NULL));
	int array[9] = {};
	// 1~ 9 가지 숫자를 설정한다.
	for (int i = 0; i < 9; i++) {
		array[i] = i+1;
	}

	int temp, ind1, ind2;
	for (int i= 0; i < 100; i++) {
		ind1 = rand() % 9;
		ind2 = rand() % 9;

		temp = array[ind1];
		array[ind1] = array[ind2];
		array[ind2] = temp;
	}

	cout << "*" << '\t' <<  "*" << '\t' << "*" << endl;
	
	int Strike = 0, Ball = 0;
	int input[3];
	int count = 1; 


	// 입력 오류 검출
	while (true) {
		cout << count << "회" <<endl;
		cout << "1~ 9 사이 3개 입력하세요 (0 : 종료 ) :  ";
		cin >> input[0] >> input[1] >> input[2];

		if (input[0] == 0 || input[1] == 0 || input[2] == 0) {
			break;
		}
		
		else if (input[0] < 0 || input[0] > 9 || input[1] < 0 || input[1] > 9 || input[2] < 0 || input[2] > 9) {
			cout << "\n";
			cout << "입력을 다시 해주세요 " << endl;
			continue;
		}
		else if (input[0] == input[1] || input[0] == input[2] || input[1] == input[2]) {
			cout << "\n";
			cout << "중복된 숫자를 입력했습니다. " << endl;
			continue;
		}

		// 첫 번째 실행시 데이터가 남아있어서 다시 초기화
		Strike = Ball = 0;

		//입력 값이 해당 위치와 일치하는지 확인
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				if (array[i] == input[j]) {
					if (i == j)
						++Strike;
					else
						++Ball;
					break;

				}
			}
		}

		// 결과 출력
		if (Strike == 3) {
			cout << "\n";
			cout << "모두 맞춤" << endl;
			break;
		}
		else if (Strike == 0 && Ball == 0)
			cout << "out " << endl;
		else 
			cout << "Strike: "<<Strike << " \t "  << "Ball : "<< Ball << endl;	

		cout << endl;
		count++;
	}
}