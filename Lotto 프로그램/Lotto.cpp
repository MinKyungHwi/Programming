#include<iostream>
#include<stdlib.h>
#include<ctime>

using namespace std;

int main(){
	int Lotto[45] = {};	
	srand((unsigned)time(0));
	
	/*
	for (int i=0; i<6 ; ++i){
		cout << (rand() % 45 +1) <<endl;
	}
	*/  
	//�ߺ� �߻�  
	
	int Temp, index1, index2;
	
	//�迭 0~44�� ���� 1~45 �Է� 
	for(int i=0; i<45 ; ++i){
		Lotto[i] = i+1;
	}
	
	// ��Point ��
	// index1, index2�����ϰ� ���� �ް�  
	//swap �˰������� Lotto �迭�� ���� �̵����Ѽ� �ߺ��� ���ش�. 
	for( int i=0 ; i<100 ; ++i){
		index1 = rand() %45;
		index2 = rand() %45;
		
		//swap �˰��� 
		Temp = Lotto[index1];
		Lotto[index1] = Lotto[index2];
		Lotto[index2] = Temp;
	}
	
	//��� 
	for(int i=0; i<6; ++i){
		cout << Lotto[i] << "\n";
	}
	cout << "���ʽ� ��ȣ : " << Lotto[6] <<"\n"; 
	
	return 0;
}
