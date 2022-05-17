#include<stdio.h>
#include<conio.h>
void power();
int main()
{
	power();
}
void power()
{
	int x,y,power=1,i;
	printf("enter the value of x :");
	scanf("%d",&x);
	printf("enter the value of y :");
	scanf("%d",&y);
	
	for(i=1;i<=y;i++)
	{
		power=power*x;
	}
	{
		printf("%d",power);
	}
}
