#include<stdio.h>
#include<conio.h>
int main()
{
	int a,b,c;
	printf("Enter two integers:");
	scanf("%d%d",&a,&b);
	
	if(a==b)
	{
		c=(a+b)*3;
	}
	else
	{
		c=a+b;
	}
	printf("%d",c);
}
