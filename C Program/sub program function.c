#include<stdio.h>
#include<conio.h>
void sub();
void main()
{
	sub();
}
void sub()
{
	int n1,n2,total;
	printf("Enter any num:");
	scanf("%d",&n1);
	printf("Enter any num:");
	scanf("%d",&n2);
	total=n1-n2;
	printf("Total=%d",total);
}