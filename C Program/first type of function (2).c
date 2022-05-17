#include<stdio.h>
#include<conio.h>

void add();
int main()
{
	add();
}
void add()
{
	int a,b,add=0;
	
	printf("enter two numbers :");
	scanf("%d%d",&a,&b);
	
	add=a+b;
	{
		printf("%d",add);
	}
}

