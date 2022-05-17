#include<stdio.h>
#include<conio.h>
void main()
{
	int n;
	printf("Enter Any Number: ");
	scanf("%d",&n);
	
	if(n%13==0 || n%13==1 )
	{
		printf("Multiple Of 13");
	}
	else
	{
		printf("Not Multiple Of 13");
	}
}