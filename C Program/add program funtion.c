#include<stdio.h>
#include<conio.h>
void add();
void main()
{
	add();
}
void add()
{
	int n1,n2,sum;
	printf("Enter any num:");
	scanf("%d",&n1);
	printf("Enter any num:",&n2);
	scanf("%d",&n2);
	sum=n1+n2;
	printf("sum=%d",sum);
}