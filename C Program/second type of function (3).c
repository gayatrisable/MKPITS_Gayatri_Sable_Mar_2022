#include<stdio.h>
#include<conio.h>
void mul(int,int);
int main()
{
	int a,b;
	printf("enter the value of a :");
	scanf("%d",&a);
	printf("enter the value of y :");
	scanf("%d",&b);
	mul(a,b);
	
}
void mul(int x,int y)
{
	int mul;
	mul=x*y;
	printf("mul=%d",mul);
}
