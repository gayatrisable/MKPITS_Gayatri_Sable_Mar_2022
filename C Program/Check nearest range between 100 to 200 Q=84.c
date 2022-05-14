#include<stdio.h>
#include<conio.h>
int main()
{
	int n1,n2,x1,x2;
	printf("enter two numbers:");
	scanf("%d%d",&n1,&n2);
	
	if(n1>100)
	{
		x1=n1-100;
	}
	else
	{
		x1=100-n1;
	}
	if(n2>100)
	{
		x2=n2-100;
	}
	else
	{
		x2=100-n2;
	}
	if(x1>x2)
	{
		printf("nearest value= %d",n2);
	}
	else if(x2>x1)
	{
		printf("nearest value= %d",n1);	
	}
	else if(n1==n2)
	{
		printf("0");
	}
}
