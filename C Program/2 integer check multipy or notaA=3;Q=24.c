#include<stdio.h>
#include<conio.h>
int main()
{
	int a,b,c;
	printf("Enter the 1st value:\n");
	scanf("%d",&a);
	printf("Enter the 2nd value:\n");
	scanf("%d",&b);
	if(a>b)
	{
	  c=a;
	  a=b;
	}
	if((b%a)==0)
	{
		printf("\nMultiplied\n");
	}
	else
	{
		printf("\nNot Multiplied\n");
	}
}