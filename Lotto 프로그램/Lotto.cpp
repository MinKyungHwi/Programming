#include<iostream>
#include<stdlib.h> 	// rand()  
#include<ctime>		// srand()

using namespace std;

int main(){
	
	int Temp, index1, index2;
	int Lotto[45] = {};	
	srand((unsigned)time(0));

	//배열 0~44번 까지 1~45 입력 
	for(int i=0; i<45 ; ++i){
		Lotto[i] = i+1;
	}
	
	// index1, index2랜덤하게 값을 받고  
	//swap 알고리즘으로 Lotto 배열의 값을 이동시켜서 중복을 없앤다. 
	for( int i=0 ; i<100 ; ++i){
		index1 = rand() %45;
		index2 = rand() %45;
		
		//swap 알고리즘 
		Temp = Lotto[index1];
		Lotto[index1] = Lotto[index2];
		Lotto[index2] = Temp;
	}
	
	//출력 
	for(int i=0; i<6; ++i){
		cout << i+1 << " 번째 번호 : "<<Lotto[i] << "\n";
	}
	cout << "보너스 번호 : " << Lotto[6] <<"\n"; 
	
	return 0;
}
	//중복 발생 
	/*
	for (int i=0; i<6 ; ++i){
		cout << (rand() % 45 +1) <<endl;
	}
	*/  
