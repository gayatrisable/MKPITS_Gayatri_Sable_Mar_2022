#include<stdio.h>
#include<conio.h>
int main()
{
	int x1,x2;
	printf("enter two positive numbers: ");
	scanf("%d%d",&x1,&x2);
	if(x1>20&&x1<30&&x2>20&&x2<30)
	{
		if(x1>x2)
		{
			printf("\nlarger value from two integer: %d",x1);
		}
		else
		{
			printf("\nlarger value from two integer: %d",x2);	
		}
	}
	else
	{
		printf("0\n");
	}
}