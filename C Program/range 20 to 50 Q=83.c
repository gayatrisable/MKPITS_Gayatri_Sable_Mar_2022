#include<stdio.h>
#include<conio.h>
int main()
{
	int x,y;
	printf("Enter two integer: ");
	scanf("%d%d",&x,&y);
	if(x>=20 && x<=50||y>=20 && y<=50)
	{
		printf("True");
	}
	else
	{
		printf("False");
	}
}