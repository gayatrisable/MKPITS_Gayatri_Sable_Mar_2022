#include<stdio.h>
#include<conio.h>
void fun();
int main()
{
	fun();
}
void fun()
{
	int num,r;
	printf("enter value of number :");
	scanf("%d",&num);
	
	r=num%4;
	
	if(r==0)
	{
		printf("divisible by 4");
	}
	if(r!=0)
	{
		printf("is not div by 4");
	}
}
