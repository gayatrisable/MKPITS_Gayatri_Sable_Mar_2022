#include<stdio.h>
#include<conio.h>
int main()
{
	int a,i,j=1,x=0;
	printf("Enter number of lines:");
	scanf("%d",&a);
	for(i=1;i<=a;i++)
	{
		printf("%d %d %d\n",i,i*i,i*i*i);
	}
}