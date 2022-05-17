#include<stdio.h>
#include<conio.h>
void main()
{
	int sum,n1,n2;
	printf("Enter 1st Number: ");
	scanf("%d",&n1);
	printf("Enter 2nd Number: ");
	scanf("%d",&n2);
	
	sum=n1+n2;
	
	if(sum>=10 && sum<=20)
	{
		printf("Is in range ");
	}
	else
	{
		printf("Not in Range ");
	}
}