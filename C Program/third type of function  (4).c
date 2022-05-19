#include<stdio.h>
#include<conio.h>
int fact(int);
int main()
{
	int num,c;
	printf("enter the value :");
	scanf("%d",&num);
	c=fact(num);
	printf("%d",c);
}
int fact(int num)
{
	int i,fact=1;
	for(i=1;i<=num;i++)
	{
		fact=fact*i;
	}
	return fact;
	
}

