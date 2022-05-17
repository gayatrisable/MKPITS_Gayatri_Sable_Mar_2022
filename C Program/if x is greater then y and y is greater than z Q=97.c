#include<stdio.h>
#include<conio.h>
void main()
{
	int x,y,z;
	printf("Enter value of x: ");
	scanf("%d",&x);
	printf("Enter value of y: ");
	scanf("%d",&y);
	printf("Enter value of z: ");
	scanf("%d",&z);
	
	if(y>x)
	{
		printf("Y is Greater Than X\n");
	}
	if(z>y)
	{
		printf("Z is Greater Than Y\n");
	}
	else
	{
		printf("X is greater than Y");
	}
}