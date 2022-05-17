#include<stdio.h>
#include<conio.h>
void sub();
int main()
{
	sub();
}
void sub()
{
	int a,b,sub=0;
	
	printf("enter two number :");
	scanf("%d%d",&a,&b);
	
	sub=a-b;
	{
		printf("%d",sub);
	}
}
