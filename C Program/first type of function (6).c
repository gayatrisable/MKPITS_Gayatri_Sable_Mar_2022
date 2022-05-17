#include<stdio.h>
#include<conio.h>

void fun();
int main()
{
	fun();
}
void fun()
{
	int radius,res,pi=3.142;
	printf("enter the value of radius :");
	scanf("%d",&radius);
	
	res=pi*(radius*radius);
	{
		printf("%d",res);
	}
}
