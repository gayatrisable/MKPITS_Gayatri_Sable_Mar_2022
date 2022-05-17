#include<stdio.h>
#include<conio.h>
void mul();
int main()
{
	mul();
}
void mul()
{
	int a,b,mul;
	printf("enter two numbers :");
	scanf("%d%d",&a,&b);
	
	mul=a*b;
	{
		printf("%d",mul);
	}
}
