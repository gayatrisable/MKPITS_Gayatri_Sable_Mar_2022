#include<stdio.h>
#include<conio.h>
void fun(int);
int main()
{
	int radius;
	printf("enter the value of radius :");
	scanf("%d",&radius);
	fun(radius);
}
void fun(int radius)
{
	int pi=3.142,a;
	{
		a=pi*(radius*radius);
	}
	printf("a=%d",a);
}

