#include<stdio.h>
#include<conio.h>
int main()
{
	int a,b,c,h;
	printf("Enter the value=");
	scanf("%d%d%d",&a,&b,&h);
	c=a+b*h/2;
	printf("Area of Trapezoid=%d",c);
}