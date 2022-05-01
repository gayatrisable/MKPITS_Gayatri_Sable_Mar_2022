#include<stdio.h>
#include<conio.h>
int main()
{
	int x,y,temp,i,sum=0;
	printf("Enter the value of x:");
	scanf("%d",&x);
	printf("Enter the value of y:");
	scanf("%d",&y);
	if(x>y)
	{
		temp=y;
		y=x;
		x=temp;
	}
	for(i=x;i<=y;i++)
	{
		if((i%17)!=0)
		{
			sum=sum+i;
		}	

		}	
			printf("\n Sum:%d\n",sum);
			}