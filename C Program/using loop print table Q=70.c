#include<stdio.h>
#include<conio.h>
void main()
{
	int x,y;
	printf("Enter the value: ");
	scanf("%d",&x);
	for(y=1;y<=10;++y)
	{
		printf("%d * %d= %d\n",x,y,x*y);
	}
}