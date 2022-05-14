#include<stdio.h>
#include<conio.h>
int main()
{
	int a,b;
	printf("Enter the two value: ");
	scanf("%d%d",&a,&b);
	if((a%10)==(b%10))
	{
		printf("true");
	}
	else
	{
		printf("false");
	}
}