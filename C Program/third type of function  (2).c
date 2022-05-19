#include<stdio.h>
#include<conio.h>
int add(int,int);
int main()
{
	int a,b,c=0;
	printf("enter the value of a :");
	scanf("%d",&a);
	printf("enter the value of y :");
	scanf("%d",&b);
	c=add(a,b);
	printf("%d",c);
}
int add(int x,int y)
{
	int add;
	add=x+y;
	return add;
}
