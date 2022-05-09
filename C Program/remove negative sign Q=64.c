#include<stdio.h>
#include<conio.h>
void main()
{
	int x;
	printf("Enter the value of x \n");
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