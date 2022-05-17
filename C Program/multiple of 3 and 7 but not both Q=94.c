#include<stdio.h>
#include<conio.h>
void main()
{
	int n;
	printf("Enter Any Number: ");
	scanf("%d",&n);
	
	if(n%3==0 && n%7==0)
	{
		printf("Not Multiple Of 3 or 7");
	}
	else
	if(n%3==0)
	{
		printf("Multiple Of 3");
	}
	else
	if(n%7==0)
	{
		printf("Multiple Of 7");
	}
	else
	{
      printf("Not Multiple Of 3 or 7");
    }
}