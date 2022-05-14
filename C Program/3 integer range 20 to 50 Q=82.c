#include<stdio.h>
#include<conio.h>
int main()
{
	int x,y,z;
	printf("Enter three integer: ");
	scanf("%d%d%d",&x,&y,&z);
	if(x>=20 && x<=50||y>=20 && y<=50 ||z>=20 && z<=50)
	{
		printf("true");
	}
	else
	{
		printf("false");
	}
}