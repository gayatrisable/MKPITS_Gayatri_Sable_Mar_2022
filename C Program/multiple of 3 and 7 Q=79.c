#include<stdio.h>
#include<stdio.h>
int main()
{
	int n;
	printf("Enter the value:");
	scanf("%d",&n);
	
	if(n%3==0)
	{
		printf("divsible of 3");
	}
	if(n%7==0)
	{
		printf("divsible of 7");
	}
	else
	{
		printf("Not divsible");
	}
}
