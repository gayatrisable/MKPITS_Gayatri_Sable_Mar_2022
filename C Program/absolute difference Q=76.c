#include<stdio.h>
#include<conio.h>
int main()
{
	int n,c,a=51;
	printf("Enter the value:");
	scanf("%d",&n);
	
	if(n>a)
	{
		c=(n-a)*3;
	}
	else
	{
		c=a-n;
	}
	printf("%d",c);
}
