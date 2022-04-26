#include<stdio.h>
#include<conio.h>
int main()
{
	int a,b,c;
	printf("Enter the value a,b,c\n");
	scanf("%d%d%d",&a,&b,&c);
	if (a>b)
	{
		if(a>c)
		{
			printf("a is the greater among Three\n");
		}
		else
		{
			printf("c is greater among Three\n");
		}
		}
		else if(b>c)
		printf("b is the greater among Three\n");
		else
		printf("c is the greater among Three\n");
	
}