#include<stdio.h>
#include<conio.h>
int fun(int);
int main()
{
	int radius,c;
	printf("enter the radius");
	scanf("%d",&radius);
	c=fun(radius);
	printf("%d",c);
}
int fun(int radius)
{
	int a,pi=3.142;
	a=pi*(radius*radius);
	return a;
}
