#include<stdio.h>
#include<conio.h>
void neg();
void main()
{
	neg();
}
void neg()
{
	int x;
	printf("Enter number: ");
	scanf("%d",&x);
	if(x<0)
	{
		printf("%d",x*-1);
	}
	else
	{
		printf("%d",x);
	}
}