#include<stdio.h>
#include<conio.h>
int main()
{
	int i,n;
	printf("Enter a number:");
	scanf("%d",&n);
	printf("All positive divisior of %d\n",n);
	for(i=1;i<=n;i++)
	{
		if(n%i==0)
		{
			printf("%d\n",i);
		}
	}
}