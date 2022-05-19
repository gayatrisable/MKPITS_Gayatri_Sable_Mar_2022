#include<stdio.h>
#include<conio.h>
int sub(int,int);
int main()
{
	int a,b,c;
	printf("enter the value of a :");
	scanf("%d",&a);
	printf("enter the value of b :");
	scanf("%d",&b);
	c=sub(a,b);
	printf("sub=%d",c);
}
int sub(int x,int y)
{
	int sub;
	sub=x-y;
	return sub;
}
