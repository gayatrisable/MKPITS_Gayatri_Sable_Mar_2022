#include<stdio.h>
#include<conio.h>
int main()
{
	int a,b,temp=0;
	for(a=1;a<=200;a++)
	{
		for(b==2;b<=a;b++)
		{
			if(a%b==0)
			{
				temp=temp+1;
			}
		}
		if(temp==0)
		{
			printf("%d\n",a);
		}
		else
		{
			temp=0;
			
		}
	}
}