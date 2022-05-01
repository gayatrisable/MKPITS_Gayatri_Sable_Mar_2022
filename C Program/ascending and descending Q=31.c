#include<stdio.h>
#include<conio.h>
int main()
{
	int x,y;
	printf("Enter two pairs value:\n");
	scanf("%d%d",&x,&y);
	if(x!=y)
	{
		if(y>x)
		{
			printf("Ascending order\n");
		}
		else
		{
			printf("Descending order\n");
		}
	}
}