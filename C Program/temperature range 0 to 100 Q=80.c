#include<stdio.h>
#include<conio.h>
int main()
{
	int n;
	printf("Enter the temperature:");
	scanf("%d",&n);
	if(0<=n||n>=100)
	{
		printf("between temperature range");
	}
	else
	{
		printf("not in the range");
	}
}
