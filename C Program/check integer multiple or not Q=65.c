#include<stdio.h>
#include<conio.h>
void main()
{
	int x,y;
	printf("Enter the value of x\n");
	scanf("%d",&x);
	printf("Enter the value of y\n");
	scanf("%d",&y);
	if(x%y==0)
	{
		printf("%d is multiple of %d\n",x,y);
	}
	else
	{
		printf("%d is not multipe of %d\n",x,y);
	}
}