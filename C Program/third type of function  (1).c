#include<stdio.h>
#include<conio.h>
int mul(int,int);
int main()
{
	int a,b,c;
	printf("enter the value a :");
	scanf("%d",&a);
	printf("enter the value of b :");
	scanf("%d",&b);
	c=mul(a,b);
	printf("mul=%d",c);
}
int mul(int x,int y)
{
	int mul;
	mul=x*y;
	return mul;
}
