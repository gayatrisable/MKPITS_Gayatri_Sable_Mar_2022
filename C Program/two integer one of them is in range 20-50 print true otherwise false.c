#include<stdio.h>
#include<conio.h>
void main()
{
	int i1,i2;
	printf("Enter two numbers: ");
	scanf("%d%d",&i1,&i2);
	if(i1>20&&i1<50||i2>20&&i2<50)
	{
		printf("true");
	}
	else
	{
		printf("false");
	}
}