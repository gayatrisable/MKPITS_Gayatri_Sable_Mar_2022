#include<stdio.h>
#include<conio.h>
int main()
{
	int r=1,c,a=1;
	for(r=1;r<=4;r++)
	{
		for(c=1;c<=r;c++)
		{
			printf("%d",a++);
		}
		printf("\n");
	}
}