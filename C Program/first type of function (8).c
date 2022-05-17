#include<stdio.h>
#include<conio.h>
void fact();
int main()
{
	fact();
}
void fact()
{
	int num,i,fact=1;
	printf("enter the value of number :");
	scanf("%d",&num);
	
	for(i=1;i<=num;i++)
	{
		fact=fact*i;
	}
	{
		printf("%d",fact);
	}
}
