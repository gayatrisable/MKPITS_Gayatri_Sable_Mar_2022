#include<stdio.h>
#include<conio.h>
int main()
{
	int a,b;
	for(a=1;a<=7;a++)
	{
		for(b=1;b<=a;b++)
		{
			if(b==1)
			printf("1");
			else
			printf("0");
		}
		printf("\n");
	}
	for(a=8;a>=1;a--)
	{
		for(b=1;b<=a;b++)
		{
		if(b==1)
		printf("1");
		else
		printf("0");
	}
	printf("\n");
}
}