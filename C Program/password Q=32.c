#include<stdio.h>
#include<conio.h>
int main()
{
	int p,x=10;
	while(x!=0)
	{
		printf("\nEnter the password:");
		scanf("%d",&p);
		if(p==1234)
		{
			printf("correct password");
			x=0;
		}
		else
		{
			printf("wrong password,try another");
		}
		printf("\n");
	}
}