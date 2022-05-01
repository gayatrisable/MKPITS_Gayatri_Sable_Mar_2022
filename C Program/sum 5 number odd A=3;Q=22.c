#include<stdio.h>
#include<conio.h>
int main()
{
	int i,num[5],total=0;
	printf("\nEnter the 1st value:");
	scanf("%d",&num[0]);
	printf("\nEnter the 2nd value:");
	scanf("%d",&num[1]);
	printf("\nEnter the 3rd value:");
	scanf("%d",&num[2]);
	printf("\nEnter the 4th value:");
	scanf("%d",&num[3]);
	printf("\nEnter the 5th value:");
	scanf("%d",&num[4]);
	for(i=0;i<5;i++)
	{
		if((num[i]%2)!=0)
		{
			total+=num[i];
		}
	}
	printf("\nSum of all odd value:%d",total);
}