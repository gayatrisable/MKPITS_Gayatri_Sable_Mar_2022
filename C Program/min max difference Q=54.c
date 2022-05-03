#include<stdio.h>
#include<conio.h>
int main()
{
	int a,b,c,d,max,min,diff;
	printf("Enter the value of a\n");
	scanf("%d",&a);
	printf("Enter the value of b\n");
	scanf("%d",&b);
	printf("Enter the value of c\n");
	scanf("%d",&c);
	printf("Enter the value of d\n");
	scanf("%d",&d);
	if(a>=b && a>=c && a>=c)
	{
		max=a;
	}
	else
	if(b>=c && b>=d)
	{
		max=b;
	}
	else
	if(c>=d)
	{
		max=c;
	}
	else
	{
	 max=d;	
	}
	if(a<=b && a<=c && a<=d)
	{
		min=a;
	}
	else
	if(b<=c && b<=d)
	{
		min=b;
	}
	else 
	if(c<=d)
	{
		min=c;
	}
	else
	{
		min=d;
}
printf("Max is %d \n",max);
printf("min is %d \n",min);
diff=max-min;
printf("difference is %d",diff);
}