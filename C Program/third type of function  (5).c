#include<stdio.h>
#include<conio.h>
int power(int,int);
int main()
{
	int a,b,c;
	printf("enter the value of a :");
	scanf("%d",&a);
	printf("enter the value of b ");
	scanf("%d",&b);
	c=power(a,b);
	printf("%d",c);
}
int power(int x,int y)
{
	int i,power=1;
	for(i=1;i<=y;i++)
	{
	power=power*x;
    }
	return power;
}
