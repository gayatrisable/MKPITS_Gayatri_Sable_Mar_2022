#include<stdio.h>
#include<conio.h>
int main()
{
	int x,y;
	printf("Enter two integer: ");
	scanf("%d%d",&x,&y);
	if(x>=100 && x<=200||y>=100 && y<=200)
	{
		printf("Range given between");
	}
	else
	{
		printf("given value not between the range");
	}
}